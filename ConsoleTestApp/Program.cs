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
            double[] inputArray = new double[] {2, 3, 1};
            var r1 = Array.IndexOf(inputArray, inputArray.Min());
            var r2 = Array.IndexOf(inputArray, r1);
            var r3 = 3 - r2;

            var enumerable = inputArray.Except(new[] {inputArray.Min(), inputArray.Max()});
            //inputArray.OrderBy(x => x).GroupBy((x) => inputArray.Average()).Dump();
            var elementAt = inputArray.OrderBy((x) => inputArray.Average());

            Console.WriteLine(3 - Array.IndexOf(inputArray, inputArray.Max()) -
                              Array.IndexOf(inputArray, inputArray.Min()));
        }
    }
}