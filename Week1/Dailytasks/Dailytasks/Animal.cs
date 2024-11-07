using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dailytasks
{

    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Animal(string name,int age)
        {
            Name = name;
            Age = age;
        }
        public virtual void speak()
        {
            Console.WriteLine($"My Name is {Name} and Iam {Age} Year Old");
        }
    }

    public class Dog:Animal
    {
        public string Breed { get; set; }
        public Dog(string name,int age,string breed) : base(name, age)
        {
            Breed = breed;
        }

        public override void speak()
        {
            Console.WriteLine($"My Name is {Name} , Iam {Age} Year Old and iam {Breed} breed");
        }
    }

    public class Cat:Animal
    {
        public Cat(string name, int age) : base(name, age)
        {

        }
        public void meow()
        {
            Console.WriteLine("Meow!");
        }

    }
    
}
