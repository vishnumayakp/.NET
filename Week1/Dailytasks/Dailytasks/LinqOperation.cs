using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Dailytasks
{
    public class LinqOperation
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }

        public LinqOperation(string name, int age, string city)
        {
            Name = name;
            Age = age;
            City = city;
        }

        //private List<LinqOperation> values = new List<LinqOperation>()
        //{
        //    new LinqOperation("Vishnumaya", 20, "Karad"),
        //    new LinqOperation("Abhay", 31, "Ramanattukara"),
        //    new LinqOperation("Hrithic", 29, "Kondotty"),
        //    new LinqOperation("Ashiq", 30, "Calicut"),
        //    new LinqOperation("Shilpa", 20, "Calicut")
        //};

  
        //public void FilterAndDisplay(string city, int minAge)
        //{
        //    var persons = from person in values
        //                  where person.Age >= minAge && person.City == city
        //                  select new { person.Name, person.Age };

           
        //    foreach (var person in persons)
        //    {
        //        Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
        //    }
        //}
    }
}