/*
https://www.codewars.com/kata/585b1fafe08bae9988000314/csharp

7 kyu
Digits explosion

Given a string made of digits [0-9], return a string where each digit is repeated a number of times equals to its value.

Examples
Digits.Explode("312") = "333122"
Digits.Explode("102269") = "12222666666999999999"
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class DigitsExplosion
    {
        public static string Explode(string s)
        {
            //return new string(s.SelectMany(d => Enumerable.Repeat(d, int.Parse(d.ToString()))).ToArray());
            //return string.Concat(s.Select(l => new string(l, (int) char.GetNumericValue(l))));
            //return string.Concat(s.Select(x => new string(x, int.Parse($"{x}"))));
            //return string.Concat(s.Select(n => new string(n, n - '0')));
            return string.Concat(s.Select(n => new string(n, n - 48)));
        }
    }
}