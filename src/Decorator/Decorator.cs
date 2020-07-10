using System;

namespace Decorator
{
    abstract class Decorator : Component
    {
        protected Component component;
        public void SetComponent(Component comp)
        {
            this.component = comp;
        }

        public override void Operation()
        {
            component?.Operation();
        }
    }

    class ConcreteDecoratorA : Decorator
    {
        private string addedState;
        public override void Operation()
        {
            base.Operation();
            addedState = "New State";
            Console.WriteLine("Operation of specific decoration object A");
        }
    }

    class ConcreteDecoratorB : Decorator
    {
        public override void Operation()
        {
            base.Operation();
            AddedBehavior();
            Console.WriteLine("Operation of specific decoration object B");
        }

        private void AddedBehavior()
        {

        }
    }
}