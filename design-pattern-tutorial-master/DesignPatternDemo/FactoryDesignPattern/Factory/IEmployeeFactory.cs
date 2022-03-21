using FactoryDesignPattern.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern.Factory
{
    internal interface IEmployeeFactory
    {
        IEmployee createEmployee();
    }
}
