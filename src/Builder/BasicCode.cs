using System;
using System.Collections.Generic;

namespace Builder
{
    class BasicCode
    {
    }

    class Product
    {
        IList<string> parts = new List<string>();

        public void Add(string part)
        {
            parts.Add(part);
        }

        public void Show()
        {
            Console.WriteLine("\nProduct create ---");
            foreach (string part in parts)
            {
                Console.WriteLine(part);
            }
        }
    }

    abstract class Builder
    {
        public abstract void BuildPartA();
        public abstract void BuildPartB();
        public abstract Product GetResult();
    }

    class ConcreteBuilder1: Builder
    {
        private Product product = new Product();

        public override void BuildPartA()
        {
            product.Add("part A");
        }

        public override void BuildPartB()
        {
            product.Add("part B");
        }

        public override Product GetResult()
        {
            return product;
        }

    }

    class ConcreteBuilder2 : Builder
    {
        private Product product = new Product();

        public override void BuildPartA()
        {
            product.Add("part X");
        }

        public override void BuildPartB()
        {
            product.Add("part Y");
        }

        public override Product GetResult()
        {
            return product;
        }

    }

    class Director
    {
        public void Construct(Builder builder)
        {
            builder.BuildPartA();
            builder.BuildPartB();
        }
    }
}
