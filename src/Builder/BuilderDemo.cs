
using System;

namespace Builder
{
    class BuilderDemo
    {
        static void Main(string[] args)
        {
            Director d1 = new Director();
            Builder b1 = new ConcreteBuilder1();
            Builder b2 = new ConcreteBuilder2();

            d1.Construct(b1);
            Product p1 = b1.GetResult();
            p1.Show();

            d1.Construct(b2);
            Product p2 = b2.GetResult();
            p2.Show();

            Console.Read();

        }
    }
}
