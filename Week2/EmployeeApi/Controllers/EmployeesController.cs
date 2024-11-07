using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EmployeeApi.Controllers;
using System.Collections.Generic;
using EmployeeApi.Models;

namespace EmployeeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private static List<Employees> employees = new List<Employees>
        {
            new Employees{Id=1,Name="Vishnumaya",Salary=45000},
            new Employees{Id=2,Name="Abhay",Salary=60000},
            new Employees{Id=3,Name="Hrithic",Salary=25000},
            new Employees{Id=4,Name="Shilpa",Salary=45000},
            new Employees{Id=5,Name="Hari",Salary=50000}
        };

        [HttpGet]

        public ActionResult<IEnumerable<Employees>> GetEmployee()
        {
            return Ok(employees);
        }

        [HttpGet("{id}")]

        public ActionResult<IEnumerable<Employees>> GetEmployee(int id)
        {
            var findEmployee = employees.Find(employee => employee.Id == id);
            if (findEmployee == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(findEmployee);
            }
        }

        [HttpPost]

        public ActionResult<IEnumerable<Employees>> AddEmployee(Employees newEmployee)
        {
            newEmployee.Id = employees.Max(value => value.Id) + 1;
            employees.Add(newEmployee);

            return CreatedAtAction(nameof(GetEmployee), new { id = newEmployee.Id }, newEmployee);
        }

        [HttpPut]

        public IActionResult UpdateEmployee(int id,Employees updatedEmployee)
        {
            var employeeData = employees.Find(employee => employee.Id == id);
            if(employees == null)
            {
                return NotFound();
            }
            employeeData.Name = updatedEmployee.Name;
            employeeData.Salary = updatedEmployee.Salary;
            return NoContent();
        }

        [HttpDelete("{id}")]

        public ActionResult DeleteEmployee(int id)
        {
            var deleteEmployee = employees.FirstOrDefault(employee => employee.Id == id);
            if (deleteEmployee==null){
                return NotFound();
            }
            employees.Remove(deleteEmployee);
            return NoContent();
        }

    }
}
