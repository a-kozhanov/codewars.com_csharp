/*
https://www.codewars.com/kata/5526fc09a1bbd946250002dc/csharp

6 kyu
Find The Parity Outlier

You are given an array (which will have a length of at least 3, but could be very large) containing integers. 
The array is either entirely comprised of odd integers or entirely comprised of even integers except for a single integer N. 
Write a method that takes the array as an argument and returns this "outlier" N.

Examples
[2, 4, 0, 100, 4, 11, 2602, 36]
Should return: 11 (the only odd number)

[160, 3, 1719, 19, 11, 13, -21]
Should return: 160 (the only even number)
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class FindParityOutlier
    {
        public static int Find(int[] integers)
        {
            //return integers.GroupBy(x => x & 1).OrderBy(g => g.Count()).First().Single();
            //return integers.First(z => z % 2 == (integers.Count(x => x % 2 == 0) > 1 ? 1 : 0));
            //return integers.Where(z => (z % 2 == (integers.Where(x => x % 2 == 0).Count() > 1 ? 1 : 0))).First();
            //return integers.Single(a => a % 2 == (integers.Count(b => b % 2 == 0) > 1 ? 1 : 0));
            //return integers.Where(z => integers.Sum(n => n % 2) == 1 ? z % 2 == 1 : z % 2 == 0).ToArray()[0];
            //return new[] {integers.Where(x => x % 2 == 0), integers.Where(x => x % 2 == 1)}.First(x => x.Count() == 1).First();

            //return integers.GroupBy(i => Math.Abs(i) % 2).Where(g => g.Count() == 1).SelectMany(g => g).First();

            //return integers.GroupBy(x => x & 1).First(g => g.Count() == 1).First();
            return integers.GroupBy(x => x & 1).First(x => x.Count() == 1).First();
        }
    }
}