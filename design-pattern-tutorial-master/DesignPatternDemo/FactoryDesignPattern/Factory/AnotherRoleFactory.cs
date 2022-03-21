using FactoryDesignPattern.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern.Factory
{
    internal class AnotherRoleFactory : IEmployeeFactory
    {
        public AnotherRoleFactory(IEmployeeFactory factory)
        {
            Factory = factory;
        }

        public IEmployeeFactory Factory { get; }

        public IEmployee createEmployee()
        {
            //Random random = new Random();

            //int type = random.Next(0, 2);

            //if (type == 0)
            //{
            //    return new Manager();
            //} else
            //{
            //    return new Tester();
            //}
            return new Manager();
        }
    }
}
