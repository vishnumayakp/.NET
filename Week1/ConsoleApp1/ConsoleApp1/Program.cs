namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Name");
            String Name = Console.ReadLine();
            // datatype variableName = "value of the variable"
            Console.WriteLine("Hello "+Name);   // string concatenation
            Console.WriteLine("Hello {0}", Name);
            // compositting formatting
            Console.WriteLine($"Hello {Name}");
            // string interpolation
            Console.ReadKey();
            
        }
    }
}
