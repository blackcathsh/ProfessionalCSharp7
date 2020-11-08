using System;

namespace StringFormats
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Person { FirstName = "Stephanie", LastName = "Nagel" };
            Console.WriteLine(p1.ToString("F", null));
            Console.WriteLine($"{p1:F}");
        }
    }
}
