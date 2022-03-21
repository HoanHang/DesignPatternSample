using FactoryDesignPattern.Factory;
using System;

namespace FactoryDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IEmployeeFactory factory;

            factory = new AnotherRoleFactory();

            Console.WriteLine(factory.createEmployee().GetType());
            Console.WriteLine(factory.createEmployee().CardID());
            Console.WriteLine(factory.createEmployee().Salary());

            factory = new DevRoleFactory();

            Console.WriteLine(factory.createEmployee().GetType());
            Console.WriteLine(factory.createEmployee().CardID());
            Console.WriteLine(factory.createEmployee().Salary());

        }
    }
}
