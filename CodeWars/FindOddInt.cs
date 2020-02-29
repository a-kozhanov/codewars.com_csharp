/*
https://www.codewars.com/kata/54da5a58ea159efa38000836/train/csharp
https://www.codewars.com/kata/54da5a58ea159efa38000836/solutions/csharp

6 kyu
Find the odd int

Given an array, find the integer that appears an odd number of times.
There will always be only one integer that appears an odd number of times.
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class FindOddInt
    {
        public static int find_it(int[] seq)
        {
            //return seq.First(x => seq.Count(c => c == x) == 3);
            return seq.Aggregate((a, b) => a ^ b);
        }


        // public static int find_it(int[] seq)
        // {
        //     return seq.GroupBy(x => x).Single(g => g.Count() % 2 == 1).Key;
        // }


        // public static int find_it(int[] seq)
        // {
        //     return seq.First(x => seq.Count(s => s == x) % 2 == 1);
        // }
    }
}