using System;

namespace FactoryMethod
{
    class FactoryMethodDemo
    {
        static void Main(string[] args)
        {
            NewMethod();

        }

        private static void NewMethod()
        {
            IFactory operFactory = new AddFactory();
            Operation oper = operFactory.CreateOperation();
            oper.NumberA = 1;
            oper.NumberB = 2;
            double result = oper.GetResult();

            Console.WriteLine(result);
            Console.Read();
        }
    }
}
