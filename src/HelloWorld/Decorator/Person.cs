using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Person
    {
        private readonly string _name;
        public Person(string name)
        {
            _name = name;
        }

        public void WearShirts()
        {
            Console.WriteLine("T-shirt");
        }

        public void WearBigTrouser()
        {
            Console.WriteLine("BigTrouser");
        }

        public void WearSneakers()
        {
            Console.WriteLine("Sneakers");
        }

        public void WearSuit()
        {
            Console.WriteLine("Suit");
        }

        public void WearTie()
        {
            Console.WriteLine("Tie");
        }

        public void WearLeatherShoes()
        {
            Console.WriteLine("LeatherShoes");
        }

        public void Show()
        {
            Console.WriteLine("{0}'s look", _name);
        }
    }
}
