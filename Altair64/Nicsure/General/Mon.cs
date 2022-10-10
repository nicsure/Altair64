using Nicsure.Intel8080;
using System.Net.Sockets;

namespace Nicsure.General
{
    // Code by nicsure (C)2022
    // https://www.youtube.com/nicsure

    /// <summary>
    ///  General purpose static methods and extensions that can be used by anything.
    /// </summary>
    /// 
    public static class Mon
    {
        private readonly static Dictionary<Task, CancellationTokenSource> tasks
            = new ();
        private static Task watchDogTask;

        public static Action<String> LogReceiever { get; set; } = null;
        public static Action<int, int> MsgReceiever { get; set; } = null;
        public static int LogLevel { get; set; } = 1;
        public static Action WatchDogTick { get; set; } = null;
        public static int WatchDogTickTime { get; set; } = 1000;
        public static IInvokable Invoker { get; set; }


        public static void Wrn(String msg) => Wrn(msg, 0);
        public static void Wrn(String msg, int level) => Log("-Warning- " + msg, level);

        public static void Err(String msg) => Err(msg, 0);
        public static void Err(String msg, int level) => Run(() => Log("*ERROR* " + msg, level));

        public static void Log(String msg) => Log(msg, 0);
        public static void Log(String msg, int level)
        {
            if (level <= LogLevel)
                LogReceiever?.Invoke(msg);
        }

        public static void Msg(int i1, int i2) => MsgReceiever?.Invoke(i1, i2);

        public static void Invoke(Action mi)
        {
            if (Invoker.CanInvoke)
            {
                if (Invoker.InvokeRequired)
                    Invoker.DoInvoke(mi);
                else
                    mi.Invoke();
            }
        }

        public static byte[] ReadAllBytes(String file)
        {
            try
            {
                return File.ReadAllBytes(file);
            }
            catch (Exception) { }
            Err("Unable to read file: " + file);
            return Array.Empty<byte>();
        }

        public static String ReadAllText(String file)
        {
            try
            {
                return File.ReadAllText(file);
            }
            catch (Exception) { }
            Err("Unable to read file: " + file);
            return String.Empty;
        }

        public static FileStream Open(String file, FileMode mode, FileAccess access)
        {
            try
            {
                return File.Open(file, mode, access);
            }
            catch (Exception) { }
            Err("Unable to open file: " + file);
            return null;
        }

        public static bool WriteAllBytes(String file, byte[] b)
        {
            try
            {
                File.WriteAllBytes(file, b);
            }
            catch (Exception)
            {
                Err("Unable to write to file: " + file);
                return false;
            }
            return true;
        }

        public static int Largest(this int[] array, int minimum)
        {
            foreach (int i in array)
                if (i > minimum) minimum = i;
            return minimum;
        }

        public static int Least(this int[] array, int maximum)
        {
            foreach (int i in array)
                if (i < maximum) maximum = i;
            return maximum;
        }

        public static String X2(this int i) => i.ToString("X2");

        public static String X2(this byte b) => b.ToString("X2");

        public static String X4(this byte[] b, int s) => b[(s + 1) & 0xffff].X2() + b[s & 0xffff].X2();

        public static String X4(this int i) => i.ToString("X4");

        public static int RRR3(this int val) => (val >> 3) & 7;

        public static int RRR0(this int val) => val & 7;

        public static int PP4(this int val) => (val >> 4) & 3;

        public static bool BIT0(this int val) => (val & 1) != 0;
        public static bool BIT1(this int val) => (val & 2) != 0;
        public static bool BIT2(this int val) => (val & 4) != 0;
        public static bool BIT3(this int val) => (val & 8) != 0;
        public static bool BIT4(this int val) => (val & 16) != 0;
        public static bool BIT5(this int val) => (val & 32) != 0;
        public static bool BIT6(this int val) => (val & 64) != 0;
        public static bool BIT7(this int val) => (val & 128) != 0;

        public static int BITi0(this int val) => val & 1;
        public static int BITi1(this int val) => (val & 2) >> 1;
        public static int BITi2(this int val) => (val & 4) >> 2;
        public static int BITi3(this int val) => (val & 8) >> 3;
        public static int BITi4(this int val) => (val & 16) >> 4;
        public static int BITi5(this int val) => (val & 32) >> 5;
        public static int BITi6(this int val) => (val & 64) >> 6;
        public static int BITi7(this int val) => (val & 128) >> 7;

        public static char Ascii(int i) => Convert.ToChar(i);

        public static String TruncStringBy(String s, int by) => s.Length > by ? s[..^by] : String.Empty;

        public static void KillListener(TcpListener toKill)
        {
            TcpListener listener = toKill;
            try { listener?.Stop(); } catch { }
            try { listener?.Server?.Shutdown(SocketShutdown.Both); } catch { }
            try { listener?.Server?.Close(); } catch { }
            try { listener?.Server?.Dispose(); } catch { }
        }

        public static int Pow(int bas, int exp)
        {
            int r = 1;
            while (exp-- > 0) r *= bas;
            return r;
        }

        public static float Average(this int[] array)
        {
            float r = 0;
            foreach (int i in array) r += i;
            return r / array.Length;
        }

        public static Task Run(Action action, bool canCancel = false) => Start(Create(action, canCancel));

        public static Task Create(Action action, bool canCancel = true)
        {
            if (action == null) return null;
            CancellationTokenSource cancelSource = canCancel ? new CancellationTokenSource() : null;
            return RegisterTask(
                canCancel ? new Task(action, cancelSource.Token) : new Task(action),
                cancelSource
            );
        }

        public static Task Start(Task task)
        {
            task?.Start();
            return task;
        }

        public static Task RegisterTask(Task task, CancellationTokenSource cancelSource = null)
        {
            lock (tasks)
            {
                tasks[task] = cancelSource;
            }
            return task;
        }

        public static void Cancel(Task task)
        {
            lock (tasks)
            {
                if (tasks.ContainsKey(task))
                    tasks[task]?.Cancel();
            }
        }

        public static CancellationTokenSource CancelSource(Task task)
        {
            lock (tasks)
            {
                return tasks.ContainsKey(task) ? tasks[task] : null;
            }
        }

        private static void WatchDogWorker()
        {
            List<Task> remove = new ();
            while (!CancelSource(watchDogTask).IsCancellationRequested)
            {
                lock (tasks)
                {
                    foreach (Task task in tasks.Keys)
                    {
                        if (task.IsCompleted)
                        {
                            task.Dispose();
                            tasks[task]?.Dispose();
                            remove.Add(task);
                        }
                    }
                    foreach (Task task in remove)
                        tasks.Remove(task);
                    remove.Clear();
                }
                Run(WatchDogTick);
                watchDogTask.Wait(WatchDogTickTime);
            }
        }

        public static void WatchDog(bool shutdown)
        {
            if (!shutdown)
            {
                watchDogTask = Create(WatchDogWorker, true);
                Start(watchDogTask);
            }
            else
            {
                Cancel(watchDogTask);
                watchDogTask?.Wait(WatchDogTickTime + 100);
            }
        }
    }

    public class FixedTote
    {
        private int total, size, cnt;
        public FixedTote(int size) => Reset(size);
        public float Mean => (float)total / (float)size;
        public int Size => size;
        public int Total => total;
        public bool Add(int value)
        {
            total += value;
            return ++cnt >= size;
        }
        public void Reset() => Reset(Size);
        public void Reset(int size)
        {
            this.size = size;
            total = 0;
            cnt = 0;
        }
    }


    public class Tote
    {
        private int[] buffer;
        private int total, rotor;
        public float Mean => (float)total / (float)buffer.Length;
        public int Size => buffer.Length;
        public int Total => total;
        public Tote(int size) => Reset(size);
        public void Add(int value)
        {
            total -= buffer[rotor] - value;
            buffer[rotor] = value;
            rotor = (rotor + 1) % Size;
        }
        public void Reset() => Reset(Size);
        public void Reset(int size)
        {
            buffer = new int[size];
            total = 0;
            rotor = 0;
        }
    }

    public class FloatRange
    {
        private readonly float high, low;
        public FloatRange(float value1, float value2)
        {
            bool h = value1 > value2;
            high = h ? value1 : value2;
            low = h ? value2 : value1;
        }
        public float High => high;
        public float Low => low;
        public bool Contains(float f) => f <= high && f >= low;
        public bool Higher(float f) => f > high;
        public bool Lower(float f) => f < low;
    }


}
