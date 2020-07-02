using System;

namespace Decorator
{
    abstract class Finery
    {
        public abstract void Show();
    }

    class TShirts : Finery
    {
        public override void Show()
        {
            Console.WriteLine("T-shirt");
        }
    }

    class BigTrouser : Finery
    {
        public override void Show()
        {
            Console.WriteLine("BigTrouser");
        }
    }

    class Sneakers : Finery
    {
        public override void Show()
        {
            Console.WriteLine("Sneakers");
        }
    }

    class Suit : Finery
    {
        public override void Show()
        {
            Console.WriteLine("Suit");
        }
    }

    class Tie : Finery
    {
        public override void Show()
        {
            Console.WriteLine("Tie");
        }
    }

    class LeatherShoes : Finery
    {
        public override void Show()
        {
            Console.WriteLine("LeatherShoes");
        }
    }
}
