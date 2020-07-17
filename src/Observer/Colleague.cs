
using System;

namespace Observer
{
    abstract class Colleague
    {
        protected string Name;
        protected IObserver Obs;

        protected Colleague(string name, IObserver obs)
        {
            Name = name;
            Obs = obs;
        }

        public abstract void Update();
    }

    class StockColleague : Colleague
    {
        public StockColleague(string name, IObserver obs) : base(name, obs)
        {
        }

        public override void Update()
        {
            Console.WriteLine("{0} {1} close stock window", Obs.SecretaryAction, Name);
        }
    }

    class NbaColleague : Colleague
    {
        public NbaColleague(string name, IObserver obs) : base(name, obs)
        {
        }

        public override void Update()
        {
            Console.WriteLine("{0} {1} close nba window", Obs.SecretaryAction, Name);
        }
    }
}
