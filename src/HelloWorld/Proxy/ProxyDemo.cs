using System;

namespace Proxy
{
    class ProxyDemo
    {
        static void Main(string[] args)
        {
            // NewMethod();
            //NewMethod1();
            Girl girl = new Girl {Name = "leng"};
            Proxy proxy = new Proxy(girl);
            proxy.GiveDolls();
            proxy.GiveFlowers();
            proxy.GiveChocolate();
            Console.Read();
        }

        private static void NewMethod1()
        {
            Girl leng = new Girl {Name = "kat"};

            Proxy yi = new Proxy(leng);
            yi.GiveChocolate();
            yi.GiveDolls();
            yi.GiveFlowers();

            Console.Read();
        }

        private static void NewMethod()
        {
            Girl leng = new Girl {Name = "kat"};

            Pursuit yi = new Pursuit(leng);
            yi.GiveChocolate();
            yi.GiveDolls();
            yi.GiveFlowers();

            Console.Read();
        }
    }
}
