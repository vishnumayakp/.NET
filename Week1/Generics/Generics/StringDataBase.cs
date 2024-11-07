using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class StringDataBase
    {
        List<string> values = new List<string>();

        public void Create(string item)
        {
            values.Add(item);
        }

        public void Remove(string item)
        {
            values.Remove(item);
        }

        public void Display()
        {
            foreach (var item in values)
            {
                Console.WriteLine(item);
            }
        }

    }

      public class GenericClass<T>
        {
            public List<T> Items = new List<T>();
            public void Create (T item)
            {
                Items.Add(item);
            }

            public void Remov(T item)
            {
                Items.Remove(item);
            }
            public void Display()
            {
                Console.WriteLine("List of"+typeof(T).Name);
                foreach (var item in Items)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }

