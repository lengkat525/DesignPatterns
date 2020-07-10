using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    abstract class Component
    {
        public abstract void Operation();
    }

    class ConcreteComponent : Component
    {
        public override void Operation()
        {
            Console.WriteLine("Operation of specific objects");
        }
    }

}