using System;
using System.Collections.Generic;
using System.Text;
using FactoryPattern.FactoryMethod.Employees;

namespace FactoryPattern.FactoryMethod.Factories
{
    class PermanentEmployeeFactory : IEmployeeFactory
    {
        public IEmployee CreateEmployee()
        {
            PermanentEmployee permanentEmployee = new PermanentEmployee
            {
                EmpName = "Emp ABC"
            };

            permanentEmployee.GetNetSalary = permanentEmployee.GetTotalSalary(123) + " |AND| " + permanentEmployee.GetGratuity(123);

            return permanentEmployee;
        }
    }
}
