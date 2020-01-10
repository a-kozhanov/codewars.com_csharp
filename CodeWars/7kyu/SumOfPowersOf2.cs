/*
https://www.codewars.com/kata/sum-of-powers-of-2/train/csharp
https://www.codewars.com/kata/sum-of-powers-of-2/solutions/csharp

7 kyu
Sum of powers of 2

Description
Given a number n, you should find a set of numbers for which the sum equals n. 
This set must consist exclusively of values that are a power of 2 (eg: 2^0 => 1, 2^1 => 2, 2^2 => 4, ...).

The function powers takes a single parameter, the number n, and should return an array of unique numbers.

Criteria
The function will always receive a valid input: 
any positive integer between 1 and the max integer value for your language 
(eg: for JavaScript this would be 9007199254740991 otherwise known as Number.MAX_SAFE_INTEGER).

The function should return an array of numbers that are a power of 2 (2^x = y).

Each member of the returned array should be unique. (eg: the valid answer for powers(2) is [2], not [1, 1])

Members should be sorted in ascending order (small -> large). (eg: the valid answer for powers(6) is [2, 4], not [4, 2])
*/


using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class SumOfPowersOf2
    {
        public static int[] Powers(int n)
        {
            return Enumerable.Range(0, 31).Select(x => 1 << x).Where(b => (b & n) == b).ToArray();
        }

        // public static int[] Powers(int n) => Enumerable.Range(0,31).Select(x => 1 << x).Where(b => (b & n) == b).ToArray();


        // public static int[] Powers(int n)
        // {
        //     List<int> baza = new List<int>();
        //     while(n > 0)
        //     {
        //         long temp = 1;
        //         while(temp <= n) temp *= 2;
        //         if(temp > 1) temp /= 2;
        //         baza.Insert(0, (int)temp);
        //         n -= (int)temp;
        //     }
        //     return baza.ToArray();
        // }


        // public static int[] Powers(int n) {
        //
        //     int[] result = new int[] { };
        //
        //     for (int i = 0; i < 32; i++)
        //     {
        //         int y = 1 << i;
        //         if ((n & y) != 0)
        //         {
        //             Array.Resize(ref result, result.Length + 1);
        //             result[result.Length - 1] = y;
        //         }
        //     }
        //     return result;
        //
        // }


        // public static int[] Powers(int n) {
        //     return Convert.ToString(n, 2).Reverse().Select((x, i) => { return x == '1' ? (int)(Math.Pow(2, i)) : 0; }).Where(x => x > 0).ToArray();
        // }


        // public static int[] Powers(int n)  => Enumerable.Range(0,31).Select(x => 1 << x).Where(b => (b & n) == b).ToArray();
    }
}