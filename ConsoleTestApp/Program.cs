using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
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
            var numbers = new int[3, 5] {{1, 2, 3, 4, 5}, {5, 6, 7, 8, 9}, {20, 21, 34, 56, 100}};

            int rows = numbers.GetUpperBound(0) + 1;
            int columns = numbers.Length / rows;

            Console.WriteLine(rows);
            Console.WriteLine(columns);

            //Console.WriteLine(numbers.GetValue(0, 1));
            Console.WriteLine($"Rank: {numbers.Rank}");
            Console.WriteLine($"Length: {numbers.Length}");
            Console.WriteLine($"GetLength: {numbers.GetLength(0)}");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            // for (var i = 0; i < numbers.Length + 1; i++)
            // {
            //     Console.WriteLine(i);
            // }

            for (var i = 0; i < numbers.Rank; i++)
            {
                //Console.WriteLine(numbers.GetLength(i));
                //Console.WriteLine(numbers.GetEnumerator()GetValue(1, 2));
                //Console.WriteLine(numbers.(1,2));
            }

            // List<int> result = new List<int>();
            //
            // for (var i = 0; i < rows; i++)
            // {
            //     var arr = new List<int>();
            //     for (var j = 0; j < columns; j++)
            //     {
            //         arr.Add(numbers[i, j]);
            //     }
            //
            //     result.Add(arr.Min());
            // }
            //
            // Console.WriteLine(result.Sum());
            
            Enumerable.Range(0, numbers.Rank + 1)
                .Select(x => Enumerable.Range(0, numbers.GetLength(1)).Select(y => numbers[x, y]))
                .Sum(x => x.Min());
        }

        //Assert.AreEqual(26,SumOfMinimums.SumOfMinimums(new int[3, 5] {{1, 2, 3, 4, 5}, {5, 6, 7, 8, 9}, {20, 21, 34, 56, 100}}));
    }
}