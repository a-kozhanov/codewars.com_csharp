/*
https://www.codewars.com/kata/560d6ebe7a8c737c52000084/csharp

7 kyu
Invisible cubes

Imagine there's a big cube consisting of n^3 small cubes. Calculate, how many small cubes are not visible from outside.

For example, if we have a cube which has 4 cubes in a row, then the function should return 8, 
because there are 8 cubes inside our cube (2 cubes in each dimension)
*/

using System;

namespace CodeWars
{
    public class InvisibleCubes
    {
        public static int NotVisibleCubes(int n)
        {
            return (int) (n < 2 ? 0 : Math.Pow(n - 2, 3));
            // return (int) Math.Pow(Math.Max(0, n - 2), 3);
            // return n > 1 ? (n - 2) * (n - 2) * (n - 2) : 0;
            // return n < 3 ? 0 : (int) Math.Pow(n - 2, 3);
            // return n <= 1 ? 0 : (int) Math.Pow(n - 2, 3);
            // return n < 2 ? 0 : (int) Math.Pow(n - 2, 3);
        }
    }
}