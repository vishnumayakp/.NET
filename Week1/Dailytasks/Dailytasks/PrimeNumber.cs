using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dailytasks
{
    internal class PrimeNumber
    {

        bool FindPrime(int number)
        {
            if (number <= 1) return false;


            for(int i=2; i<number; i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
       
        public void primeOrNot()
        {
            Console.WriteLine("Enter a Number: ");
            int num = int.Parse(Console.ReadLine());

            if (FindPrime(num))
            {
                Console.WriteLine($"{num} is Prime Number");
            }
            else
            {
                Console.WriteLine($"{num} is not a prime Number");
            }

        }
    }
}
