using System;

namespace AbstractFactory
{
    class Department : IDepartment
    {
        private int Id { get; set; }
        public void Insert(Department department)
        {
            Console.WriteLine("insert into Department");
        }

        public Department GetDepartment(int id)
        {
            Console.WriteLine("get Department");
            return null;
        }
    }

    class SqlserverDepartment : IDepartment
    {
        public void Insert(Department department)
        {
            Console.WriteLine("sqlserver insert into Department");
        }

        public Department GetDepartment(int id)
        {
            Console.WriteLine("sqlserver get Department");
            return null;
        }
    }

    class AccessDepartment : IDepartment
    {
        public void Insert(Department department)
        {
            Console.WriteLine("Access insert into Department");
        }

        public Department GetDepartment(int id)
        {
            Console.WriteLine("Access get Department");
            return null;
        }
    }
}
