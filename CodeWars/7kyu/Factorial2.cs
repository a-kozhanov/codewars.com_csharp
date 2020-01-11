/*
https://www.codewars.com/kata/54ff0d1f355cfd20e60001fc/train/csharp
https://www.codewars.com/kata/54ff0d1f355cfd20e60001fc/solutions/csharp

7 kyu
Factorial

In mathematics, the factorial of a non-negative integer n, denoted by n!, 
is the product of all positive integers less than or equal to n. 
For example: 5! = 5 * 4 * 3 * 2 * 1 = 120. By convention the value of 0! is 1.

Write a function to calculate factorial for a given input. 
If input is below 0 or above 12 throw an exception of type ArgumentOutOfRangeException (C#) or 
IllegalArgumentException (Java) or RangeException (PHP) or throw a RangeError (JavaScript) 
or ValueError (Python) or return -1 (C).

More details about factorial can be found here.
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class Factorial2
    {
        public static int Factorial(int n)
        {
            return n < 0 || n > 12 ? throw new ArgumentOutOfRangeException() : n > 0 ? n * Factorial(n - 1) : 1;
        }

        // public static int Factorial(int n)
        // {
        //     if (n < 0 || n > 12)
        //         throw new ArgumentOutOfRangeException();
        //     return n > 0 ? n * Factorial(n - 1) : 1;
        // }

        // public static int Factorial(int n)
        // {
        //     if (n < 0 || n > 12) throw new ArgumentOutOfRangeException();
        //
        //     return Enumerable.Range(1, n).Aggregate(1, (x, y) => x * y);
        // }


        // public static int Factorial(int n)
        // {
        //     if (n < 0 || n > 12)
        //     {
        //         throw new ArgumentOutOfRangeException();
        //     }
        //
        //     int result = 1;
        //     for (int i = 1; i <= n; i++)
        //     {
        //         result *= i;
        //     }
        //
        //     return result;
        // }

        // public static int Factorial(int n)
        // {
        //     if (n < 0 || n > 12) throw new ArgumentOutOfRangeException();
        //     if (n == 0) return 1;
        //     return n * Factorial(n - 1);
        // }


        // public static int Factorial(int n)
        // {
        //     if (n > 12 || n < 0) throw new ArgumentOutOfRangeException();
        //     return n <= 1 ? 1 : n * Factorial(n - 1);
        // }


        // public static int Factorial(int n)
        // {
        //     if (n < 0 || n > 12)
        //         throw new ArgumentOutOfRangeException();
        //     return n <= 1 ? 1 : n * Factorial(--n);
        // }
    }
}