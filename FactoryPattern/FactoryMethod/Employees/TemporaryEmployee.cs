using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.FactoryMethod.Employees
{
    class TemporaryEmployee : IEmployee
    {
        public string EmpName { get; set; }

        public string GetTotalSalary(int EmpId)
        {
            return "@@@ Total Salary for Temporary Employee is 175 @@@";
        }


        private string _getNetSalary;

        public string GetNetSalary
        {
            get { return _getNetSalary; }
            set { _getNetSalary = value; }
        }

    }
}
