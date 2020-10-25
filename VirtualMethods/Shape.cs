using System;

namespace VirtualMethods
{
    public class Shape
    {
        public Position Position { get; } = new Position();
        public Size Size { get; } = new Size();
        public virtual void Draw() =>
            Console.WriteLine($"Shape with {Position} and {Size}");

        public virtual void Move(Position position)
        {
            Position.X = position.X;
            Position.Y = position.Y;
            Console.WriteLine($"moves to {Position}");
        }
    }
}
