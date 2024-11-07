using Encapsulation.EncapsulationWithProperties;

namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Person p = new Person();
            // p.SetName("Test");
            // p.SetAge(20);
            //Console.WriteLine($"created at : {p.getCreation()}");
            // p.DisplayDetails();


            Person1 person = new Person1();
            person.Name = "Test";
            person.Age = 30;
            Console.WriteLine($"name is {person.Name} and age is {person.Age}");

        }
    }
}
