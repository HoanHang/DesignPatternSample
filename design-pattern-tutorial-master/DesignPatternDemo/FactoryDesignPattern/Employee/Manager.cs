using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern.Employee
{
    internal class Manager : IEmployee
    {
        public string CardID()
        {
            return "9999";
        }

        public string Salary()
        {
            return "50.000.000";
        }
    }
}
