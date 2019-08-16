using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace FactoryPattern.SImpleFactory
{
    class EmployeeFactory
    {
        Dictionary<string, Type> Employees;

        public EmployeeFactory()
        {
            LoadTypesICanReturn();
        }

        public IEmployee CreateInstance(string EmpType)
        {
            Type t = GetTypeToCreate(EmpType);

            if (t == null)
                return new NullEmployee();

            return Activator.CreateInstance(t) as IEmployee;
        }

        private Type GetTypeToCreate(string empType)
        {
            foreach (var Emp in Employees)
            {
                if (Emp.Key.Contains(empType))
                {
                    return Employees[Emp.Key];
                }
            }
            return null;
        }

        private void LoadTypesICanReturn()
        {
            Employees = new Dictionary<string, Type>();
            var typesInThisAssembly = Assembly.GetExecutingAssembly().GetTypes();

            foreach (Type type in typesInThisAssembly)
            {
                if (type.GetInterface(typeof(IEmployee).ToString()) != null)
                    Employees.Add(type.Name.ToLower(), type);
            }
        }
    }
}
