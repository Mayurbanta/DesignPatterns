using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.SImpleFactory
{
    interface IEmployee
    {
        string EmpName { get; set; }
        int GetAnnualSalary(int EmpId);
    }
}
