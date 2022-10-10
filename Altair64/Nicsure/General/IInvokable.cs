using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nicsure.General
{
    // Code by nicsure (C)2022
    // https://www.youtube.com/nicsure

    public interface IInvokable
    {
        public Control Invoker { get; }

        public bool CanInvoke { get; }

        public bool InvokeRequired => Invoker.InvokeRequired;

        public void DoInvoke(Action action)
        {
            if(CanInvoke) Invoker.Invoke(action);
        }
    }
}
