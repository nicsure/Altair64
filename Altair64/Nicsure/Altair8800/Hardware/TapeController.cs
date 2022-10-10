using NAudio.Wave;
using Nicsure.Altair8800.Hardware.Interfaces;
using Nicsure.General;
using Nicsure.Intel8080;

namespace Nicsure.Altair8800.Hardware
{
    // Code by nicsure (C)2022
    // https://www.youtube.com/nicsure

    public class TapeController : IInputDevice, IOutputDevice, ISendToAble, ICapturable, IResettable
    {
        public string DeviceName => "Cassette";
        public static int ControlPort => 6;
        public static int DataPort => 7;
        public int Captured { get { lock (this) { return captured; } } }
        private long readPos = 0, writePos = 0;
        private readonly byte[] buffer = new byte[65536];
        private MemoryStream capture = null;
        private int captured = 0;
        private readonly CassAudioStream cassStream;
        private readonly CassAudioListener cassListener;
        private WaveOutEvent waveOut = null;

        public System.Windows.Forms.Control FuncIndicator { get; set; } = null;
        public System.Windows.Forms.Control DataIndicator { get; set; } = null;
        private static int[] Ports() => new int[] { ControlPort, DataPort };
        public int[] GetInputPorts() => Ports();
        public int[] GetOutputPorts() => Ports();
        public bool Audio { get; set; } = false;
        public int Mark { get; set; } = 2400;
        public int Space { get; set; } = 1850;
        public int Baud { get; set; } = 300;
        public int Hysteresis { get; set; } = 30;
        public bool Listening { get => cassListener.Recording; }
        public bool Modulating { get => waveOut != null; }

        public Control Invoker => throw new NotImplementedException();

        public bool CanInvoke => throw new NotImplementedException();

        public TapeController()
        {
            cassListener = new CassAudioListener(Send, IndicateData);
            cassStream = new CassAudioStream(IndicateData);
        }

        public int Get()
        {
            throw new NotImplementedException();
        }

        public int RequestRead(int port)
        {
            lock (buffer)
            {
                bool avail = writePos > readPos;
                if (port == ControlPort)
                    return avail ? 0 : 1;
                else
                    return avail ? buffer[readPos++ & 0xffff] : 0;
            }
        }

        public void RequestWrite(int port, int val)
        {
            lock (this)
            {
                if (port == DataPort)
                {
                    capture?.WriteByte((byte)val);
                    captured++;
                    if (Audio)
                        cassStream.AddByte((byte)val);
                }
                else if (port == ControlPort)
                {
                    // nowt, only used for interrupts on the 88-SIO which is not relevant for cassette operation
                }
            }
        }

        public void StartListening()
        {
            if (!cassListener.Recording)
            {
                IndicateFunction(Color.Green);
                Mon.Log("[CASS] Starting Cassette Audio Input.");
                cassListener.Start(Baud, Mark, Space, Hysteresis);
            }
        }

        public void StopListening()
        {
            if (cassListener.Recording)
            {
                IndicateFunction(Color.Black);
                IndicateData(Color.Black);
                Mon.Log("[CASS] Stopping Cassette Audio Input.");
                cassListener.Stop();
            }
        }

        public void Send(int byt)
        {
            if (Modulating)
            {
                if (waveOut != null)
                    cassStream.AddByte((byte)byt);
            }
            else
            {
                lock (buffer)
                {
                    buffer[writePos++ & 0xffff] = (byte)byt;
                }
            }
        }

        private void IndicateFunction(Color c) => Mon.Invoke(() => FuncIndicator.BackColor = c);

        private void IndicateData(Color c) => Mon.Invoke(() => DataIndicator.BackColor = c);

        public void StartCapture()
        {
            captured = 0;
            if (Audio && !Listening)
            {
                IndicateFunction(Color.OrangeRed);
                Mon.Log("[CASS] Starting Cassette Audio Output.");
                waveOut = new WaveOutEvent();
                cassStream.Reset(Mark, Space, Baud);
                waveOut.Init(cassStream);
                Mon.Run(waveOut.Play);
                capture = null;
            }
            else
                capture = new MemoryStream();
        }

        public byte[] StopCapture()
        {
            if (waveOut != null)
            {
                IndicateFunction(Color.Black);
                IndicateData(Color.Black);
            }
            waveOut?.Stop();
            waveOut?.Dispose();
            waveOut = null;
            lock (this)
            {
                if (capture != null)
                {
                    byte[] b = capture.ToArray();
                    KillCapture();
                    return b;
                }
                return Array.Empty<byte>();
            }
        }

        private void KillCapture()
        {
            MemoryStream temp = capture;
            capture = null;
            temp?.Dispose();
        }

        public void Reset()
        {
            lock (buffer)
            {
                readPos = 0;
                writePos = 0;
            }
            lock (this)
            {
                KillCapture();
            }
        }

    }

    public class CassAudioListener
    {
        private readonly WaveIn sampler = new ();
        private bool recording = false, isMark = false;
        private readonly Action<int> CallBack;
        private readonly Action<Color> Indicator;
        private float volumeAdjust = 1, markFreq, spaceFreq;
        private int bitState, byt, lastSample = 0, samplesPerBit, countSamples = 0, lastLedPriority = 0;
        private Tote sampleTote, lowPassFilter;
        private FixedTote volumeTote;
        private long ledTimeOut = 0;
        private FloatRange freqRange, hystRange;

        public bool Recording { get => recording; }

        public CassAudioListener(Action<int> callBack, Action<Color> indicator = null)
        {
            sampler = new WaveIn
            {
                WaveFormat = new WaveFormat(48000, 8, 1)
            };
            sampler.DataAvailable += Sampler_DataAvailable;
            CallBack = callBack;
            Indicator = indicator;
        }

        public void Start(int baud, int mark1, int space0, float hyst)
        {
            bitState = -1;
            byt = 0;
            recording = true;
            sampler.StartRecording();
            samplesPerBit = 48000 / baud;
            sampleTote = new Tote(samplesPerBit);
            lowPassFilter = new Tote(3);
            volumeTote = new FixedTote(10000);
            markFreq = mark1;
            spaceFreq = space0;
            float waterShed = (markFreq + spaceFreq) / 2f;
            float hysteresis = (hyst / 100f) * (markFreq - waterShed);
            freqRange = new FloatRange(spaceFreq - hysteresis, markFreq + hysteresis);
            hystRange = new FloatRange(spaceFreq + hysteresis, markFreq - hysteresis);
        }

        public void Stop()
        {
            sampler.StopRecording();
            recording = false;
        }

        private void Sampler_DataAvailable(object sender, WaveInEventArgs e)
        {
            for (int i = 0; i < e.BytesRecorded; i++)
                NextSample(e.Buffer[i]);
        }

        private void LatchLED(Color col, int priority, int time)
        {
            long now = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            if (priority > lastLedPriority || now > ledTimeOut)
            {
                Indicator?.Invoke(col);
                lastLedPriority = priority;
                ledTimeOut = now + time;
            }
        }

        private void NextBit(int bit)
        {
            switch (bitState)
            {
                // bit state -1 is waiting for a start bit 0
                case -1:
                    bitState = -bit;
                    break;
                // bit state 0 to 7 occurs right after a start bit, so we need to grab
                // 8 bits of data in total
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                    byt |= bit << bitState++;
                    break;
                // bit state 8 is the stop bit that should be a 1
                case 8:
                    if (bit == 1)
                    {
                        CallBack(byt);
                    }
                    byt = 0;
                    bitState = -1;
                    break;
            }
        }

        public void NextSample(int sample)
        {
            // pass the sample through a small average tote
            // this will act as a filter to clear up noise/hiss etc..
            lowPassFilter.Add(sample);
            sample = (int)lowPassFilter.Mean;
            countSamples++;
            // work out the average volume over some time
            if (volumeTote.Add(Math.Abs(128 - sample)))
            {
                // calculate the peak volume from the average
                float peak = volumeTote.Mean / 0.637f;
                // if the input volume is too loud, turn the LED red to alert the user
                if (peak > 123)
                    LatchLED(Color.Red, 10, 500);
                else // otherwise turn it green if no other audio is currently being processed
                    LatchLED(Color.Green, 0, 100);
                // calculate the adjustment factor we need to make the wave deflection consistent
                volumeAdjust = 128f / peak;
                volumeTote.Reset();
            }
            // adjust the sample to a consistent volume
            sample = (int)(sample * volumeAdjust);
            // get the difference between the current sample and the last
            int dif = Math.Abs(sample - lastSample);
            // add this to the frequency analysis buffer
            sampleTote.Add(dif);
            // work out the average frequency of the last bitload of samples.
            // - 
            // A complete wave should be 48000/freq samples, call this 'comp'
            // (example: for a mark that's (usually) 48000/2400 = 20)
            // In order to complete both wave phases, each sample
            // would need to change by 256 / (comp/2) each time (approx on average) - This is considering a triangle/sawtooth wave not a sine wave, but the difference between the two at this level is negligible
            // (example: for a mark that's 256 / 10 = 25.6)
            // So the average in the freq analysis buffer is going to be
            // Avg = 256 / ((48000/freq)/2)
            // multiply both sides by 1/256
            // 256/Avg = (48000/freq)/2
            // multiply both sides by 2
            // 512/Avg = 48000/freq
            // multiply both sides by 1/48000
            // 48000/(512/Avg) = freq
            // or
            // (48000/512) * Avg = freq
            // or
            // 93.75 * Avg = freq
            float fr = sampleTote.Mean * 93.75f;
            // is the frequency in the ball-park?
            if (freqRange.Contains(fr))
            {
                // set the led color, yellow will be shown when there's just marks
                // but any spaces will cause it to latch to cyan to indicate data
                LatchLED(isMark ? Color.Yellow : Color.Cyan, isMark ? 3 : 6, isMark ? 100 : 250);
                // have we gone past the point where we can call a shift in frequency?
                if (isMark ? hystRange.Lower(fr) : hystRange.Higher(fr))
                {
                    // figure out how many consecutive bits we just receivied
                    int numOfBits = (int)Math.Round((float)countSamples / (float)samplesPerBit);
                    // number of bits should never normally get over 10
                    // (a 0 start, 8 data 0's and a stop 1, = 9 zeros)
                    // (a 0 start, 8 data 1's and a stop 1, = 9 ones)
                    // (a 0 start, 8 data 1's and two stop 1's, = 10 ones)
                    // only times it will be a silly amount is at the end of the leader or when
                    // random audio is being processed
                    if (numOfBits <= 10)
                    {
                        // process the bit(s)
                        for (int i = 0; i < numOfBits; i++)
                            NextBit(isMark ? 1 : 0);
                    }
                    // change the mark/space state
                    isMark = !isMark;
                    countSamples = 0;
                }
            }
            lastSample = sample;
        }
    }

    public static class CassAudio
    {
        public static int Timings(int baud, int mark1, int space0, out double mark1Waves, out double space0Waves)
        {
            // work out the length of a full bit (should always be an integer for standard baud rates)
            int fullBitLength = 48000 / baud;

            // work out the length of a single mark and space sawtooth wave
            double mark1Length = 48000.0 / (double)mark1;
            double space0Length = 48000.0 / (double)space0;

            // work out the number of full waves mark and space will have in a full bit
            // The rounding may change the resulting audio frequencies of mark and space
            // but if the required mark and space freqencies
            // are close to integer divisors of the sample rate (48000) then the
            // shift in frequencies should be negligible. For example, the standard space
            // frequency of 1850Hz is extremely close to 26 when divided into 48000. The 
            // rounding will thus result in an audio frequency of around 1846Hz which should
            // be fine.
            mark1Waves = Math.Round((double)fullBitLength / mark1Length);
            space0Waves = Math.Round((double)fullBitLength / space0Length);

            // if the tolerances are too tight, the wave count will be the same for mark and space
            // if that happens all we can do is subtract 1 from the number of space waves, as space
            // is supposed to be a lower frequency anyway. This will dramatically shift the
            // frequency of space out of spec, but what else can you do? We can't have jerky waveforms can we? Nope!
            if (space0Waves == mark1Waves)
            {
                Mon.Wrn("[CASS] The mark/space frequencies are not compatible with the baud rate. This combination will almost certainly not work.");
                space0Waves--;
            }

            // check if we got a zero/negative result for a wave count, if that happens, the
            // audio parameters attempted are not possible.
            if (space0Waves <= 0 || mark1Waves <= 0)
            {
                Mon.Wrn("[CASS] The supplied audio parameters are not a possible combination. Parameters have been set to defaults.");
                space0Waves = 3;
                mark1Waves = 4;
            }

            return fullBitLength;
        }
    }

    public class CassAudioStream : WaveStream
    {
        private long pos = 0;
        private byte[] wavSpace0, wavMark1;
        private readonly List<byte> data = new ();
        private readonly WaveFormat format = new (48000, 8, 1);
        private byte[] carryBuffer;
        private readonly Action<Color> Indicator;

        public CassAudioStream(Action<Color> indicator = null) => Indicator = indicator;

        public override WaveFormat WaveFormat => format;

        public override long Length => long.MaxValue;

        public override long Position { get => pos; set => pos = value; }

        public void Reset(int mark1, int space0, int baud)
        {
            data.Clear();
            carryBuffer = null;

            // work out various timing data, see earlier
            int fullBitLength = CassAudio.Timings(baud, mark1, space0, out double mark1Waves, out double space0Waves);

            // create the waveform data arrays for mark and space
            wavMark1 = new byte[fullBitLength];
            wavSpace0 = new byte[fullBitLength];

            // populate arrays with waveform data
            double TAU = Math.PI * 2.0;
            for (int i = 0; i < fullBitLength; i++)
            {
                double angM = ((double)i / (double)fullBitLength) * TAU * mark1Waves;
                double angS = ((double)i / (double)fullBitLength) * TAU * space0Waves;
                // don't max out the wave, can lead to distortion
                wavMark1[i] = (byte)((Math.Sin(angM) + 1f) * 90.0);
                wavSpace0[i] = (byte)((Math.Sin(angS) + 1f) * 90.0);
            }
        }

        public void AddByte(byte b) => data.Add(b);

        private int Bit(byte[] buffer, int pos, bool bit)
        {
            byte[] wav = bit ? wavMark1 : wavSpace0;
            Array.Copy(wav, 0, buffer, pos, wav.Length);
            return wav.Length;
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            byte[] wav = new byte[count * 3];
            int c;
            // copy whatever modulation data that was left over from the last
            // Read call to the start of the new audio buffer. 
            if (carryBuffer != null)
            {
                Array.Copy(carryBuffer, 0, wav, 0, carryBuffer.Length);
                c = carryBuffer.Length;
            }
            else
                c = 0;
            while (c < count)
            {
                // if no data is available to modulate
                // just send leader mark bits
                if (data.Count == 0)
                {
                    Indicator?.Invoke(Color.Yellow);
                    c += Bit(wav, c, true); // padding bit 1 (mark)
                }
                else
                {
                    Indicator?.Invoke(Color.Cyan);
                    // retrieve the next byte to modulate
                    int b = data.ElementAt(0);
                    data.RemoveAt(0);
                    c += Bit(wav, c, false); // start bit 0 (space)
                    for (int i = 0; i <= 7; i++)
                    {
                        if (((b >> i) & 1) == 0)
                        {
                            c += Bit(wav, c, false); // data bit is 0 (space)
                        }
                        else
                        {
                            c += Bit(wav, c, true); // data bit is 1 (mark)
                        }
                    }
                    c += Bit(wav, c, true); // stop bit 1 (mark)
                }
            }
            // copy the modulated data from the audio buffer into the read buffer
            Array.Copy(wav, 0, buffer, offset, count);
            // we're hardly ever going to be able to fit the modulated data exactly into the read
            // buffer that is supplied by the call from NAudio, so we take whatever is left over
            // and store it into another buffer we can use to carry that data into the next Read call.
            if (c > count)
            {
                carryBuffer = new byte[c - count];
                Array.Copy(wav, count, carryBuffer, 0, carryBuffer.Length);
            }
            else
                carryBuffer = null;
            pos += count;
            return count;
        }
    }

}