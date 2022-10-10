using Nicsure.Altair8800.Hardware.Interfaces;
using Nicsure.General;
using System.IO.Compression;

namespace Nicsure.Altair8800.Hardware
{
    public class DiskController : IInputDevice, IOutputDevice, IResettable
    {
        // Code by nicsure (C)2022
        // https://www.youtube.com/nicsure
        public String DeviceName { get; } = "Altair 88-DCDD";

        private readonly static int MAX_TRACK = 76;
        private static readonly byte[] blankSector = new byte[137];
        private static bool Bit(int v, int b) => ((v >> b) & 1) != 0;

        private int sectorSeekPosition = 0;
        private int driveSelected = -1;
        private int currentSector = -1;
        private int headPosition = 0;
        private bool writeMode = false, intEnable = false, strobeSectorReady = true;
        private readonly Stream[] disk = { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null };
        private int GetDiskOffset(int secSeek) => (currentSector * 137) + (headPosition * 4384) + secSeek;
        private readonly String[] diskNames = new string[16];
        private readonly System.Reflection.Assembly objAssembly;

        public Control[] DriveLEDs { get; set; } = { null, null, null, null };

        public String[] DiskNames => diskNames;
        public int DriveSelectRegister { get; }
        public int DriveStatusRegister { get; }
        public int CommandRegister { get; }
        public int SectorPositionRegister { get; }
        public int DataReadRegister { get; }
        public int DataWriteRegister { get; }

        public override string ToString() => DeviceName;

        public int[] GetInputPorts() => new int[] { DriveStatusRegister, SectorPositionRegister, DataReadRegister };
        public int[] GetOutputPorts() => new int[] { DriveSelectRegister, CommandRegister, DataWriteRegister };

        public DiskController(int firstPort)
        {
            objAssembly = System.Reflection.Assembly.GetExecutingAssembly();
            DriveSelectRegister = firstPort;
            DriveStatusRegister = firstPort;
            CommandRegister = firstPort + 1;
            SectorPositionRegister = firstPort + 1;
            DataReadRegister = firstPort + 2;
            DataWriteRegister = firstPort + 2;
        }

        private void SetLED(int drive, object color = null)
        {
            if (drive < -1 || drive > 3) return;
            Color col = (Color)(color ?? Color.Black);
            if (drive == -1)
            {
                foreach (Control c in DriveLEDs)
                    if (c != null) c.BackColor = col;
            }
            else
            {
                if (DriveLEDs[drive] != null)
                    DriveLEDs[drive].BackColor = col;
            }
        }

        public bool ConvertToPhysicalDisk(int diskNo, String file)
        {
            if (disk[diskNo] != null && disk[diskNo] is MemoryStream memStream)
            {
                byte[] data = memStream.ToArray();
                if (Mon.WriteAllBytes(file, data))
                {
                    Stream stream = Mon.Open(file, FileMode.Open, FileAccess.ReadWrite);
                    if (stream != null)
                    {
                        disk[diskNo]?.Dispose();
                        disk[diskNo] = stream;
                        diskNames[diskNo] = Path.GetFileNameWithoutExtension(file);
                        return true;
                    }
                }
            }
            return false;
        }

        public Stream MakeBlankDisk()
        {
            MemoryStream blank;
            using (Stream compressedData = objAssembly.GetManifestResourceStream("Altair64.Resources.blank.gz"))
            using (Stream gz = new GZipStream(compressedData, CompressionMode.Decompress))
                gz.CopyTo(blank = new MemoryStream());
            return blank;
        }

        public bool InsertDiskImage(int diskNo, String file, bool ramDisk = false)
        {
            disk[diskNo]?.Dispose(); // destroy any disk that was in there already
            disk[diskNo] = null; // null out the old disk stream
            if (driveSelected == diskNo) // if the disk we're inserting is into the currently selected drive
                Reset(); // reset the controller 
            if (file != null) // test we're actually inserting an image file, if not it'll act as removing the currently inserted disk
            {
                if (file == "*BLANK") // inserting a blank disk ?
                {
                    ramDisk = true; // a new blank disk is always a RAM Mirror
                    disk[diskNo] = MakeBlankDisk(); // Get a stream for the new blank disk
                }
                else // otherwise we're inserting a real disk image
                {
                    disk[diskNo] = ramDisk ? // are we mounting the image as a RAM disk mirror
                        disk[diskNo] = new MemoryStream(Mon.ReadAllBytes(file)) : // create a memory stream from the disk image
                        Mon.Open(file, FileMode.Open, FileAccess.ReadWrite); // just use the file stream of the disk image
                }
                file = (ramDisk ? "[RAM Mirror] " : "") + Path.GetFileNameWithoutExtension(file); // save the disk name for the UI
            }
            diskNames[diskNo] = disk[diskNo] == null ? null : file; // update the disk name
            return disk[diskNo] != null; // return success/failure
        }

        public int RequestRead(int port)
        {
            switch (port)
            {
                case int n when (n == SectorPositionRegister): // PORT 9 read sector position
                    sectorSeekPosition = 0; // set the seek position to the start of the sector
                    writeMode = false; // disable write mode
                    if (currentSector >= 0) // if the head is lowered
                    {
                        SetLED(driveSelected, Color.FromArgb(166, 30, 30));
                        strobeSectorReady = !strobeSectorReady; // toggle the strobe flag, used to alternate between sector ready and sector not ready in order to mimic real hardware
                        if (strobeSectorReady) // set sector ready this time?
                        {
                            currentSector = (currentSector + 1) & 31; // add one to the sector position
                            return currentSector << 1; // return sector number shifted left 1 bit as the sector number needs to be in bits 1-6 and bit 0 needs to be 0 (true) to indicate the sector is ready
                        }
                        else if (intEnable) // sector will be ready next time, so if ints are enabled, raise one now.
                            Mon.Msg(1, 7);
                    }
                    return 1; // return 1 (false) in bit 0 to indicate sector is not ready either due to the head not being lowered or we're on a "sector not ready" strobe cycle

                case int n when (n == DriveStatusRegister): // PORT 8 read drive status
                    int ds =
                        (writeMode && currentSector > -1 ? 0 : 1) | // Bit 0 : send 0 (true) when in write mode to indicate okay to write data
                        (writeMode ? 2 : 0) | // Bit 1 : send 1 (false) when in write mode otherwise 0 (true) to indicate okay to move head
                        (currentSector > -1 ? 0 : 4) | // Bit 2 : send 0 (true) if head is lowered, we're always ready to read/write cos this is an emulator
                        (intEnable ? 0 : 32) | // send 0 (true) if interrupt is enabled
                        (headPosition == 0 ? 0 : 64) | // send 0 (true) if head is at the track 0
                        (writeMode || currentSector == -1 ? 128 : 0); // send 1 (false) if in write mode or head not loaded otherwise 0 (true) to indicate okay to read
                    return ds;

                case int n when (n == DataReadRegister): // PORT 10 request to read from sector
                    if (currentSector > -1) // if the head is lowered
                    {
                        if (!writeMode) // and we're not in write mode
                        {
                            SetLED(driveSelected, Color.FromArgb(200, 40, 40));
                            int pos = GetDiskOffset(sectorSeekPosition++); // work out offset into disk data and increase the seek position
                            if (sectorSeekPosition < 138) // check we're not beyond the end of the sector
                            {
                                disk[driveSelected].Seek(pos, SeekOrigin.Begin); // grab the byte at that disk position
                                return disk[driveSelected].ReadByte(); // return it
                            }
                        }
                    }
                    break;
            }
            return 0;
        }

        public void RequestWrite(int port, int val)
        {
            switch (port)
            {
                case int n when (n == DriveSelectRegister): // PORT 8 select drive
                    SetLED(-1);
                    Reset(); // Reset the controller
                    if (val <= 15) // bit 7 (disable disk control) is not set so we can attempt to select the drive
                    {
                        SetLED(val, Color.FromArgb(133, 20, 20));
                        //if (disk[val] != null) // if there's a disk in the drive
                        driveSelected = val; // select the drive
                    }
                    break;

                case int n when (n == CommandRegister): // PORT 9 send command to controller
                    if (Bit(val, 0)) // bit 0 = step in, move to next higher track
                    {
                        if (driveSelected >= 0) // make sure there is a drive selected
                            if (headPosition < MAX_TRACK) // make sure we're not at the end track
                                if (!writeMode) // don't move the head while writing
                                    headPosition++; // increase track by 1
                    }
                    if (Bit(val, 1)) // bit 1 = step out, move to next lower track
                    {
                        if (driveSelected >= 0) // make sure there is a drive selected
                            if (headPosition > 0) // make sure we're not at the first track
                                if (!writeMode) // don't move the head during writing
                                    headPosition--; // decrease track by 1
                    }
                    if (Bit(val, 2)) // bit 2 = drop head
                    {
                        if (driveSelected == -1) // for some reason, CP/M tries to drop the head after disabling disk control sometimes, if this happens, automatically enable disk 0
                            RequestWrite(DriveSelectRegister, 0); // select disk 0
                        if (driveSelected >= 0 && disk[driveSelected] != null) // only drop the head if a drive is selected and there's a disk in the drive
                        {
                            SetLED(driveSelected, Color.FromArgb(133, 20, 20));
                            currentSector = 31; // set to sector 31 so the next sector position read will start at sector 0
                        }
                    }
                    if (Bit(val, 3)) // bit 3 = lift head
                    {
                        SetLED(driveSelected, Color.FromArgb(133, 10, 10));
                        currentSector = -1; // set current sector to -1 to indicate a lifted head
                    }
                    if (Bit(val, 4)) // bit 4 = interrupt enable
                    {
                        intEnable = true;
                    }
                    if (Bit(val, 5)) // bit 5 = interrupt disable
                    {
                        intEnable = false;
                    }
                    // if (Bit(val, 6)) { } // bit 6 = head current (irrelevant)
                    if (Bit(val, 7)) // bit 7 = initiate write sequence 
                    {
                        if (currentSector > -1) // is the head is lowered
                        {
                            if (!writeMode) // and we're not already in write mode
                            {
                                SetLED(driveSelected, Color.FromArgb(250, 40, 40));
                                sectorSeekPosition = 0; // reset seek position
                                int pos = GetDiskOffset(0); // get start of sector
                                disk[driveSelected].Seek(pos, SeekOrigin.Begin); // set seek position in disk data stream
                                disk[driveSelected].Write(blankSector, 0, 137); // zero out the sector
                                writeMode = true; // enable write mode
                            }
                        }
                    }
                    break;

                case int n when (n == DataWriteRegister): // PORT 10 request to write sector byte
                    if (currentSector > -1) // if the head is lowered
                    {
                        if (writeMode) // and we're in write mode
                        {
                            int pos = GetDiskOffset(sectorSeekPosition); // work out offset into disk data
                            if (sectorSeekPosition <= 136) // check we're not beyond the end of the sector
                            {
                                disk[driveSelected].Seek(pos, SeekOrigin.Begin); // seek to disk offset
                                disk[driveSelected].WriteByte((byte)val); // save the byte to disk
                            }
                            if (sectorSeekPosition >= 137) // a sector has 137 bytes, but a write will send 138, the last 138th byte (which should be 0) signals the end of the write cycle
                            {
                                writeMode = false; // end of sector, disable write mode
                                sectorSeekPosition = -1; // reset sector seek
                            }
                            sectorSeekPosition++; // increase sector seek
                        }
                    }
                    break;
            }
        }

        public void Reset()
        {
            driveSelected = -1;
            intEnable = false; // disable interrupts
            headPosition = 0; // reset head position
            currentSector = -1; // lift the head
            writeMode = false; // disable write mode
        }
    }
}
