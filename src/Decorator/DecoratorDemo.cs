using System;

namespace Decorator
{
    class DecoratorDemo
    {
        static void Main(string[] args)
        {
            //NewMethod();
            //NewMethod1();
            //NewMethod2();
            NewMethod();
        }

        private static void NewMethod()
        {
            Person person = new Person("Leng");
            Console.WriteLine("first look");
            Sneakers sneakers = new Sneakers();
            BigTrouser trouser = new BigTrouser();
            TShirts tShirts = new TShirts();

            //Decoration process
            sneakers.Decorate(person);
            trouser.Decorate(sneakers);
            tShirts.Decorate(trouser);
            tShirts.Show();

            Console.WriteLine("\nsecond look");
            LeatherShoes leatherShoes = new LeatherShoes();
            Tie tie = new Tie();
            Suit suit = new Suit();

            //Decoration process
            leatherShoes.Decorate(person);
            tie.Decorate(leatherShoes);
            suit.Decorate(tie);
            suit.Show();

            Console.Read();
        }

        private static void NewMethod2()
        {
            ConcreteComponent c = new ConcreteComponent();
            ConcreteDecoratorA d1 = new ConcreteDecoratorA();
            ConcreteDecoratorB d2 = new ConcreteDecoratorB();

            d1.SetComponent(c);
            d2.SetComponent(d1);
            d2.Operation();

            Console.Read();
        }


        private static void NewMethod1()
        {
            Person pr = new Person("Leng");
            Console.WriteLine("first look");

            Finery tShirts = new TShirts();
            tShirts.Show();
            Finery bigTrouser = new BigTrouser();
            bigTrouser.Show();
            Finery sneakers = new Sneakers();
            sneakers.Show();
            pr.Show();

            Console.WriteLine("\nsecond look");
            Finery suit = new Suit();
            suit.Show();
            Finery tie = new Tie();
            tie.Show();
            Finery leatherShoes = new LeatherShoes();
            leatherShoes.Show();
            pr.Show();

            Console.Read();
        }

        //private static void NewMethod()
        //{
        //    Person ps = new Person("Leng");
        //    Console.WriteLine("first look");
        //    ps.WearShirts();
        //    ps.WearBigTrouser();
        //    ps.WearSneakers();
        //    ps.Show();

        //    Console.WriteLine("\nsecond look");
        //    ps.WearSuit();
        //    ps.WearTie();
        //    ps.WearLeatherShoes();
        //    ps.Show();

        //    Console.Read();
        //}
    }
}
