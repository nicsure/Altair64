using Nicsure.Altair8800.Hardware.Interfaces;

namespace Nicsure.Altair8800.Hardware
{
    // Code by nicsure (C)2022
    // https://www.youtube.com/nicsure

    public class SIOController : SerialController, ISendToAble, ICapturable
    {
        private bool capture = false;
        public SIOController() : base(SerialCardType.SIO, 0, 1) { }

        public int Captured => throw new NotImplementedException();

        public override void RequestWrite(int port, int val)
        {
            if (port == ControlPort || capture)
                base.RequestWrite(port, val);
        }

        public void StartCapture()
        {
            if (!capture)
                capture = true;
        }

        public byte[] StopCapture()
        {
            if (capture)
            {
                capture = false;
                return null;
            }
            return GetAll();
        }
    }
}
