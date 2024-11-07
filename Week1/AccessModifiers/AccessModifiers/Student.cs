using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    internal class Student
    {
        public string name = "Vishnumaya";
        private int age = 20;
        protected string location = "Kochi";

        public int GetAge()
        {
            return age;
        }
    }

    class Place : Student
    {
        public string GetPlace()
        {
            return location;
        }
    }
}
