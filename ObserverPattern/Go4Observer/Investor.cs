using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Go4Observer
{
    /// <summary>
    /// Observer
    /// </summary>
    public class Investor : IInvestor
    {

        public Investor(string name)
        {
            _name = name;
        }

        private string _name;

        public void Update(Stock stock)
        {
            Console.WriteLine($"stock:{ stock.Symbol }, price changed to {stock.Price }. Notificaition for {_name}");
        }


        private Stock _stock;

        public Stock Stock
        {
            get { return _stock; }
            set { _stock = value; }
        }

    }
}
