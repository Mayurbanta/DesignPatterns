using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.TreadMillExample
{
    public class TreadMill
    {
        private int _speed;

        public event EventHandler<TreadMillArgs> SpeedChanged;

        public int Speed
        {
            get
            {
                return _speed;
            }
            set
            {
                _speed = value;

                TreadMillArgs treadMillArgs = new TreadMillArgs(_speed);
                SpeedChanged?.Invoke(this, treadMillArgs);
            }
        }


    }
}
