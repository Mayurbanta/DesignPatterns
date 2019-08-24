using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.FactoryMethod.Employees
{
    class PermanentEmployee : IEmployee
    {
        public string EmpName { get ; set ; }

        public string GetTotalSalary(int EmpId)
        {
            return "*** Total Salary for Permanent Employee is 500 ***";
        }

        public string GetGratuity(int EmpId)
        {
            return "*** Gratuity for Permanent Employee is 100 ***";
        }

        private string _getNetSalary;

        public string GetNetSalary
        {
            get { return _getNetSalary; }
            set { _getNetSalary = value; }
        }

    }
}
