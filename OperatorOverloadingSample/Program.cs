using System;

namespace OperatorOverloadingSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector v1 = new Vector(3.0, 3.0, 1.0);
            Vector v2 = new Vector(2.0, -4.0, -4.0);
            Vector v3 = v1 + v2;
            Console.WriteLine($"v1 = {v1}");
            Console.WriteLine($"v2 = {v2}");
            Console.WriteLine($"v3 = {v3}");
        }
    }
}
