using System;

namespace SortingSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons =
            {
                new Person("Damon", "Hill"),
                new Person("Niki", "Lauda"),
                new Person("Ayrton", "Senna"),
                new Person("Graham", "Hill")
            };

            Array.Sort(persons);

            foreach (var person in persons)
            {
                Console.WriteLine(person);
            }
        }
    }
}
