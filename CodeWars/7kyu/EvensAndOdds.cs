/*
https://www.codewars.com/kata/583ade15666df5a64e000058/csharp

7 kyu
Evens and Odds

This kata is about converting numbers to their binary or hexadecimal representation:

If a number is even, convert it to binary.
If a number is odd, convert it to hex.
*/

using System;

namespace CodeWars
{
    public class KataEvensAndOdds
    {
        public static string EvensAndOdds(int num)
        {
            //return num % 2 == 0 ? Convert.ToString(num, 2) : Convert.ToString(num, 16);
            //return num % 2 == 0 ? Convert.ToString(num, 2) : num.ToString("x");
            //return num % 2 == 0 ? Convert.ToString(num, 2) : $"{num:x}";
            //return Convert.ToString(num, (num & 1) == 1 ? 16 : 2);
            return Convert.ToString(num, num % 2 == 0 ? 2 : 16);
        }
    }
}