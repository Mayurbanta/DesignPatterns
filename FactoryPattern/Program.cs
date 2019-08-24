using System;
using FactoryPattern.FactoryMethod.Factories;
using FactoryPattern.SImpleFactory;
namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Press 1 for Simple Factory:");
            Console.WriteLine($"Press 2 for Factory Method:");

            string option = Console.ReadLine();

            switch (option)
            {
                case "1": //-------------Simple Factory Example-----------------

                    string EmployeeType = "PermanentEmployee";
                    EmployeeFactory employeeFactory = new EmployeeFactory();
                    IEmployee emp = employeeFactory.CreateInstance(EmployeeType.ToLower());
                    var salary = emp.GetAnnualSalary(123);
                    Console.WriteLine($"Salary : {salary.ToString()} ");

                    break;

                case "2": //-------------Factory Method Example-----------------

                    //IEmployeeFactory empfactory = LoadFactory("Permanent");
                    IEmployeeFactory empfactory = LoadFactory("Temporary");

                    FactoryPattern.FactoryMethod.Employees.IEmployee employee = empfactory.CreateEmployee();
                    string netsalary = employee.GetNetSalary;
                    Console.WriteLine(netsalary);
                    break;

                default:
                    break;
            }

        }

        private static IEmployeeFactory LoadFactory(string EmpType)
        {
            
            switch (EmpType)
            {
                case "Permanent":
                    return new PermanentEmployeeFactory();
                case "Temporary":
                    return new TemporaryEmployeeFactory();
                default:
                    break;
            }

            return new PermanentEmployeeFactory();

        }
    }
}
