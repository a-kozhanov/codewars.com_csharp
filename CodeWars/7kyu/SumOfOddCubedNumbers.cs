/*
https://www.codewars.com/kata/580dda86c40fa6c45f00028a/csharp

7 kyu
Sum of Odd Cubed Numbers

Find the sum of the odd numbers within an array, after cubing the initial integers. 
The function should return undefined/None/nil/NULL if any of the values aren't numbers.

Note: There are ONLY integers in the JAVA and C# versions of this Kata.
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class SumOfOddCubedNumbers
    {
        public static int CubeOdd(int[] arr)
        {
            //return arr.Aggregate(0, (a, b) => a + (b % 2 != 0 ? b * b * b : 0));
            //return (int) arr.Where(i => i % 2 != 0).Sum(i => Math.Pow(i, 3));
            //return arr.Sum(i => (i & 1) == 1 ? (int) Math.Pow(i, 3) : 0);
            //return arr.Where(i => i % 2 != 0).Sum(i => i * i * i);
            //return arr.Sum(i => (i & 1) == 1 ? i * i * i : 0);
            return arr.Sum(i => i % 2 == 0 ? 0 : i * i * i);
        }
    }
}