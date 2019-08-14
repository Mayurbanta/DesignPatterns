using System;
using System.Collections.Generic;
using System.Text;
using ObserverPattern.TreadMillExample;

namespace ObserverPattern.TreadMillExample
{
    public class TreadMillController
    {
        private readonly TreadMill _TreadMill;
        private int _IntialSpeed;
        public TreadMillController(int IntialSpeed)
        {
            _TreadMill = new TreadMill();
            WireupEvents();
        }


        private void WireupEvents()
        {
            _TreadMill.SpeedChanged += _TreadMill_SpeedChanged;
        }

        private void _TreadMill_SpeedChanged(object sender, TreadMillArgs e)
        {
            Console.WriteLine($"Speed Changed to {e.Speed.ToString()}");
        }


        public void IncreaseSpeed()
        {
            _TreadMill.Speed = _IntialSpeed ++;
        }
    }
}

