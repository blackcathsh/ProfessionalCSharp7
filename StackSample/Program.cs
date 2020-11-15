using System;
using System.Collections.Generic;

namespace StackSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var alphabet = new Stack<char>();
            alphabet.Push('A');
            alphabet.Push('B');
            alphabet.Push('C');

            Console.WriteLine("First iteration: ");

            foreach (var item in alphabet)
            {
                Console.Write(item);
            }

            Console.WriteLine();

            Console.WriteLine("Second iteration: ");

            while (alphabet.Count > 0)
            {
                Console.Write(alphabet.Pop());
            }

            Console.WriteLine();
        }
    }
}
