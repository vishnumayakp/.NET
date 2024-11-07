namespace OopsConcept
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator cal = new Calculator();

            int sum1 = cal.Add(10, 20);
            Console.WriteLine("sum1 is:"+sum1);

            int sum2 = cal.Add(10, 20, 30);
            Console.WriteLine("sum2 is: "+ sum2);

            double sum3 = cal.Add(10.5,11.5);
            Console.WriteLine("Sum3 is: "+ sum3);

            double sum4 = cal.Add(5, 10.5);
            Console.WriteLine("sum4 is: " + sum4);
        }
    }
}
