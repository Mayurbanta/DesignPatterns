using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.FactoryMethod.Employees
{
    interface IEmployee
    {
        string EmpName { get; set; }
        string GetNetSalary { get; set; }
        string GetTotalSalary(int EmpId);
    }
}
