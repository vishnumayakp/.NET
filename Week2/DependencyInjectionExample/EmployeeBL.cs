﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionExample
{
    public class EmployeeBL
    {
        public IEmployeeDAL employeeDAL;

        public EmployeeBL(IEmployeeDAL employeeDAL)
        {
            this.employeeDAL= employeeDAL; 
        }

        public List<Employee> GetAllEmployees()
        {
            return employeeDAL.SetAllEmployees();
        }

    }
}
