using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern.Employee
{
    internal class Tester : IEmployee
    {
        public string CardID()
        {
            return "3333";
        }

        public string Salary()
        {
            return "12.000.000";
        }
    }
}
