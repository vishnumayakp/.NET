namespace LinqTask
{
    internal class Program
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }

        public Program(string name,int age,string city)
        {
            Name = name;
            Age = age;
            City = city;
        }
        static void Main(string[] args)
        {
            List<Program> persons = new List<Program>()
            {
                new Program("Vishnumaya",26,"Calicut"),
                new Program("Abhay",25,"Ramanattukara"),
                new Program("Hrithic",22,"Kondotty"),
                new Program("Ashiq",30,"Calicut"),
                new Program("Shilpa",20,"Calicut")
            };
            var filterPerson = from person in persons
                               where person.Age >= 25 && person.City == "Calicut"
                               select person;
            Console.WriteLine("People That Above age 25 and city calicut is:");
            foreach(var person in filterPerson)
            {
                Console.WriteLine($"Name: {person.Name} Age:{person.Age}");
            }
        }
    }
}
