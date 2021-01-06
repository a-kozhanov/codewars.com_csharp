/*
https://www.codewars.com/kata/5519e930cd82ff8a9a000216/csharp

7 kyu
Count the Ones

The Hamming weight of a string is the number of symbols that are different from the zero-symbol of the alphabet used. 
There are several algorithms for efficient computing of the Hamming weight for numbers. 
In this Kata, speaking technically, you have to find out the number of '1' bits in a binary representation of a number. Thus,

hamming_weight(10) # 1010  => 2
hamming_weight(21) # 10101 => 3
The interesting part of this task is that you have to do it without string operation (hey, it's not really interesting otherwise)
*/

using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class CountOnes
    {
        public static int HammingWeight(int x)
        {
            // int count = 0;
            // for (var i = 0; i < 32; i++)
            // {
            //     if ((x & (1 << i)) != 0) count++;
            // }
            // return count;

            // int count;
            // for (count = 0; x != 0; count++)
            // {
            //     x &= x - 1;
            // }
            // return count;

            //return Convert.ToString(x, 2).Count(a => a.Equals('1'));
            //return Regex.Replace(Convert.ToString(x, 2), "0", "").Length;
            //return Enumerable.Range(0, 32).Count(i => (x & (1 << i)) != 0);
            //return Convert.ToString(x, 2).Count(c => c == '1');

            return x == 0 ? 0 : 1 + HammingWeight(x & (x - 1));
        }
    }
}