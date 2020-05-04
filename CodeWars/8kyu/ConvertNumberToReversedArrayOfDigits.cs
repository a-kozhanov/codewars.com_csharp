/*
https://www.codewars.com/kata/5583090cbe83f4fd8c000051/train/csharp

8 kyu
Convert number to reversed array of digits

Given a random number:

C#: long;
C++: unsigned long;
You have to return the digits of this number within an array in reverse order.

Example:
348597 => [7,9,5,8,4,3]
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class ConvertNumberToReversedArrayOfDigits
    {
        public static long[] Digitize(long n)
        {
            //return $"{n}".Select(c => Convert.ToInt64(c - '0')).Reverse().ToArray();
            //return $"{n}".Select(c => long.Parse(c + "")).Reverse().ToArray();
            //return $"{n}".Select(c => long.Parse($"{c}")).Reverse().ToArray();
            //return $"{n}".Select(c => (long) (c - 48)).Reverse().ToArray();
            return $"{n}".Select(c => (long) c - '0').Reverse().ToArray();
        }
    }
}