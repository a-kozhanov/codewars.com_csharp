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
            var legs = 8;
            var result = new List<int>();

            // while (legs > 0)
            // {
            //     result.Add(legs / 2);
            //     legs -= 4;
            // }
            //
            // if (result.Last() == 2)
            // {
            //     result.Add(0);
            // }

            //result = result.OrderBy(x => x).ToList();

            //Console.WriteLine(string.Join(", ", result));

            //Enumerable.Range(legs % 4 / 2, legs / 2 + 1);

            //Console.WriteLine(legs % 4 / 2);
            //Console.WriteLine(legs / 2 + 1);

            for (var i = legs % 4 / 2; i <= legs / 2 + 1; i += 2)
            {
                Console.WriteLine(i);
            }

            //return list(range(legs % 4 // 2, legs // 2 + 1, 2))
        }
    }
}