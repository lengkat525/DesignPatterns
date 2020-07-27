using System;

namespace AbstractFactory
{
    class AbstractFactoryDemo
    {
        static void Main(string[] args)
        {
            // NewMethod();
           // NewMethod1();
           User user = new User();
           Department de = new Department();
           IFactory factory = new SqlServerFactory();
           factory.CreateUser().Insert(user);
           factory.CreateDepartment().Insert(de);
           IFactory factory2 = new AccessFactory();
           factory2.CreateUser().Insert(user);
           factory2.CreateDepartment().Insert(de);
           Console.Read();
        }

        private static void NewMethod1()
        {
            User us = new User();

            IFactory factory = new AccessFactory();
            IUser iu = factory.CreateUser();
            iu.Insert(us);

            IFactory factory2 = new SqlServerFactory();
            IUser iu2 = factory2.CreateUser();
            iu2.Insert(us);
            Console.Read();
        }

        private static void NewMethod()
        {
            User user = new User();
            SqlserverUser su = new SqlserverUser();
            su.Insert(user);
            su.GetUser(1);
            Console.Read();
        }
    }
}
