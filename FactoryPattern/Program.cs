using System;
using FactoryPattern.SImpleFactory;
namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Press 1 for Simple Factory:");
            
            string option = Console.ReadLine();

            if (option == "1")
            {
                string EmployeeType = "PermanentEmployee";
                EmployeeFactory employeeFactory = new EmployeeFactory();
                IEmployee emp = employeeFactory.CreateInstance(EmployeeType.ToLower());
                var salary = emp.GetAnnualSalary(123);
                Console.WriteLine($"Salary : {salary.ToString()} ");
            }
        }


    }
}
