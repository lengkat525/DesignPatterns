using System;

namespace SimpleFactory
{
    class SimpleFactoryDemo
    {
        private static void Main(string[] args)
        {
            //input 3 parameter
            var ss = OperationFactory.CreatOperate("+");
            ss.NumberA = 1;
            ss.NumberB = 2;

            Console.WriteLine(ss.GetResult());
            Console.Read();
        }
    }

}