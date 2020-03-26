using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using CodeWars;
using Microsoft.VisualBasic;

namespace ConsoleTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            var from = 3;
            var to = 10;
            var result = 0;

            //var hashSet = new HashSet<int>();
            var set = new HashSet<int>();
            for (var i = 0; i < numbers.Length; i++)
            {
                for (var j = i + 1; j < numbers.Length; j++)
                {
                    var s = numbers[i] + numbers[j];
                    if (s >= from && s < to) set.Add(s);
                }
            }

            //Console.WriteLine();
            //Console.WriteLine(String.Join(", ", set));
            Console.WriteLine(set.Sum());
            //Console.WriteLine(result);
        }
    }
}