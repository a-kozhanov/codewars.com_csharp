/*
https://www.codewars.com/kata/5514e5b77e6b2f38e0000ca9/csharp

6 kyu
+1 Array

Given an array of integers of any length, return an array that has 1 added to the value represented by the array.

the array can't be empty
only non-negative, single digit integers are allowed
Return nil (or your language's equivalent) for invalid inputs.

Examples
For example the array [2, 3, 9] equals 239, adding one would return the array [2, 4, 0].

[4, 3, 2, 5] would return [4, 3, 2, 6]
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace CodeWars
{
    public class Plus1Array
    {
        public static int[] UpArray(int[] num)
        {
            if (num.Length == 0 || num.Any(x => x < 0 || x > 9)) return null;
            for (var i = num.Length - 1; i >= 0; i--)
            {
                if (num[i] != 9)
                {
                    num[i]++;
                    return num;
                }

                num[i] = 0;
            }

            return new[] {1}.Concat(num).ToArray();
        }
    }
}