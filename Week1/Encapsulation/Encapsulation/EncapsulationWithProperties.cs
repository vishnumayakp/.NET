using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.EncapsulationWithProperties
{
    public class Person1
    {

        //private string name;   // Data Members
        //private int age;  // Data Members
        //private DateTime createdAt;

        //public string Name
        // {
        //     get { return name; }
        //     set { name = value; }
        // }

        //public int Age
        //{
        //    get { return age; }
        //    set
        //    {
        //        if (value > 0 && value <= 150)
        //        {
        //            this.age= value;
        //        }
        //        else
        //        {
        //            throw new Exception("Invalid Age");
        //        }
        //    }
        //}

        //public DateTime CreatedAt
        //{
        //    get { return createdAt; }


        //}


        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime CreatedAt { get; set; }

        public Person1()
        {
            this.CreatedAt = DateTime.Now;
        }
    }
}
