/*
https://www.codewars.com/kata/beginner-series-number-3-sum-of-numbers/train/csharp
https://www.codewars.com/kata/55f2b110f61eb01779000053/solutions/csharp

7 kyu
Beginner Series #3 Sum of Numbers

Given two integers a and b, which can be positive or negative, find the sum of all the numbers between including them too and return it. If the two numbers are equal return a or b.

Note: a and b are not ordered!

Examples
GetSum(1, 0) == 1   // 1 + 0 = 1
GetSum(1, 2) == 3   // 1 + 2 = 3
GetSum(0, 1) == 1   // 0 + 1 = 1
GetSum(1, 1) == 1   // 1 Since both are same
GetSum(-1, 0) == -1 // -1 + 0 = -1
GetSum(-1, 2) == 2  // -1 + 0 + 1 + 2 = 2
*/


using System;
using System.Linq;

namespace CodeWars
{
    public class BeginnerSeries3SumOfNumbers
    {
        public int GetSum(int a, int b)
        {
            var result = 0;
            for (var i = Math.Min(a, b); i <= Math.Max(a, b); i++)
            {
                result += i;
            }
            return result;
        }
        
        // public int GetSum(int a, int b)
        // {
        //     return (a + b) * (Math.Abs(a - b) + 1) / 2;
        // }
        //
        // public int GetSum(int a, int b)
        // {
        //     return Enumerable.Range(Math.Min(a,b), Math.Max(b,a)-Math.Min(b,a)+1).Sum();
        // }
        //
        // public int GetSum(int a, int b)
        // {
        //     return Enumerable.Range(a < b ? a : b, Abs(a - b) + 1).Sum();
        // }
        //
        // public int GetSum(int a, int b)
        // {
        //     return Enumerable.Range(Math.Min(a, b), Math.Abs(b - a) + 1).Sum();
        // }
        
    }
}