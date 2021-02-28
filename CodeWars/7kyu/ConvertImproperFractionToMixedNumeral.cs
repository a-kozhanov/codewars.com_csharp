/*
https://www.codewars.com/kata/574e4175ff5b0a554a00000b/csharp

7 kyu
Convert Improper Fraction to Mixed Numeral

In Math, an improper fraction is a fraction where the numerator (the top number) is greater than or equal to the denominator (the bottom number) 
For example: 5/3 (five third).

A mixed numeral is a whole number and a fraction combined into one "mixed" number. For example: 1 1/2 (one and a half) is a mixed numeral.

Task
Write a function convertToMixedNumeral to convert the improper fraction into a mixed numeral.

The input will be given as a string (e.g. '4/3').

The output should be a string, with a space in between the whole number and the fraction (e.g. '1 1/3'). 
You do not need to reduce the result to its simplest form.

For the purpose of this exercise, there will be no 0, empty string or null input value. However, the input can be:

a negative fraction
a fraction that does not require conversion
a fraction that can be converted into a whole number
Example
convertToMixedNumeral('6/2') // '3'
convertToMixedNumeral('74/3') // '24 2/3'
convertToMixedNumeral('-504/26') // '-19 10/26'
convertToMixedNumeral('9/18') // '9/18'
*/

using System;

namespace CodeWars
{
    public class ConvertImproperFractionToMixedNumeral
    {
        public string convertToMixedNumeral(string frac)
        {
            var n = frac.Split('/');
            var (a, b) = (int.Parse(n[0]), int.Parse(n[1]));
            var x = a / b;
            var r = a % b;
            return r == 0 ? $"{x}" : x == 0 ? $"{r}/{b}" : $"{x} {Math.Abs(r)}/{b}";


            // var nd = frac.Split('/');
            // var (n, d) = (int.Parse(nd[0]), int.Parse(nd[1]));
            // int w = n / d;
            // int pn = w >= 0 ? n - w * d : w * d - n;
            // return pn == 0 ? $"{w}" : w == 0 ? $"{pn}/{d}" : $"{w} {pn}/{d}";


            // string[] arr = frac.Split('/');
            // int num1 = int.Parse(arr[0]);
            // int num2 = int.Parse(arr[1]);
            // return num1 % num2 == 0 ? $"{num1 / num2}" :
            //     Math.Abs(num1) < num2 ? frac : $"{num1 / num2} {Math.Abs(num1 % num2)}/{num2}";


            // var s = frac.Split('/');
            // var a = int.Parse(s[0]);
            // var b = int.Parse(s[1]);
            // var r = a / b;
            // var t = a % b;
            // return r == 0 ? frac : t == 0 ? r.ToString() : $"{r} {Math.Abs(t)}/{b}";
        }
    }
}