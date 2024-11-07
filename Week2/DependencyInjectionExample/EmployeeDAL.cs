using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionExample
{
    public interface IEmployeeDAL
    {
        List<Employee> SetAllEmployees();
    }
   public class EmployeeDAL:IEmployeeDAL
    {
        public List<Employee> SetAllEmployees()
        {
            List<Employee> listEmployees = new List<Employee>()
            {
                new Employee{Id=1,Name="Vishnumaya",Department="IT"},
                new Employee{Id=2,Name="Abhay",Department="HR"},
                new Employee{Id=3,Name="Hrithic",Department="Account"},
                new Employee{Id=4,Name="Shilpa",Department="Manager"},
                new Employee{Id=5,Name="Salman",Department="IT"}
            };
            return listEmployees;
          
        }
    }
}
