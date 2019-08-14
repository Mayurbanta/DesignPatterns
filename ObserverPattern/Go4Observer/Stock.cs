using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Go4Observer
{
    /// <summary>
    /// Subject
    /// </summary>
    public abstract class Stock
    {
        private List<IInvestor> _investors = new List<IInvestor>();

        public Stock(int price, string symbol)
        {
            _price = price;
            _symbol = symbol;
        }

        private string _symbol;

        public string Symbol
        {
            get { return _symbol; }
            set { _symbol = value; }
        }


        private int _price;

        public int Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
                Notify();
            }
        }

        private void Notify()
        {
            foreach (IInvestor investor in _investors)
            {
                investor.Update(this);
            }
        }


        //Register
        public void Register(IInvestor investor)
        {
            _investors.Add(investor);
        }

        //Deregister
        public void Deregister(IInvestor investor)
        {
            _investors.Remove(investor);
        }


    }
}
