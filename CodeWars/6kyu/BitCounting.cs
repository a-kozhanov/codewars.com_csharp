/*
https://www.codewars.com/kata/526571aae218b8ee490006f4/csharp

6 kyu
Bit Counting

Write a function that takes an integer as input, and returns the number of bits that are equal to one in the binary representation of that number. 
You can guarantee that input is non-negative.

Example: The binary representation of 1234 is 10011010010, so the function should return 5 in this case
*/

using System;
using System.Collections;
using System.Linq;
using System.Numerics;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class BitCounting
    {
        public static int CountBits(int n)
        {
            //return Regex.Replace(Convert.ToString(n, 2), @"[^1]+", "").Count();
            //return Convert.ToString(n, 2).Sum(x => int.Parse(x.ToString()));
            //return Regex.Replace(Convert.ToString(n, 2), "0", "").Length;
            //return new BitArray(new[] {n}).Cast<bool>().Count(i => i);
            //return Convert.ToString(n, 2).Replace("0", "").Length;
            //return Convert.ToString(n, 2).Split('1').Length - 1;
            //return Convert.ToString(n, 2).Count(x => x == '1');
            //return Convert.ToString(n, 2).Count('1'.Equals);
            //return n == 0 ? 0 : 1 + CountBits(n & (n - 1));
            //return BitOperations.PopCount((uint) n);
            return BitOperations.PopCount((uint) n);
        }
    }
}