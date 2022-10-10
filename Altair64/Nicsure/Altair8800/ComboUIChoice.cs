using Nicsure.Altair8800.Hardware.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nicsure.Altair8800
{
    public class ComboUIChoice
    {
        public ISendToAble UserInterface { get => (ISendToAble)device; }
        public ICapturable Capturable { get => (ICapturable)device; }
        private readonly String name;
        private readonly object device;
        public ComboUIChoice(String name, object chDevice)
        {
            this.name = name;
            device = chDevice;
        }
        public override String ToString() => name;
    }
}
