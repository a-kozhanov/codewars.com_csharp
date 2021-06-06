/*
https://www.codewars.com/kata/5959ec605595565f5c00002b/csharp

7 kyu
Reverse the bits in an integer

Write a function that reverses the bits in an integer.
For example, the number 417 is 110100001 in binary. Reversing the binary is 100001011 which is 267.
You can assume that the number is not negative.
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class ReverseBitsInAnInteger
    {
        public static long ReverseBits(long n)
        {
            // return Convert.ToInt64(new string(Convert.ToString(n, 2).Reverse().ToArray()), 2);
            return Convert.ToInt64(string.Concat(Convert.ToString(n, 2).Reverse()), 2);
        }
    }
}