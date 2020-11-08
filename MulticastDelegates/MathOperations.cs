using System;

namespace MulticastDelegates
{
    public class MathOperations
    {
        public static void MultiplyByTwo(double value)
        {
            double result = value * 2;
            Console.WriteLine($"Multiplying by 2: {value} gives {result}");
        }

        public static void Square(double value)
        {
            double result = value * value;
            Console.WriteLine($"Squaring: {value} gives {result}");
        }
    }
}
