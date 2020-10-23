using System;
using Introduction = Wrox.ProCSharp.Basics;

class Program
{
    static void Main(string[] args)
    {
        Introduction::NamespaceExample NSEx = new Introduction.NamespaceExample();
        Console.WriteLine(NSEx.GetNamespace());
    }
}

namespace Wrox.ProCSharp.Basics
{
    class NamespaceExample
    {
        public string GetNamespace() => this.GetType().Namespace;
    }
}
