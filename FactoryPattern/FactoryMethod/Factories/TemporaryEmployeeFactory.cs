using System;
using System.Collections.Generic;
using System.Text;
using FactoryPattern.FactoryMethod.Employees;

namespace FactoryPattern.FactoryMethod.Factories
{
    class TemporaryEmployeeFactory : IEmployeeFactory
    {
        public IEmployee CreateEmployee()
        {
            TemporaryEmployee temporaryEmployee = new TemporaryEmployee
            {
                EmpName = "XYZ"
            };
            temporaryEmployee.GetNetSalary = temporaryEmployee.GetTotalSalary(123) +  " Only /-";

            return temporaryEmployee;
        }
    }
}
