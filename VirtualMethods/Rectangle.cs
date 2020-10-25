using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualMethods
{
    public class Rectangle : Shape
    {
        public override void Draw() =>
            Console.WriteLine($"Rectangle with {Position} and {Size}");

        public override void Move(Position position)
        {
            Console.Write("Rectangle ");
            base.Move(position);
        }
    }
}
