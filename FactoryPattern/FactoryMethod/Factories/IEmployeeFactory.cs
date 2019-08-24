using System;
using System.Collections.Generic;
using System.Text;
using FactoryPattern.FactoryMethod.Employees;

namespace FactoryPattern.FactoryMethod.Factories
{
    interface IEmployeeFactory
    {
        IEmployee CreateEmployee();

    }
}
