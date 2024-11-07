namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Android android = new Android();
            android.os = "ios";
            android.makeCalls();
            Console.WriteLine(android.os);
        }
    }
}
