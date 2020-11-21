﻿using System;
using static System.Console;
using static UsingStatic.FunctionalExtensions;

namespace UsingStatic
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var r = new Resource())
            {
                r.Foo();
            }

            new Resource().Use(r => r.Foo());

            Func<int, int> f1 = x => x + 1;
            Func<int, int> f2 = x => x + 2;
            Func<int, int> f3 = Compose(f1, f2);
            var x1 = f3(39);
            WriteLine(x1);
        }
    }
}
