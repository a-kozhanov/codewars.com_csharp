/*
https://www.codewars.com/kata/558f9f51e85b46e9fa000025/csharp

7 kyu
Difference Of Squares

Recreation of Project Euler problem #6

Find the difference between the sum of the squares of the first n natural numbers (1 <= n <= 100) and the square of their sum.

Example
For example, when n = 10:

The square of the sum of the numbers is:

(1 + 2 + 3 + 4 + 5 + 6 + 7 + 8 + 9 + 10)2 = 552 = 3025

The sum of the squares of the numbers is:

12 + 22 + 32 + 42 + 52 + 62 + 72 + 82 + 92 + 102 = 385

Hence the difference between square of the sum of the first ten natural numbers and the sum of the squares of those numbes is: 3025 - 385 = 2640
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class KataDifferenceOfSquares
    {
        public static int DifferenceOfSquares(int n)
        {
            return n * (n + 1) * (3 * n * n - n - 2) / 12;
            //return ((n - 1) * n * (n + 1) * (3 * n + 2)) / 12;
            //return n * n * (n + 1) * (n + 1) / 4 - n * (n + 1) * (2 * n + 1) / 6;
            //return (int) Math.Pow(n * (n + 1) / 2, 2) - n * (n + 1) * (2 * n + 1) / 6;
            //return (int) Math.Pow(n * (n + 1) / 2, 2) - n * (n + 1) * (2 * n + 1) / 6;
            //return (n * (n + 1) / 2) * (n * (n + 1) / 2) - (2 * n + 1) * (n + 1) * n / 6;
            //return (int) Math.Pow(Enumerable.Range(1, n).Sum(), 2) - Enumerable.Range(1, n).Sum(i => i * i);
            //return (int) Math.Abs(Math.Pow(Enumerable.Range(1, n).Sum(), 2) - Enumerable.Range(1, n).Select(x => x * x).Sum());

            // int a = 0;
            // int b = 0;
            // for (int i = 1; i <= n; i++)
            // {
            //     a += i;
            //     b += i * i;
            // }
            // return a * a - b;
        }
    }
}