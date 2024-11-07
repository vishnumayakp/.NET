namespace AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student();
            Console.WriteLine(st.name);
            Console.WriteLine(st.GetAge());

            Place p = new Place();
            Console.WriteLine(p.GetPlace());
        }
    }
}
