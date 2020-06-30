using System;
using Strategy.SimpleFactoryImplementation;

namespace Strategy
{
    class StrategyDemo
    {
        private static void Main(string[] args)
        {
            //NewMethod();
            //NewMethod1();
            //NewMethod2();
        }

        //private static void NewMethod2()
        //{
        //    const double txtPrice = 600;
        //    const int txtNum = 1;

        //    var cc = new CashContext("Normal charge");
        //    var totalPrice = cc.GetResult(txtPrice) * txtNum;
        //    Console.WriteLine("TotalPrice1 " + totalPrice);

        //    cc = new CashContext("300 minus 100");
        //    totalPrice = cc.GetResult(txtPrice) * txtNum;
        //    Console.WriteLine("TotalPrice2 " + totalPrice);

        //    cc = new CashContext("20% off");
        //    totalPrice = cc.GetResult(txtPrice) * txtNum;
        //    Console.WriteLine("TotalPrice3 " + totalPrice);

        //    Console.Read();
        //}

        //private static void NewMethod1()
        //{
        //    var context = new Context(new ConcreteStrategyA());
        //    context.ContextInterface();

        //    context = new Context(new ConcreteStrategyB());
        //    context.ContextInterface();

        //    context = new Context(new ConcreteStrategyC());
        //    context.ContextInterface();

        //    Console.Read();
        //}

        private static void NewMethod()
        {
            //input 3 parameter
            var cs = CashFactory.CreateCashAccept("300 minus 100");
            const double txtPrice = 600;
            const int txtNum = 1;

            var totalPrice = cs.GetResult(txtPrice) * txtNum;
            Console.WriteLine("TotalPrice " + totalPrice);
            Console.ReadLine();
        }
    }

}