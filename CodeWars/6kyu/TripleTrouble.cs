
//https://www.codewars.com/kata/triple-trouble-1/train/csharp
//https://www.codewars.com/kata/55d5434f269c0c3f1b000058/solutions/csharp

//6 kyu
//Triple trouble

//Write a function
//TripleDouble(long num1, long num2)
//which takes numbers num1 and num2 and returns 1 if there is a straight triple of a number at any place in num1 and also a straight double of the same number in num2.

//If this isn't the case, return 0

//Examples
//TripleDouble(451999277, 41177722899) == 1 // num1 has straight triple 999s and num2 has straight double 99s
//TripleDouble(1222345, 12345) == 0 // num1 has straight triple 2s but num2 has only a single 2
//TripleDouble(12345, 12345) == 0
//TripleDouble(666789, 12345667) == 1

using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public static class TripleTrouble6
    {
        public static int TripleDouble(long num1, long num2)
        {
            for (var i = 0; i <= 9; i++)
            {
                if (num1.ToString().Contains($"{i}{i}{i}") && num2.ToString().Contains($"{i}{i}")) return 1;
            }
            return 0;
        }
    }


    //public static int TripleDouble(long num1, long num2)
    //{
    //    return "0123456789".Count(number => num1.ToString().Contains(new string(number, 3)) && num2.ToString().Contains(new string(number, 2)));
    //}

    //public static int TripleDouble(long num1, long num2)
    //{
    //    var a = num1.ToString().Distinct();
    //    foreach (var item in a)
    //    {
    //        if (
    //            num1.ToString().Contains(String.Format("{0}{0}{0}", item))
    //            && num2.ToString().Contains(String.Format("{0}{0}", item))
    //        ) return 1;

    //    }
    //    return 0;
    //}

    //public static int TripleDouble(long num1, long num2)
    //{
    //    return Convert.ToInt32(Regex.IsMatch($"{num1} {num2}", "^.*(.)\\1{2}.* .*\\1{2}.*$"));
    //}

    //public static int TripleDouble(long num1, long num2)
    //{
    //    return new Regex(@"^\d*(\d)\1\1\d*\s\d*\1\1\d*$").IsMatch($"{num1} {num2}") ? 1 : 0;
    //}


    //public static int TripleDouble(long num1, long num2)
    //{
    //    //code me ^^
    //    return "0123456789".ToList().Any(x => num1.ToString().Contains(new String(x, 3)) && num2.ToString().Contains(new String(x, 2))) ? 1 : 0;
    //}


    //public static int TripleDouble(long num1, long num2)
    //{
    //    return Enumerable.Range(0, 10)
    //    .Select(d => num1.ToString().Contains("" + d + d + d) ?
    //    num2.ToString().Contains("" + d + d) ? 1 : 0
    //    : 0).Sum();
    //}

    //public static int TripleDouble(long num1, long num2)
    //{
    //    return (Regex.IsMatch($"{num1}#{num2}", @"(\d)\1\1.+#.+\1\1")) ? 1 : 0;
    //}



}
