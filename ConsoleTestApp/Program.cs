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
            //var arr = new int[] {1, 1, 1, 2, 2, 3};
            var arr = new int[] {96, 56, 24, 46, 75, 46, 75, 21, 46, 21, 75, 96, 56, 96, 56};

            var x = arr.Count(i => i == 1);
            var y = arr.Count(i => i == 2);

            // var x = arr.Where(i => arr.Count(v => v == i) == 1);
            // var y = arr.Where(i => arr.Count(v => v == i) == 2);

            Console.WriteLine(string.Join(", ", arr.GroupBy(o => o)));
            Console.WriteLine(string.Join(", ", arr.OrderBy(o => o)));
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(x * x * y);
        }
    }
}