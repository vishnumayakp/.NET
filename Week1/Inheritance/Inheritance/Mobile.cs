using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Mobile    // PARENT CLASS
    {
        public string os = "Android";

        public void makeCalls()
        {
            Console.WriteLine("Mobile cab makes callls");
        }
    }
}
