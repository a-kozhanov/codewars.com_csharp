/*
https://www.codewars.com/kata/57cc981a58da9e302a000214/csharp

7 kyu
Small enough? - Beginner

You will be given an array and a limit value. 
You must check that all values in the array are below or equal to the limit value. 
If they are, return true. Else, return false.

You can assume all values in the array are numbers.
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class SmallEnoughBeginner
    {
        public static bool SmallEnough(int[] a, int limit)
        {
            //return a.Count(x => x <= limit) == a.Length;
            //return Array.TrueForAll(a, x => x <= limit);
            //return a.Count(x => x > limit) == 0;
            //return !a.Any(x => x > limit);
            //return a.All(x => x <= limit);
            return limit >= a.Max();
        }
    }
}