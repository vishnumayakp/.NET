using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    internal class Fruits
    {
        public String Color; // Fields
        public string name;  // Fields


        public Fruits(string fruitColor, string fruitName)   // constructor
        {
            this.Color = fruitColor;
            this.name = fruitName;
        }
        public void DisplayName()     // Object Methods
        {
            Console.WriteLine(name);
        }
        public void DisplayColor()
        {
            Console.WriteLine(Color);
        }
    }
}
