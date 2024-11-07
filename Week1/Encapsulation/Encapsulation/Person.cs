using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Person
    {
        private string name;   // Data Members
        private int age;  // Data Members
        private DateTime createdAt;

        public Person()
        {
            this.createdAt = DateTime.Now;
        }

        public DateTime  getCreation()
        {
            return this.createdAt;
        }

        public string GetName()
        {
            return this.name;
        }
        public void SetName(string pName)
        {
            this.name = pName;
        }

        public int GetAge()
        {
            return this.age;
        }
        public void SetAge(int pAge)
        {
            if(pAge>0 && pAge < 150)
            {
                this.age = pAge;
            }
            else
            {
                throw new Exception("Invalid Age");
            }
            
        }

        public void DisplayDetails()  // Member funtion
        {
            Console.WriteLine($"my name is {name} and i am {age} year old");
        }
    }
}
