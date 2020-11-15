using System;
using System.Collections.Generic;

namespace SortedListSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new SortedList<string, string>();
            books.Add("Professional WPF Programming", "978-0-470-04180-2");
            books.Add("Processional ASP.NET MVC 5", "978-1-118-79475-3");

            books["Beginning C# 6 Programming"] = "978-1-119-09668-9";
            books["Professional C# 6 and .NET Core 1.0"] = "978-1-119-09660-3";

            foreach (var book in books)
            {
                Console.WriteLine($"{book.Key}, {book.Value}");
            }

            foreach (var isbn in books.Values)
            {
                Console.WriteLine(isbn);
            }

            foreach (var title in books.Keys)
            {
                Console.WriteLine(title);
            }

            string title1 = "Professional C# 8";

            if (!books.TryGetValue(title1, out string isbn1))
            {
                Console.WriteLine($"{title1} not found");
            }
        }
    }
}
