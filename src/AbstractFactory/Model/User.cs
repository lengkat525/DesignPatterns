using System;

namespace AbstractFactory
{
    class User
    {
        private int _id { get; set; }
        private string _name { get; set; }
    }

    class SqlserverUser : IUser
    {
        public void Insert(User user)
        {
            Console.WriteLine("Sql server insert into user");
        }


        public User GetUser(int id)
        {
            Console.WriteLine("sql server get user By Id");
            return null;
        }

    }

    class AccessUser : IUser
    {
        public void Insert(User user)
        {
            Console.WriteLine("Access insert into user");
        }


        public User GetUser(int id)
        {
            Console.WriteLine("Access get user By Id");
            return null;
        }

    }

}
