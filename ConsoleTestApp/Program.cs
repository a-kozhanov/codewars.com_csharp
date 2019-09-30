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

            Console.WriteLine(CountingChangeCombinations.CountCombinations(4, new[] { 1, 2 }));
            Console.WriteLine(CountingChangeCombinations.CountCombinations(10, new[] { 5, 2, 3 }));

        }
    }
}
