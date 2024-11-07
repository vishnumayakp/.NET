namespace Oops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fruits apple = new Fruits("Red","Apple");  
            //apple.Color = "Red";
            //apple.name = "Apple";

            apple.DisplayName();
            apple.DisplayColor();
        }
    }
}
