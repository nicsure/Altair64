namespace Nicsure.Altair8800.Hardware.Interfaces
{
    // Code by nicsure (C)2022
    // https://www.youtube.com/nicsure
    public interface IInputDevice
    {
        int[] GetInputPorts();
        String DeviceName { get; }
        int RequestRead(int port);
    }

    public interface IOutputDevice
    {
        int[] GetOutputPorts();
        String DeviceName { get; }
        void RequestWrite(int port, int val);
    }

    public interface IResettable
    {
        void Reset();
    }

    public interface ISendToAble
    {
        void Send(int byt);
    }

    public interface ICapturable
    {
        int Captured { get; }
        void StartCapture();
        byte[] StopCapture();
    }

    public interface IShutDownAble
    {
        void ShutDown();
    }
}