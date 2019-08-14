using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Go4Observer
{
    public interface IInvestor
    {
        void Update(Stock stock);
    }
}
