using System;

namespace PipelneSample
{
    public class ColoredConsole
    {
        private static object _syncOutput = new object();

        public static void WriteLine(string message)
        {
            lock (_syncOutput)
            {
                Console.WriteLine(message);
            }
        }

        public static void WriteLine(string message, string color)
        {
            lock (_syncOutput)
            {
                Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), color);
                Console.WriteLine(message);
                Console.ResetColor();
            }
        }
    }
}
