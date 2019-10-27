using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text.RegularExpressions;
using CodeWars;

namespace ConsoleTestApp
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine($"{Math.Sqrt(449426)}");
            Console.WriteLine($"{Math.Sqrt(449426) * Math.Sqrt(449426)}");
            Console.WriteLine($"{(double)Math.Sqrt(449426) * (double)Math.Sqrt(449426) == (double)449426}");
        }
    }
}
