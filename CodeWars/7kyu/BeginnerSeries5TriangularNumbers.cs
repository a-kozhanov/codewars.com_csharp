/*
https://www.codewars.com/kata/56d0a591c6c8b466ca00118b/csharp

7 kyu
Beginner Series #5 Triangular Numbers

Triangular number is the amount of points that can fill equilateral triangle.

Example: the number 6 is a triangular number because all sides of a triangle has the same amount of points.

alt text

Hint!
T(n) = n * (n + 1) / 2,
n - is the size of one side.
T(n) - is the triangular number.
Given a number 'T' from interval [1; 2147483646], find if it is triangular number or not.

Appreciate the feedback!
*/

using System;

namespace CodeWars
{
    public class BeginnerSeries5TriangularNumbers
    {
        public bool isTriangular(int T)
        {
            return Math.Sqrt(T * 8 + 1) % 1 == 0;
            // return (Math.Sqrt(2 * T + .25) - .5) % 1 == 0;
            // return (Math.Sqrt(8 * T + 1) - 1) / 2 % 1 == 0;
        }
    }
}