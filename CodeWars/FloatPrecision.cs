/*
https://www.codewars.com/kata/float-precision/train/csharp
https://www.codewars.com/kata/5143d157ceb46d6a61000001/solutions/csharp

7 kyu
Float Precision

Update the solution method to round the argument value to the closest precision of two. 
The argument will always be a float.

Kata.Round(23.23456) => 23.23
Kata.Round(1.546) => 1.55
*/

using System;

namespace CodeWars
{
    public class FloatPrecision
    {
        public static double Round(double n)
        {
            return Math.Round(n, 2);
        }

        // return Math.Round(n * 100) / 100D;

        // public static double Round(double n)
        // {
        //     return ((int)(Math.Round(n*100)))/100.0;
        // }


        // public static double Round(double n)
        // {
        //     string s = String.Format("{0:0.##}", n);
        //
        //     return Convert.ToDouble(s);
        // }

        // public static double Round(double n)
        // {
        //     return Convert.ToDouble(n.ToString("0.##"));
        // }

        // public static double Round(double n) => Math.Round(n, 2, MidpointRounding.AwayFromZero);
    }
}