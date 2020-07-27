using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Stock
    {
    }

    class Stock1
    {
        public void Sell()
        {
            Console.WriteLine("Sell 1");
        }

        public void Buy()
        {
            Console.WriteLine("Buy 1");
        }
    }

    class NationalDebt1
    {
        public void Sell()
        {
            Console.WriteLine("Sell 3");
        }

        public void Buy()
        {
            Console.WriteLine("Buy 3");
        }
    }

    class Realty1
    {
        public void Sell()
        {
            Console.WriteLine("Sell 3");
        }

        public void Buy()
        {
            Console.WriteLine("Buy 3");
        }
    }

    class Fund
    {
        private Stock1 d1;
        private NationalDebt1 n1; 
        private Realty1 r1; 

        public Fund()
        {
            d1 = new Stock1();
            n1 = new NationalDebt1();
            r1 = new Realty1();
        }

        public void BuyFund()
        {
            d1.Buy();
            n1.Buy();
            r1.Buy();
        }

        public void SellFund()
        {
            d1.Sell();
            n1.Sell();
            r1.Sell();
        }
    }

    
}
