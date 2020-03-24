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
            double[][] arr = (new double[][]
            {
                new double[] {2, 3, 9, 10, 7},
                new double[] {12, 6, 89, 45, 3},
                new double[] {9, 12, 56, 10, 34},
                new double[] {67, 23, 1, 88, 34}
            });

            Console.WriteLine(arr.Length);
            Console.WriteLine(arr[0].Length);
            Console.WriteLine(arr.GetLength(0));
            Console.WriteLine(arr.Rank);
            Console.WriteLine(arr.GetLowerBound(0));


            Enumerable.Range(0, arr.First().Length).Select(i => Enumerable.Range(0, arr.Length).Select(j => arr[j][i]))
                .ToArray().Select(a => a.Average());

            //Enumerable.Range(0, arr.Length).Select(x => x);

            //var r = arr[0].Zip(arr[1], (a, b) => new double[] {a, b}.Average());
        }
    }
}