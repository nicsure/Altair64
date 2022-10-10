using Altair64.Project;
using Nicsure.CustomControls;
using Nicsure.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nicsure.Intel8080
{
    // Code by nicsure (C)2022
    // https://www.youtube.com/nicsure

    public interface IStatusReadout
    {
        IPWM[] AddressLEDs { get; }
        IPWM[] DataLEDs { get; }
        IPWM[] StatusLEDs { get; }
        Altair64.Project.Monitor MonitorWindow { get; }
        NumericUpDown BC { get; }
        NumericUpDown DE { get; }
        NumericUpDown HL { get; }
        NumericUpDown A { get; }
        NumericUpDown PC { get; }
        NumericUpDown SP { get; }
        NumericUpDown IV { get; }
        CheckBox CF { get; }
        CheckBox PF { get; }
        CheckBox HF { get; }
        CheckBox ZF { get; }
        CheckBox SF { get; }
        CheckBox HLT { get; }
        CheckBox EI { get; }
        CheckBox IRQ { get; }

        public void UpdateAddress(int addr)
        {
            int b = 1;
            foreach(IPWM pwm in AddressLEDs)
            {
                if ((addr & b) != 0) pwm.UpdatePWM();
                b <<= 1;
            }
        }

        public void UpdateData(int data)
        {
            int b = 1;
            foreach (IPWM pwm in DataLEDs)
            {
                if ((data & b) != 0) pwm.UpdatePWM();
                b <<= 1;
            }
        }

        public void UpdateStatus(StatusLED led)
        {
            StatusLEDs[(int)led].UpdatePWM();
        }

        public void Display(int totalCount)
        {
            Mon.Invoke(() =>
            {
                foreach (IPWM pwm in AddressLEDs)
                    pwm.Display(totalCount);
                foreach (IPWM pwm in DataLEDs)
                    pwm.Display(totalCount);
                foreach (IPWM pwm in StatusLEDs)
                    pwm.Display(totalCount);
            });
        }
    }

    public enum StatusLED
    {
        WAIT, IE, RM, IN, M1, OUT, HLT, STK, WO, INT
    }
}
