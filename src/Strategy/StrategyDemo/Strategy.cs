using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    abstract class Strategy
    {
        public abstract void AlgorithmInterface();
    }

    class ConcreteStrategyA : Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("Algorithm A implementation");
        }
    }

    class ConcreteStrategyB : Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("Algorithm B implementation");
        }
    }

    class ConcreteStrategyC : Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("Algorithm C implementation");
        }
    }
}