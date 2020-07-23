using System;

namespace Adapter
{
    class AdapterDemo
    {
        static void Main(string[] args)
        {
            //NewMethod();
            Player a = new Forwards("A");
            a.Attack();
            Player b = new Guards("B");
            b.Attack();
            Player c = new Translator("C");
            c.Attack();
            c.Defense();

            Console.Read();

        }

        private static void NewMethod()
        {
            Target target = new Target();
            target.Request();

            Console.Read();
        }
    }
}
