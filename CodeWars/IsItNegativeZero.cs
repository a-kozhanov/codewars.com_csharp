/*
https://www.codewars.com/kata/5c5086287bc6600001c7589a/train/csharp
https://www.codewars.com/kata/5c5086287bc6600001c7589a/solutions/csharp

7 kyu
Is It Negative Zero (-0)?

There exist two zeroes: +0 (or just 0) and -0.
Write a function that returns true if the input number is -0 and false otherwise (True and False for Python).
In JavaScript / TypeScript / Coffeescript the input will be a number.
In Python / Java / C / NASM / Haskell / the input will be a float.
*/

using System;

namespace CodeWars
{
    public class IsItNegativeZero
    {
        public static bool IsNegativeZero(double n)
        {
            //return BitConverter.DoubleToInt64Bits(n) == BitConverter.DoubleToInt64Bits(-0.0);
            //return double.IsNegativeInfinity(1.0 / n);
            //return 1 / n == Double.NegativeInfinity;
            //return double.IsNegativeInfinity(1 / n);
            //return double.NegativeInfinity == 1 / n;
            //return double.IsNegative(n) && n == 0;
            //return 1 / n < 0 && n == 0;
            //return n == 0 && 1 / n < 0;     
            //return 1 / n == 1 / -0.0;

            return n == 0 & 1 / n < 0;
        }
    }
}