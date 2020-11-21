using System;

namespace TuplesSample
{
    class Program
    {
        static void Main(string[] args)
        {
            IntroTuples();
            TupleDeconstruction();
        }

        private static void IntroTuples()
        {
            (string s, int i, Person p) t = ("magic", 42, new Person("Stephanie", "Nagel"));
            Console.WriteLine($"s: {t.s}, i: {t.i}, p: {t.p}");

            var t2 = ("magic", 42, new Person("Matthias", "Nagel"));
            Console.WriteLine($"string: {t2.Item1}, int: {t2.Item2}, person: {t2.Item3}");

            var t3 = (s: "magic", i: 42, p: new Person("Matthias", "Nagel"));
            Console.WriteLine($"s: {t3.s}, i: {t3.i}, p: {t3.p}");

            (string astring, int anumber, Person aperson) t4 = t3;
            Console.WriteLine($"s: {t4.astring}, i: {t4.anumber}, p: {t4.aperson}");
        }

        private static void TupleDeconstruction()
        {
            (string s, int i, Person p) = ("magic", 42, new Person("Stephanie", "Nagel"));
            Console.WriteLine($"s: {s}, i: {i}, p: {p}");

            (var s1, var i1, var p1) = ("magic", 42, new Person("Stephanie", "Nagel"));
            Console.WriteLine($"s: {s1}, i: {i1}, p: {p1}");

            string s2;
            int i2;
            Person p2;
            (s2, i2, p2) = ("magic", 42, new Person("Stephanie", "Nagel"));
            Console.WriteLine($"s: {s2}, i: {i2}, p: {p2}");

            (string s3, _, _) = ("magic", 42, new Person("Stephanie", "Nagel"));
            Console.WriteLine(s3);
        }
    }
}
