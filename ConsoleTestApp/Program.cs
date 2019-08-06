using System;
using System.Linq;
using CodeWars;

namespace ConsoleTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new string("world".Reverse().ToArray()));
            Console.WriteLine(ReversedStrings.Solution("world"));
        }
    }
}
