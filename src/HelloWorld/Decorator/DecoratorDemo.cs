using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class DecoratorDemo
    {
        static void Main(string[] args)
        {
            //NewMethod();
            NewMethod1();
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

        private static void NewMethod()
        {
            Person ps = new Person("Leng");
            Console.WriteLine("first look");
            ps.WearShirts();
            ps.WearBigTrouser();
            ps.WearSneakers();
            ps.Show();

            Console.WriteLine("\nsecond look");
            ps.WearSuit();
            ps.WearTie();
            ps.WearLeatherShoes();
            ps.Show();

            Console.Read();
        }
    }
}
