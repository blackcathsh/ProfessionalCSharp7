using System;

namespace VariableScopeSample
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; ++i)
            {
                Console.WriteLine(i);
            }

            // 可以重新声明变量i，因为在当前作用域中没有变量i
            for (int i = 9; i >= 0; --i)
            {
                Console.WriteLine(i);
            }
        }
    }
}
