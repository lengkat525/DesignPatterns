﻿using System;

namespace FactoryMethod
{
    class FactoryMethodDemo
    {
        static void Main(string[] args)
        {
            //NewMethod();
            //NewMethod1();
            //NewMethod2();
            IFactory factory = new UndergraduateFactory();
            IFactory factory2 = new VolunteerFactory();
            LeiFeng stu = factory.CreateLeiFeng();
            LeiFeng vol = factory2.CreateLeiFeng();
           
            stu.Sweep();
            vol.BuyRice();
            Console.ReadLine();
        }

        private static void NewMethod2()
        {
            LeiFeng stuA = SimpleFactory.CreateLeiFeng("Undergraduate");
            stuA.Sweep();
            LeiFeng volA = SimpleFactory.CreateLeiFeng("Volunteer");
            volA.BuyRice();
            Console.Read();
        }

        private static void NewMethod1()
        {
            LeiFeng learnFromLeiFeng = new Undergraduate();
            learnFromLeiFeng.BuyRice();
            learnFromLeiFeng.Sweep();
            learnFromLeiFeng.Wash();
            Console.Read();
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
