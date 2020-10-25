using System;

namespace MathSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Pi is {Math.GetPi()}");

            int x = Math.GetSquareOf(5);
            Console.WriteLine($"Square of 5 is {x}");

            var math = new Math();
            math.Value = 30;
            Console.WriteLine($"Value field of math variable contains {math.Value}");
            Console.WriteLine($"Square of 30 is {math.GetSquare()}");
        }
    }
}
