using FactoryDesignPattern.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern.Factory
{
    internal class DevRoleFactory : IEmployeeFactory
    {
        public IEmployee createEmployee()
        {
            //Random random = new Random();
            //int type = random.Next(0, 2);

            //if (type == 0)
            //{
            //    return new Programmer();
            //} else
            //{
            //    return new Designer();
            //}
            return new Designer();
        }
    }
}
