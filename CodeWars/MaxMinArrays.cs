/*
https://www.codewars.com/kata/5a090c4e697598d0b9000004/train/csharp

7 kyu
Max-min arrays

In this Kata, you will be given an array of unique elements, 
and your task is to rerrange the values so that the first max value is followed by the first minimum, 
followed by second max value then second min value, etc.

For example:
Kata.Solve(new List<int> {15,11,10,7,12}) => new List<int> {15,7,12,10,11}
The first max is 15 and the first min is 7. The second max is 12 and the second min is 10 and so on.

More examples in the test cases.

Good luck!
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class MaxMinArrays
    {
        public static List<int> Solve(List<int> arr)
        {
            // var arr2 = new List<int>();
            // var result = new List<int>();
            //
            // for (var i = 0; i < arr.Count / 2 + 1; i++)
            // {
            //     arr2 = arr.Except(result).ToList();
            //     if (arr2.Count == 0) break;
            //     var temp = new List<int> {arr2.Max(), arr2.Min()};
            //     result.AddRange(temp.Distinct());
            // }

            // return result;

            // return Enumerable.Range(0, arr.Count).Select(n =>
            //         n % 2 == 0
            //             ? arr.OrderByDescending(x => x).Skip(n / 2).First()
            //             : arr.OrderBy(x => x).Skip(n / 2).First())
            //     .ToList();


            return Enumerable.Range(0, arr.Count).Select(i =>
                i % 2 == 0
                    ? arr.OrderByDescending(x => x).Skip(i / 2).First()
                    : arr.OrderBy(x => x).Skip(i / 2).First()).ToList();


            //var str = string.Join(",", arr.OrderByDescending(x => x).Zip(arr.OrderBy(x => x), (x, y) => $"{x},{y}"));
            //return str.Substring(0, str.Length / 2).Split(',').Select(x => Convert.ToInt32(x)).ToList();
        }
    }
}