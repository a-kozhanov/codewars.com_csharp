/*
https://www.codewars.com/kata/51ba717bb08c1cd60f00002f/csharp

4 kyu
Range Extraction

A format for expressing an ordered list of integers is to use a comma separated list of either

individual integers
or a range of integers denoted by the starting integer separated from the end integer in the range by a dash, '-'. 
The range includes all integers in the interval including both endpoints. 
It is not considered a range unless it spans at least 3 numbers. For example ("12, 13, 15-17")
Complete the solution so that it takes a list of integers in increasing order and returns a correctly formatted string in the range format.

Example:

solution([-6, -3, -2, -1, 0, 1, 3, 4, 5, 7, 8, 9, 10, 11, 14, 15, 17, 18, 19, 20]);
// returns "-6,-3-1,3-5,7-11,14,15,17-20"

Courtesy of rosettacode.org
*/

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualBasic;

namespace CodeWars
{
    public class RangeExtraction
    {
        public static string Extract(int[] args)
        {
            var result = "";

            for (var i = 0; i < args.Length; i++)
            {
                var seq = new List<int> {args[i]};

                while (i < args.Length - 1 && args[i + 1] == args[i] + 1)
                    seq.Add(args[++i]);

                if (seq.Count < 3)
                    result = seq.Aggregate(result, (s, n) => s + (n + ","));
                else
                    result += seq[0] + "-" + seq[^1] + ",";
            }

            return result.TrimEnd(',');


            // var result = "";
            //
            // for (var i = 0; i < args.Length; i++)
            // {
            //     var seq = new List<int>();
            //
            //     if (args.Length > i + 2 && args[i] + 1 == args[i + 1] && args[i + 1] + 1 == args[i + 2])
            //     {
            //         while (args.Length > i + 1 && args[i] + 1 == args[i + 1])
            //         {
            //             seq.Add(args[i]);
            //             seq.Add(args[i + 1]);
            //             i++;
            //         }
            //     }
            //     else
            //     {
            //         seq.Add(args[i]);
            //     }
            //
            //     if (seq.Count >= 2)
            //     {
            //         result += seq.First() + "-" + seq.Last() + ",";
            //     }
            //     else
            //     {
            //         result += seq.First() + ",";
            //     }
            // }
            //
            // return result.TrimEnd(',');


            // return string.Join(",", args
            //     .Select((value, index) =>
            //             (value, args[Math.Min(args.Length - 1, index + 1)] - value != 1
            //                 ? args[0]++ //hack: using first value as "SequenceNumber"
            //                 : args[0]) //      = no need of variable declaration.
            //     )
            //     .GroupBy(x => x.Item2, x => x.Item1)
            //     .Select(x => x.Count() == 1
            //         ? $"{x.ElementAt(0)}"
            //         : $"{x.Min()}{(x.Count() > 2 ? "-" : ",")}{x.Max()}")
            // );


            // public int Value, Count;
            // public int NextValue => Value + Count;
            //
            // public RangeExtraction(int value)
            // {
            //     Value = value;
            //     Count = 1;
            // }
            //
            // public override string ToString()
            //     => Count == 1 ? $"{Value}" :
            //         Count == 2 ? $"{Value},{Value + 1}" :
            //         $"{Value}-{NextValue-1}";
            //
            // public static string Extract(int[] args)
            // {
            //     var list = new List<RangeExtraction>();
            //
            //     foreach (var n in args)
            //         if (list.LastOrDefault()?.NextValue == n) list.Last().Count++;
            //         else list.Add(new RangeExtraction(n));
            //
            //     return string.Join(",", list);
            // }
        }
    }
}