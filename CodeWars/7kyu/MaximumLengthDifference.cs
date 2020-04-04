/*
https://www.codewars.com/kata/5663f5305102699bad000056/train/csharp

7 kyu
Maximum Length Difference

You are given two arrays a1 and a2 of strings. Each string is composed with letters from a to z. 
Let x be any string in the first array and y be any string in the second array.

Find max(abs(length(x) − length(y)))

If a1 and/or a2 are empty return -1 in each language except in Haskell (F#) where you will return Nothing (None).

#Example:

a1 = ["hoqq", "bbllkw", "oox", "ejjuyyy", "plmiis", "xxxzgpsssa", "xxwwkktt", "znnnnfqknaz", "qqquuhii", "dvvvwz"]
a2 = ["cccooommaaqqoxii", "gggqaffhhh", "tttoowwwmmww"]
mxdiflg(a1, a2) --> 13
Bash note:
input : 2 strings with substrings separated by ,
output: number as a string
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class MaximumLengthDifference
    {
        public static int Mxdiflg(string[] a1, string[] a2)
        {
            // return a1.SelectMany(_ => a2, (x, z) => Math.Abs(x.Length - z.Length)).DefaultIfEmpty(-1).Max();

            // return !a1.Any() || !a2.Any()
            //     ? -1
            //     : Max(a1.Max(a => a.Length) - a2.Min(a => a.Length), a2.Max(a => a.Length) - a1.Min(a => a.Length));


            // return a1.Length == 0 | a2.Length == 0
            //     ? -1
            //     : Math.Max(a1.Max(x => x.Length) - a2.Min(x => x.Length),
            //         a2.Max(x => x.Length) - a1.Min(x => x.Length));

            return !a1.Any() || !a2.Any() ? -1 : a1.Max(x => a2.Max(y => Math.Abs(x.Length - y.Length)));
        }

        // public static int Mxdiflg(string[] a1, string[] a2)
        // {
        //     if (a1.Length <= 0 || a2.Length <= 0)
        //         return -1;
        //     var first = Math.Abs(a1.Max(x => x.Length) - a2.Min(x => x.Length));
        //     var second = Math.Abs(a2.Max(x => x.Length) - a1.Min(x => x.Length));
        //     return Math.Max(first, second);
        // }

        // public static int Mxdiflg(string[] a1, string[] a2)
        // {
        //     return a1.Length == 0 | a2.Length == 0
        //         ? -1
        //         : Math.Max(a1.Max(x => x.Length) - a2.Min(x => x.Length),
        //             a2.Max(x => x.Length) - a1.Min(x => x.Length));
        // }

        // public static int Mxdiflg(string[] a1, string[] a2)
        // {
        //     return a1
        //         .SelectMany(_ => a2, (s1, s2) => Math.Abs(s1.Length - s2.Length))
        //         .DefaultIfEmpty(-1)
        //         .Max();
        // }


        // public static int Mxdiflg(string[] a1, string[] a2)
        // {
        //     return !a1.Any() || !a2.Any()
        //         ? -1
        //         : Math.Max(Math.Abs(a1.Min(s => s.Length) - a2.Max(s => s.Length)),
        //             Math.Abs(a1.Max(s => s.Length) - a2.Min(s => s.Length)));
        // }


        // public static int Mxdiflg(string[] a1, string[] a2)
        // {
        //     if (a1.Length == 0 || a2.Length == 0) return -1;
        //     return a1.Max(str1 => a2.Max(str2 => Math.Abs(str2.Length - str1.Length)));
        // }
    }
}