/*
https://www.codewars.com/kata/567e8f7b4096f2b4b1000005/train/csharp
https://www.codewars.com/kata/567e8f7b4096f2b4b1000005/solutions/csharp

7 kyu
Regexp Basics - is it a eight bit unsigned number?

Implement String#eight_bit_number?, which should return true if given object is a number representable by 8 bit unsigned integer (0-255), false otherwise.
It should only accept numbers in canonical representation, so no leading +, extra 0s, spaces etc.
*/

using System;
using System.Text.RegularExpressions;
using static System.Text.RegularExpressions.Regex;

namespace CodeWars
{
    public static class RegexpBasicsIsItEightBitUnsignedNumber
    {
        public static bool EightBitNumber(this string s)
        {
            return byte.TryParse(s, out var n) && s.Length == $"{n}".Length;
        }

        // public static bool EightBitNumber(this string str) => Regex.IsMatch(str, @"^([0-9]|[1-9]\d|1\d\d|2[0-4]\d|25[0-5])\z");

        // public static bool EightBitNumber(this string s) => IsMatch(s, @"^(\d|[1-9]\d|1\d{2}|2([0-4]\d|5[0-5]))\z");

        // public static bool EightBitNumber(this string str)
        // {
        //     if (!str.Trim().Equals(str))
        //         return false;
        //     return str != "" && Regex.IsMatch(str, "^(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])$");
        // }

        // public static bool EightBitNumber(this string str) => byte.TryParse(str, 0, null, out byte k) && (str[0] != '0' || str.Length == 1);


        // public static bool EightBitNumber(this string str)
        // {
        //     if (str.Length > 1 && str.StartsWith("0"))
        //         return false;
        //
        //     foreach (char c in str)
        //         if (!Char.IsDigit(c))
        //             return false;
        //
        //     int num = 0;
        //     if (int.TryParse(str, out num))
        //         if (0 <= num && num <= 255)
        //             return true;
        //
        //     return false;
        // }


    }
}