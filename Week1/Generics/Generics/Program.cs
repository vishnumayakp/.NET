namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringDataBase str = new StringDataBase();    // NON GENERIC
            str.Create("Hello");
            str.Create("Wrold");
            str.Display();

            GenericClass<int> gen = new GenericClass<int>();  // GENERIC
            gen.Create(32);
            gen.Create(10);
            gen.Display();

            GenericClass<string> gene = new GenericClass<string>();  // GENERIC
            gene.Create("Haii");
            gene.Create("haiiii");
            gene.Display();

        }
    }
}
