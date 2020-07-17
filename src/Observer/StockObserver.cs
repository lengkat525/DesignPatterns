
using System;

namespace Observer
{
    abstract class Observer
    {
        protected string _name;
        protected Secretary _sub;

        public Observer(string name, Secretary sub)
        {
            _name = name;
            _sub = sub;
        }

        public abstract void Update();
    }

    class StockObserver : Observer
    {
        public StockObserver(string name, Secretary sub) : base(name, sub)
        {
        }

        public override void Update()
        {
            Console.WriteLine("{0} {1}", _sub.SecretaryAction, _name);
        }
    }

    class NBAObserver : Observer
    {
        public NBAObserver(string name, Secretary sub) : base(name, sub)
        {
        }

        public override void Update()
        {
            Console.WriteLine("{0} {1}", _sub.SecretaryAction, _name);
        }
    }
}
