using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dailytasks
{
    internal class Pattern
    {
        public void diamondPattern()
        {
            Console.WriteLine("Enter number of Rows");
            int row = int.Parse(Console.ReadLine());


             for(int i = 1; i<=row; i++)
            {
                for(int j=i; j<row; j++)
                {
                    Console.Write(" ");
                }

                for(int k=1; k<=(2*i-1); k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            for (int i = row - 1; i >= 1; i--)
            {
                for (int j = row; j > i ; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= (2 * i - 1); k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}
