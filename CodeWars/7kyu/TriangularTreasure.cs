/*
https://www.codewars.com/kata/525e5a1cb735154b320002c8/csharp

7 kyu
Triangular Treasure

Triangular numbers are so called because of the equilateral triangular shape that they occupy when laid out as dots. i.e.

1st (1)   2nd (3)    3rd (6)
*          **        ***
           *         **
                     *
You need to return the nth triangular number. You should return 0 for out of range values:

all [
  triangular 0     == 0,
  triangular 2     == 3,
  triangular 3     == 6,
  triangular (-10) == 0
] -- True
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class TriangularTreasure
    {
        public static int Triangular(int n)
        {
            //return n <= 0 ? 0 : n == 1 ? 1 : Triangular(n - 1) + n;
            //return Enumerable.Range(1, Math.Max(n, 0)).Sum();
            //return n > 0 ? Enumerable.Range(1, n).Sum() : 0;
            //return Enumerable.Range(1, n > 0 ? n : 0).Sum();
            //return n < 1 ? 0 : Triangular(n - 1) + n;
            //return n > 0 ? n + Triangular(n - 1) : 0;
            //return n <= 0 ? 0 : n + n * (n - 1) / 2;
            //return n <= 0 ? 0 : n + Triangular(--n);
            //return n < 0 ? 0 : ++n * (n - 1) / 2;
            //return n > 0 ? (n + 1) * n / 2 : 0;
            //return n < 0 ? 0 : (n * n + n) / 2;
            //return n > 0 ? n * (n + 1) / 2 : 0;
            //return n < 0 ? 0 : n * (n + 1) / 2;
            //return n < 0 ? 0 : ++n * --n / 2;
            return n > 0 ? n * ++n / 2 : 0;
        }
    }
}