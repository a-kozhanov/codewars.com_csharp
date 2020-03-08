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
            string expected =
                "6|##### 5\n" +
                "5|\n" +
                "4|# 1\n" +
                "3|########## 10\n" +
                "2|### 3\n" +
                "1|####### 7\n";

            var results = new int[] {7, 3, 10, 1, 0, 5};

            StringBuilder sb = new StringBuilder();

            for (var i = results.Length - 1; i >= 0; i--)
            {
                //Console.WriteLine($"{i + 1}|{new string('#', results[i])}{(results[i] > 0 ? " " + results[i] : "")}");
                sb.Append($"{i + 1}|{new string('#', results[i])}{(results[i] > 0 ? " " + results[i] : "")}\n");
            }

            Console.WriteLine(sb.ToString());
            Console.WriteLine();


            var ss = Enumerable.Range(0, 6).Select((x, i) =>
                $"{i + 1}|{new string('#', results[i])}{(results[i] > 0 ? " " + results[i] : "")}").Reverse();

            Console.WriteLine(string.Join("\n", ss));

            // var s1 = Enumerable.Range(0, 6).Reverse().Select((x, i) =>
            //     $"{i + 1}|{new string('#', results[i])}{(results[i] > 0 ? " " + results[i] : "")}\n");

            // StringBuilder sb = new StringBuilder();
            //
            // for (var i = results.Length - 1; i >= 0; i--)
            // {
            //     sb.Append($"{i + 1}|{new string('#', results[i])}{(results[i] > 0 ? " " + results[i] : "")}\n");
            // }

            //return sb.ToString();

            // var s2 = Enumerable.Range(0, 6).Select((x, i) =>
            //     $"{i + 1}|{new string('#', results[i])}{(results[i] > 0 ? " " + results[i] : "")}").Reverse();

            //return string.Join("\n", s2) + "\n";
        }
    }
}