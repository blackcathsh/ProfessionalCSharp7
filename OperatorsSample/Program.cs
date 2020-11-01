using System;

namespace OperatorsSample
{
    class Program
    {
        static void Main(string[] args)
        {
            PrefixAndPostfix();
            ConditionalOperator();

            try
            {
                OverflowExceptionSample();
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
            }

            IsOperator();
            IsOperatorWithConstPattern();
            AsOperatorSample();
        }

        static void PrefixAndPostfix()
        {
            Console.WriteLine(nameof(PrefixAndPostfix));

            int x = 5;

            if (++x == 6)
            {
                Console.WriteLine("This will execute");
            }

            if (x++ == 7)
            {
                Console.WriteLine("This won't");
            }

            Console.WriteLine();
        }

        static void ConditionalOperator()
        {
            Console.WriteLine(nameof(ConditionalOperator));

            int x = 1;
            string s = x + " ";
            s += (x == 1 ? "man" : "men");
            Console.WriteLine(s);

            Console.WriteLine();
        }

        static void OverflowExceptionSample()
        {
            Console.WriteLine(nameof(OverflowExceptionSample));

            byte b = 255;

            checked
            {
                b++;
            }

            Console.WriteLine(b);

            Console.WriteLine();
        }

        static void IsOperator()
        {
            Console.WriteLine(nameof(IsOperator));

            int i = 10;

            if (i is object o)
            {
                Console.WriteLine("i is an object");
            }

            Console.WriteLine();
        }

        static void IsOperatorWithConstPattern()
        {
            Console.WriteLine(nameof(IsOperatorWithConstPattern));

            int i = 42;

            if (i is 42)
            {
                Console.WriteLine("i has the value 42");
            }

            object o = null;

            if (o is null)
            {
                Console.WriteLine("o is null");
            }

            Console.WriteLine();
        }

        static void AsOperatorSample()
        {
            Console.WriteLine(nameof(AsOperatorSample));

            object o1 = "Some String";
            object o2 = 5;
            string s1 = o1 as string;
            string s2 = o2 as string;
            Console.WriteLine($"o1 as string assigns a string to s1: {s1}");
            Console.WriteLine($"o2 as string assigns null to s2 because o2 is not a string: {s2}");

            Console.WriteLine();
        }
    }
}
