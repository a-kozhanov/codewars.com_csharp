/*
https://www.codewars.com/kata/55d1d6d5955ec6365400006d/train/csharp

7 kyu
Round to the next multiple of 5.

Given an integer as input, can you round it to the next (meaning, "higher") 5?

Examples:

input:    output:
0    ->   0
2    ->   5
3    ->   5
12   ->   15
21   ->   25
30   ->   30
-2   ->   0
-5   ->   -5
etc.
Input may be any positive or negative integer (including 0).

You can assume that all inputs are valid integers.
*/


using System;

namespace CodeWars
{
    public class RoundToNextMultipleOf5
    {
        public static int RoundToNext5(int n)
        {
            //return (int) Math.Round(Math.Ceiling(n / 5.0)) * 5;
            //return (int) Math.Ceiling((double) n / 5d) * 5;
            //return n / 5 * 5 + (n % 5 > 0 ? 5 : 0);
            //return n + (5 + (5 - n) % 5) % 5;

            // while (n % 5 != 0)
            // {
            //     n++;
            // }
            //
            // return n;

            // while (true)
            // {
            //     if (n % 5 != 0)
            //         n += 1;
            //     else
            //         return n;
            // }

            // return (n % 5 == 0)
            //     ? n
            //     : RoundToNext5(n + 1);

            return n + (5 - n % 5) % 5;
        }
    }
}