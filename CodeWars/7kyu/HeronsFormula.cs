/*
https://www.codewars.com/kata/57aa218e72292d98d500240f/csharp

7 kyu
Heron's formula

Write function heron which calculates the area of a triangle with sides a, b, and c.

Heron's formula: sqrt (s * (s - a) * (s - b) * (s - c)), where s = (a + b + c) / 2. Output should have 2 digits precision.
*/

using System;

namespace CodeWars
{
    public class HeronsFormula
    {
        public static double heron(double a, double b, double c)
        {
            var s = (a + b + c) / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            // return Math.Sqrt(4 * a * a * b * b - Math.Pow(a * a + b * b - c * c, 2)) / 4;
        }
    }
}