/*
https://www.codewars.com/kata/56a5d994ac971f1ac500003e/csharp

6 kyu
Consecutive strings

You are given an array(list) strarr of strings and an integer k. Your task is to return the first longest string consisting of k consecutive strings taken in the array.

Example:
longest_consec(["zone", "abigail", "theta", "form", "libe", "zas", "theta", "abigail"], 2) --> "abigailtheta"

n being the length of the string array, if n = 0 or k > n or k <= 0 return "".

Note
consecutive strings : follow one after another without an interruption
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class ConsecutiveStrings
    {
        public static String LongestConsec(string[] strarr, int k)
        {
            return k > strarr.Length
                ? ""
                : Enumerable.Range(0, strarr.Length - k + 1).Select(i => string.Concat(strarr.Skip(i).Take(k)))
                    .OrderBy(x => -x.Length).First();


            // return k > strarr.Length
            //     ? ""
            //     : Enumerable.Range(0, strarr.Length - k + 1 > 0 ? strarr.Length - k + 1 : 0)
            //         .Select(i => string.Concat(strarr.Skip(i).Take(k)))
            //         .OrderBy(x => -x.Length).First();


            // var count = strarr.Length - k + 1;
            // return Enumerable.Range(0, count > 0 ? count : 0)
            //     .Select(i => string.Join("", strarr.Skip(i).Take(k)))
            //     .Aggregate(string.Empty, (max, current) => current.Length > max.Length ? current : max);


            // return !strarr.Any() || k < 1 || k > strarr.Length
            //     ? ""
            //     : strarr.Take(strarr.Length - k + 1).Select((x, i) => x + string.Concat(strarr.Skip(i + 1).Take(k - 1)))
            //         .OrderByDescending(x => x.Length).First();


            // var count = strarr.Length - k + 1;
            // return Enumerable.Range(0, count > 0 ? count : 0)
            //     .Select(i => string.Concat(strarr.Skip(i).Take(k)))
            //     .Aggregate("", (max, current) => current.Length > max.Length ? current : max);

            // return k > strarr.Length
            //     ? ""
            //     : Enumerable.Range(0, strarr.Length - k + 1).Select(i => string.Concat(strarr.Skip(i).Take(k)))
            //         .OrderBy(x => -x.Length).DefaultIfEmpty(" ").FirstOrDefault() ?? "";


            // return !strarr.Any() || k <= 0 || k > strarr.Length
            //     ? string.Empty
            //     : strarr.Take(strarr.Length - k + 1).Select((x, i) => x + string.Concat(strarr.Skip(i + 1).Take(k - 1)))
            //         .OrderByDescending(x => x.Length).First();


            // return strarr.Length == 0 || k > strarr.Length || k <= 0
            //     ? String.Empty
            //     : String.Join(String.Empty,
            //         Enumerable.Range(0, strarr.Length - k + 1)
            //             .Select(i => strarr.Skip(i).Take(k))
            //             .OrderByDescending(chunk => chunk.Sum(s => s.Length))
            //             .First()
            //     );


            // int n = strarr.Length;
            // return (n == 0 || k > n || k <= 0)
            //     ? ""
            //     : strarr.Select((x, index) => (k + index <= n) ? string.Join("", strarr.Skip(index).Take(k)) : "")
            //         .OrderByDescending(x => x.Length).First();


            // var count = strarr.Length - k + 1;
            // return Enumerable.Range(0, count > 0 ? count : 0)
            //     .Select(i => string.Join("", strarr.Skip(i).Take(k)))
            //     .Aggregate(string.Empty, (max, current) => current.Length > max.Length ? current : max);


            // return s.Length == 0 || s.Length < k || k <= 0
            //     ? ""
            //     : Enumerable.Range(0, s.Length - k + 1)
            //         .Select(x => string.Join("", s.Skip(x).Take(k)))
            //         .OrderByDescending(x => x.Length)
            //         .First();
        }
    }
}