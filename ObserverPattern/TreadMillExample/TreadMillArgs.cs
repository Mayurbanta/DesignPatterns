using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.TreadMillExample
{
    public class TreadMillArgs : EventArgs
    {
        public TreadMillArgs(int speed)
        {
            Speed = speed;
        }

        public int Speed { get; private set; }
    }
}
