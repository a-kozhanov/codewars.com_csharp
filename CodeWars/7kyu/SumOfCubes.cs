/*
https://www.codewars.com/kata/59a8570b570190d313000037/csharp

7 kyu
Sum of Cubes

Write a function that takes a positive integer n, sums all the cubed values from 1 to n, and returns that sum.

Assume that the input n will always be a positive integer.

Examples:

sumCubes(2) // 9
// sum of the cubes of 1 and 2 is 1 + 8
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class SumOfCubes
    {
        public static long SumCubes(int n)
        {
            //return (long) Enumerable.Range(1, n).Select(x => Math.Pow(x, 3)).Sum();
            //return (long) Enumerable.Range(1, n).Sum(x => Math.Pow(x, 3));
            //return Enumerable.Range(1, n).Sum(x => (long) x * x * x);
            //return (long) Math.Pow((n * n + n) / 2, 2);
            return (long) Math.Pow(n * (n + 1) / 2, 2);
        }
    }
}