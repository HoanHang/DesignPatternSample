using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern.Employee
{
    internal class Designer : IEmployee
    {
        public string CardID()
        {
            return "1111";
        }

        public string Salary()
        {
            return "15.000.000";
        }
    }
}
