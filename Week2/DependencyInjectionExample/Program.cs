using System;
using System.Collections.Generic;
namespace DependencyInjectionExample
{
   class Program
    {
        static void Main(string[] args)
        {
            EmployeeBL employeeBL = new EmployeeBL(new EmployeeDAL());
            List<Employee> ListEmployees = employeeBL.GetAllEmployees();

            foreach (Employee employee in ListEmployees) {
                Console.WriteLine($"Id: {employee.Id} Name:{employee.Name} Department:{employee.Department}");
            }
            Console.ReadLine();

        }
    }
}
