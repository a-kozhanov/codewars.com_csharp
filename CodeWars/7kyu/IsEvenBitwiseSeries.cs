/*
https://www.codewars.com/kata/592a33e549fe9840a8000ba1/csharp

7 kyu
isEven? - Bitwise Series

Is the number even?
If the numbers is even return true. If it's odd, return false.

Oh yeah... the following symbols/commands have been disabled!

use of ```%```
use of ```.even?``` in Ruby
use of ```mod``` in Python
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class IsEvenBitwiseSeries
    {
        public static bool IsEven(int n)
        {
            //Math.DivRem(n, 2, out var result);
            //return result == 0;

            //return Math.IEEERemainder(n, 2) == 0;
            //return ((double) n / 2).Equals(n / 2);
            //return Convert.ToString(n, 2).Last() == '0';
            //return (n >> 1) << 1 == n;
            //return n / 2 * 2 == n;
            //return (n & 0x1) == 0;
            return (n & 1) == 0;
        }
    }
}