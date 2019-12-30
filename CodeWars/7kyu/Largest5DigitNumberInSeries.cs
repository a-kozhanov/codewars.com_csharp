/*
https://www.codewars.com/kata/largest-5-digit-number-in-a-series/train/csharp
https://www.codewars.com/kata/51675d17e0c1bed195000001/solutions/csharp

7 kyu
Largest 5 digit number in a series

In the following 6 digit number:

283910
91 is the greatest sequence of 2 consecutive digits.

In the following 10 digit number:

1234567890
67890 is the greatest sequence of 5 consecutive digits.

Complete the solution so that it returns the greatest sequence of five consecutive digits found within the number given. 
The number will be passed in as a string of only digits. 
It should return a five digit integer. The number passed may be as large as 1000 digits.

Adapted from ProjectEuler.net
*/

using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class Largest5DigitNumberInSeries
    {
        public static int GetNumber(string s)
        {
            return int.Parse(Enumerable.Range(0, s.Length - 4).Max(i => s.Substring(i, 5)));
        }

        // public static int GetNumber1(string str)
        // {
        //     int seqLen = 5;
        //     var result = 0;
        //
        //     for (var i = 0; i <= str.Length - seqLen; i++)
        //     {
        //         var seq = int.Parse(str.Substring(i, 5));
        //         if (result < seq) result = seq;
        //     }
        //
        //     //return result;
        //     //return Enumerable.Range(0, str.Length - 4).Select(i => Convert.ToInt32(str.Substring(i, 5))).ToList().Max();
        //     return str.Select((x, i) => i).Select(i => i <= str.Length - 5 ? int.Parse(str.Substring(i, 5)) : 0).Max();
        // }

        // public static int GetNumber(string str) 
        // {
        //     return Enumerable.Range(0, str.Length - 4).Select(i => Convert.ToInt32(str.Substring(i, 5))).ToList().Max();
        // }

        // public static int GetNumber(string s) => Enumerable.Range(0, s.Length - 4).Max(i => int.Parse(s.Substring(i, 5)));

        // public static int GetNumber(string str) 
        // {
        //     if (str.Length <= 5) { return Int32.Parse(str); }
        //     return Math.Max(Int32.Parse(str.Substring(0, 5)), GetNumber(str.Substring(1)));
        // }

        // public static int GetNumber(string s) 
        // {
        //     int result = 9999;
        //     for (int i = 0; i < s.Length - 4; i++) result = Math.Max(result, Int32.Parse(s.Substring(i, 5)));
        //     return result;
        // }

        // public static int GetNumber(string str) 
        // {
        //     int result = 0;
        //     for (int i = 0; i < str.Length-4; i++ )
        //     {
        //         if (int.Parse(str.Substring(i,5))>result) result = int.Parse(str.Substring(i,5));
        //     }
        //     return result;
        // }
    }
}