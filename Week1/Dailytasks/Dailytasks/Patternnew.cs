using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dailytasks
{                                                        
    internal class Patternnew
    {
        public void newPattern()
        {
            Console.WriteLine("Enter no:of Rows");
            int row = int.Parse(Console.ReadLine());

            for(int i=1; i<=row; i++)
            {
                for(int j=1; j<=i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
