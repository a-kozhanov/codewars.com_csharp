/*
https://www.codewars.com/kata/567e8dbb9b6f4da558000030/train/csharp
https://www.codewars.com/kata/567e8dbb9b6f4da558000030/solutions/csharp

7 kyu
Regexp Basics - is it a six bit unsigned number?

Implement String#six_bit_number?, 
which should return true if given object is a number representable by 6 bit unsigned integer (0-63), false otherwise.

It should only accept numbers in canonical representation, so no leading +, extra 0s, spaces etc.
*/

using System;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public static class RegexpBasicsIsItSixBitUnsignedNumber
    {
        public static bool SixBitNumber(this string str)
        {
            return Regex.IsMatch(str, @"^(6[0-3]|[1-5][0-9]|[0-9])\z");
        }

        // public static bool SixBitNumber(this string s) => IsMatch(s, @"^(\d|[1-5]\d|6[0-3])\z");


        // public static bool SixBitNumber(this string str)
        // {
        //     if (Regex.IsMatch(str, @"(^0.+|^-0.+|^.+[\n\r]$)"))
        //     {
        //         return false;
        //     }
        //
        //     bool result = (Regex.IsMatch(str, @"^([0-9]|[1-5][0-9]|6[0-3])$")) ? true : false;
        //     return result;
        // }


        // public static bool SixBitNumber(this string str)
        // {
        //     Console.WriteLine(str);
        //     return Regex.IsMatch(str, @"^([0-9]|[1-5]\d|[6][0-3])\z");
        // }

        // public static bool SixBitNumber(this string str)
        // {
        //     // Your code here
        //     if (!str.Equals(str.Trim()))
        //         return false;
        //     return str != "" && Regex.IsMatch(str, "^(6[0-3]|[1-5][0-9]|[0-9])$");
        // }

        // public static bool SixBitNumber(this string str)
        // {
        //     if (Regex.IsMatch(str, @"^([0-9]|[1-5][0-9]|[1-6][0-3])\z") && !(str.StartsWith("0") && str.Length > 1))
        //         return true;
        //     else
        //         return false;
        // }

        // public static bool SixBitNumber(this string str)
        // {
        //     return Regex.IsMatch(str, @"^(\d|[1-5]\d|6[0-3])\z");
        // }

        // public static bool SixBitNumber(this string str)
        // {
        //     return Regex.IsMatch(str, @"\A(\d|[1-5]\d|6[0-3])\z");
        // }
    }
}