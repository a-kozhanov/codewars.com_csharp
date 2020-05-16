/*
https://www.codewars.com/kata/59c6fa6972851e8959000067/csharp

7 kyu
zero-balanced Array

An array is called zero-balanced if its elements sum to 0 and for each positive element n, 
there exists another element that is the negative of n. 
Write a function named ìsZeroBalanced that returns true if its argument is zero-balanced array, else return false. 
Note that an empty array will not sum to zero.
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class ZeroBalancedArray
    {
        public static bool IsZeroBalanced(List<int> xs)
        {
            return xs.Any() && xs.Sum() == 0 && xs.All(i => xs.Contains(-i));


            //return xs.Count > 0 && xs.All(x => xs.Contains(-x)) && xs.Sum() == 0;
            //return xs.Any() && xs.Sum() == 0 && xs.All(e => xs.Contains(-e));
            //return xs.Count > 0 && xs.Sum() == 0 && xs.All(x => xs.Contains(x * -1));

            //return xs.Count > 0 && xs.Sum() == 0 && xs.All(v => xs.Contains(v * -1));
        }
    }
}