using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nicsure.CustomControls
{
    // Code by nicsure (C)2022
    // https://www.youtube.com/nicsure

    public interface IPWM
    {
        void UpdatePWM();
        void UpdatePWM(int count);
        void Display(int totalCount);
    }
}
