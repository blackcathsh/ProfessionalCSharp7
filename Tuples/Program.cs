using System;
using System.Collections.Generic;
using System.Linq;

namespace Tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            ReturningTuples();
            BehindTheScenes();
            Mutability();
            TuplesWithLinkedList();
        }

        private static (int result, int remainder) Divide(int dividend, int divisor)
        {
            int result = dividend / divisor;
            int remainder = dividend % divisor;
            return (result, remainder);
        }

        private static void ReturningTuples()
        {
            (int result, int remainder) = Divide(7, 2);
            Console.WriteLine($"7 / 2 - result: {result}, remainder: {remainder}");
        }

        private static void BehindTheScenes()
        {
            (string s, int i) t1 = ("magic", 42);
            Console.WriteLine($"{t1.s}, {t1.i}, type: {t1.GetType()}");
            ValueTuple<string, int> t2 = ValueTuple.Create("magic", 42);
            Console.WriteLine($"{t2.Item1}, {t2.Item2}, type: {t2.GetType()}");
        }

        private static void Mutability()
        {
            // old tuple is a immutable reference type
            Tuple<string, int> t1 = Tuple.Create("old tuple", 42);
            // t1.Item1 = "new string"; // not possible with Tuple

            // new tuple is a mutable value type
            (string s, int i) t2 = ("new tuple", 42);
            t2.s = "new string";
            t2.i = 43;
            t2.i++;
            Console.WriteLine($"new string: {t2.s}, int: {t2.i}");
        }

        private static void TuplesWithLinkedList()
        {
            Console.WriteLine(nameof(TuplesWithLinkedList));

            var list = new LinkedList<int>(Enumerable.Range(0, 10));

            int value;
            LinkedListNode<int> node = list.First;

            do
            {
                (value, node) = (node.Value, node.Next);
                Console.WriteLine(value);
            } while (node != null);

            Console.WriteLine();
        }
    }
}
