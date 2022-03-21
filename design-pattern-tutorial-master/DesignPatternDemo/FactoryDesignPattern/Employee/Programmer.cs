using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern.Employee
{
    internal class Programmer : IEmployee
    {
        public string CardID()
        {
            return "2222";
        }

        public string Salary()
        {
            return "10.000.000";
        }
    }
}
