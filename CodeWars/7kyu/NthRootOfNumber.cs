/*
https://www.codewars.com/kata/5520714decb43308ea000083/csharp

7 kyu
Nth Root of a Number

Given two numbers x and n, calculate the (positive) nth root of x.

This means that being r = result, r^n = x.

Examples
Input: x=4, n=2, output: 2. The square root of 4 is 2, 2^2 = 4
Input: x=8, n=3, output: 2. The cube root of 8 is 2 , 2^3 = 8
Input: x=256, n=4, output: 4. The 4th root of 256 is 4 , 4^4 = 256
Input: x=9, n=2, output: 3. The square root of 9 is 3 , 3^2 = 9
Input: x=6.25, n=2, output: 2.5. The square root of 6.25 is 2.5 , 2.5^2 = 6.25
Notes:
Expect x greater than 1 × 10^19
n will always be a positive integer.
Good luck!
*/

using System;

namespace CodeWars
{
    public class NthRootOfNumber
    {
        public static double FindRoot(double x, int n)
        {
            return Math.Pow(x, 1d / n);
        }
    }
}