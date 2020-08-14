/*
https://www.codewars.com/kata/56606694ec01347ce800001b/csharp

7 kyu
Is this a triangle?

Implement a method that accepts 3 integer values a, b, c. 
The method should return true if a triangle can be built with the sides of given length and false in any other case.

(In this case, all triangles must have surface greater than 0 to be accepted).

More info:
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class IsthisTriangle
    {
        public static bool IsTriangle(int a, int b, int c)
            //public static bool IsTriangle(params int[] sides)
        {
            return a + b > c && b + c > a && a + c > b;

            // var longest = sides.Max();
            // return sides.Sum() - longest > longest;
        }
    }
}