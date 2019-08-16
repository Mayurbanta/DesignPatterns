using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.SImpleFactory
{
    class ContractEmployee : IEmployee
    {
        public string EmpName { get; set; }

        public int GetAnnualSalary(int EmpId)
        {
            return 200;
        }
    }
}
