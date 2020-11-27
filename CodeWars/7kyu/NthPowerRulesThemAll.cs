/*
https://www.codewars.com/kata/58aed2cafab8faca1d000e20/csharp

7 kyu
Nth power rules them all!

You are provided with an array of positive integers and an additional integer n (n > 1).
Calculate the sum of each value in the array to the nth power. Then subtract the sum of the original array.

Examples
{1, 2, 3}, 3  -->  (1^3 + 2^3 + 3^3 ) - (1 + 2 + 3)  -->  36 - 6  -->  30
{1, 2}, 5     -->  (1^5 + 2^5) - (1 + 2)             -->  33 - 3  -->  30
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class NthPowerRulesThemAll
    {
        public static int ModifiedSum(int[] a, int n)
        {
            //return a.Aggregate(0, (acc, curr) => (int) Math.Pow(curr, n) + acc - curr);
            //return (int) a.Select(x => Math.Pow(x, n)).Sum() - a.Sum();
            return (int) a.Sum(x => Math.Pow(x, n) - x);
        }
    }
}