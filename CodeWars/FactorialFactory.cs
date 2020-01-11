/*
https://www.codewars.com/kata/528e95af53dcdb40b5000171/train/csharp
https://www.codewars.com/kata/528e95af53dcdb40b5000171/solutions/csharp

7 kyu
Factorial Factory

In mathematics, the factorial of integer 'n' is written as 'n!'. 
It is equal to the product of n and every integer preceding it. For example: 5! = 1 x 2 x 3 x 4 x 5 = 120
Your mission is simple: write a function that takes an integer 'n' and returns 'n!'.
You are guaranteed an integer argument. For any values outside the positive range, return null, nil or None .
Note: 0! is always equal to 1. Negative values should return null;
For more on Factorials : http://en.wikipedia.org/wiki/Factorial
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class FactorialFactory
    {
        public static int Factorial(int n)
        {
            return n < 0 ? throw new Exception() : n == 0 ? 1 : n * Factorial(--n);
        }


        // public static int Factorial(int n)
        // {
        //     if (n < 0)
        //         throw new ArgumentException("Input should be positive!", "n");
        //     return (n == 0) ? 1 : n * Factorial(n - 1);
        // }


        // public static int Factorial(int n) => Enumerable.Range(1, n).Aggregate(1, (x, y) => x * y);


        // public static int Factorial(int n, int x = 1)
        // {
        //     if (x < 0) throw new Exception();
        //     return n == 0 ? x : Factorial(n - 1, n * x);
        // }


        // public static int Factorial(int n)
        // {
        //     if (n < 0) throw (new ArgumentException());
        //     return n <= 1 ? 1 : n * Factorial(n - 1);
        // }


        // public static int Factorial(int n)
        // {
        //     return Enumerable.Range(1, n).Aggregate(1, (a, b) => a * b);
        // }


        // public static int Factorial(int n)
        // {
        //     if (n == 0)
        //         return 1;
        //
        //     if (n > 0)
        //     {
        //         int res = 1;
        //         for (int i = 1; i <= n; i++)
        //             res *= i;
        //         return res;
        //     }
        //     else
        //         throw new IndexOutOfRangeException();
        // }
    }
}