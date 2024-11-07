using System.Diagnostics;

namespace Delegates
{
    internal class Program
    {
        delegate int changeNumber(int n);
        static void Main(string[] args)
        {

            changeNumber del1 = new changeNumber(Add10);
            Console.WriteLine(del1.Invoke(20));
            Console.WriteLine(del1(20));

            changeNumber del2 = new changeNumber(Multiply5);
            Console.WriteLine(del2.Invoke(10));
            Console.WriteLine(del2(10));

            Console.WriteLine(Add10(20));
            Console.WriteLine(Multiply5(10));
            
        }

        static int Add10(int num)
        {
            return num + 10;
        }

        static int Multiply5(int num1)
        {
            return num1*5;
        }
    }
}
