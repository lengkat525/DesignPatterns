using System;

namespace Decorator
{
    class Finery: Person
    {
        protected Person Component;

        public void Decorate(Person component)
        {
            Component = component;
        }

        public override void Show()
        {
            Component?.Show();
        }

    }

    class TShirts : Finery
    {
        public override void Show()
        {
            Console.WriteLine("T-shirt");
            base.Show();
        }
    }

    class BigTrouser : Finery
    {
        public override void Show()
        {
            Console.WriteLine("BigTrouser");
            base.Show();
        }
    }

    class Sneakers : Finery
    {
        public override void Show()
        {
            Console.WriteLine("Sneakers");
            base.Show();
        }
    }

    class Suit : Finery
    {
        public override void Show()
        {
            Console.WriteLine("Suit");
            base.Show();
        }
    }

    class Tie : Finery
    {
        public override void Show()
        {
            Console.WriteLine("Tie");
            base.Show();
        }
    }

    class LeatherShoes : Finery
    {
        public override void Show()
        {
            Console.WriteLine("LeatherShoes");
            base.Show();
        }
    }
}
