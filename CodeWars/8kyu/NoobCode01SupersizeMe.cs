/*
https://www.codewars.com/kata/noobcode-01-supersize-me-dot-dot-dot-or-rather-this-integer/train/csharp
https://www.codewars.com/kata/noobcode-01-supersize-me-dot-dot-dot-or-rather-this-integer/solutions

8 kyu
noobCode 01: SUPERSIZE ME.... or rather, this integer!

Write a function that rearranges an integer into its largest possible value.

Kata.SuperSize(123456) //654321
Kata.SuperSize(105) // 510
Kata.SuperSize(12) // 21
If the argument passed through is single digit or is already the maximum possible integer, your function should simply return it.

*/



using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class NoobCode01SupersizeMe
    {
        public static long SuperSize(long num)
        {
            return long.Parse(num.ToString().OrderByDescending(x => x).ToArray());
        }


        //public static long SuperSize(long num)
        //{
        //    return Convert.ToInt64(new string(num.ToString().OrderByDescending(n => n).ToArray()));
        //}

        //public static long SuperSize(long num)
        //{
        //    return long.Parse(string.Concat(num.ToString().ToCharArray().OrderByDescending(c => c)));
        //}
    }
}