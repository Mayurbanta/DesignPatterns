using ObserverPattern.Go4Observer;
using ObserverPattern.TreadMillExample;
using System;

namespace ObserverPattern
{
    class Program
    {

        #region "Observer Pattern through Go4------------------------------------------"   

        static void Main(string[] args)
        {
            Console.WriteLine("Observer Pattern through Go4");

            IInvestor User1 = new Investor("User1");
            IInvestor User2 = new Investor("User2");
            IBM iBM = new IBM(10, "IBM");
            iBM.Register(User1);
            iBM.Register(User2);
            iBM.Price = 20;

        }

      

        #endregion


        #region "Obeserver through Events---------------------------------------------"
        static void Main1(string[] args)
        {
            TreadMillController treadMillController = new TreadMillController(1);

            treadMillController.IncreaseSpeed();
            treadMillController.IncreaseSpeed();
            treadMillController.IncreaseSpeed();

        }

        #endregion
    }





}



