
using System;

namespace Facade
{
    class FacadeDemo
    {
        static void Main(string[] args)
        {
           // NewMethod();
           Fund f = new Fund();
           f.BuyFund();
           f.SellFund();
           Console.Read();
        }

        private static void NewMethod()
        {
            Stock1 d1 = new Stock1();
            d1.Buy();
            d1.Sell();
            Console.Read();
        }
    }
}
