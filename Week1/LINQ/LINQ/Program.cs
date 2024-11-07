using System.Text;
using System.Text.RegularExpressions;

namespace LINQ
{
    class Employee
    {
        public string Name { get; set; }
        public int Salary { get; set; }
        public string Designation { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> Employees = new List<Employee>()
            {
                new Employee(){Name="Vishnumaya", Salary=25000,Designation="Developer"},
                new Employee(){Name="Abhay", Salary=50000,Designation="Manager"},
                new Employee(){Name="Hrj", Salary=45000,Designation="Developer"}
            };

            foreach (Employee item in Employees)
            {
                if (item.Designation == "Manager")
                {
                    Console.WriteLine($"{item.Name},{item.Designation}");

                }
            }

            var managers = from e in Employees where e.Designation == "Manager" select e;
            foreach (Employee emp in managers)
            {
                Console.WriteLine($"{emp.Name},{emp.Designation}");
            }

            int[] arra = new int[7] { 10, 22, 25, 27, 28, 35, 34 };
            var result = from n in arra where n % 2 == 0 select n;    // FROM WHERE SELECT  EXAMPLE  (query syntax)

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            int[] array = new int[7] { 10, 22, 25, 27, 28, 35, 34 };      
            var evenNum = array.Where(n => n % 2 == 0);    // WHERE EXAMPLE (Method Syntax)
            var sum = 0;
            foreach (var item in evenNum)
            {
                sum += item;
               
            }
            Console.WriteLine(sum);

            List<int> values = new List<int> { 1, 2, 3, 4, 5 };   // SELECT EXAMPLE (Query syntax)
            var evenNumber = from n in values select n * 10;

            foreach(var item in evenNumber)
            {
                Console.WriteLine(item);
            }

            var even = values.Select(n => n * 10);    // SELECT EXAMPLE (Method Syntax)
            foreach (var item in even)
            {
                Console.WriteLine(item);
            }


            //List<int> number = new List<int> {  10, 11, 12, 13, 1, 2, 3, 4, 5, 6, 7, 8, 9, 24 };
            //var evenNumbers = from n in number
            //                  group n by n % 2 == 0 into g
            //                  sel
            //foreach(var item in evenNumbers)
            //{
            //    foreach(var n i)
            //}

            StringBuilder sb = new StringBuilder("Hello");
            sb.Append("Wrold");

        }
    }
}