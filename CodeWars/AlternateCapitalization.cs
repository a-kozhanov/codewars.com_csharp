/*
https://www.codewars.com/kata/59cfc000aeb2844d16000075/train/csharp
https://www.codewars.com/kata/59cfc000aeb2844d16000075/solutions/csharp/

7 kyu
Alternate capitalization

Given a string, capitalize the letters that occupy even indexes and odd indexes separately, 
and return as shown below. Index 0 will be considered even.

For example, capitalize("abcdef") = ['AbCdEf', 'aBcDeF']. See test cases for more examples.

The input will be a lowercase string with no spaces.

Good luck!

If you like this Kata, please try:
Indexed capitalization
Even-odd disparity
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class AlternateCapitalization
    {
        public static string[] Capitalize(string s)
        {
            return Enumerable.Range(0, 2)
                .Select(n => string.Concat(s.Select((x, i) => i % 2 == n ? char.ToUpper(x) : x))).ToArray();

            //return "  ".Select((c, n) => string.Concat(s.Select((x, i) => i % 2 == n ? char.ToUpper(x) : x))).ToArray();

            // return new[]
            // {
            //     string.Concat(s.Select((x, i) => i % 2 == 0 ? char.ToUpper(x) : x)),
            //     string.Concat(s.Select((x, i) => i % 2 == 1 ? char.ToUpper(x) : x))
            // };
        }


        // public static string[] Capitalize(string s)
        // {
        //     var r1 = "";
        //     var r2 = "";
        //     for (int i = 0; i < s.Length; i++)
        //     {
        //         r1 += i % 2 == 0 ? (char) (s[i] - 32) : s[i];
        //         r2 += i % 2 == 1 ? (char) (s[i] - 32) : s[i];
        //     }
        //
        //     return new[] {r1, r2};
        // }


        // public static string[] Capitalize(string s)
        // {
        //     var first = "";
        //     var second = "";
        //
        //     for (var x = 0; x < s.Length; x++)
        //     {
        //         first = (x % 2 == 0) ? first + char.ToUpper(s[x]) : first + s[x];
        //         second = (x % 2 != 0) ? second + char.ToUpper(s[x]) : second + s[x];
        //     }
        //
        //     return new[] {first, second};
        // }


        // public static string[] Capitalize(string s)
        // {
        //     bool odd;
        //     var arr = new string[2];
        //     for (int i = 0; i < s.Length; i++)
        //     {
        //         odd = i % 2 != 0;
        //         arr[odd ? 1 : 0] += char.ToUpper(s[i]);
        //         arr[odd ? 0 : 1] += s[i];
        //     }
        //
        //     return arr;
        // }


        // public static string[] Capitalize(string s)
        // {
        //     var firstString = String.Empty;
        //     var secondString = String.Empty;
        //
        //     for (var x = 0; x < s.Length; x++)
        //     {
        //         firstString = (x % 2 == 0) ? firstString += char.ToUpper(s[x]) : firstString += s[x];
        //         secondString = (x % 2 != 0) ? secondString += char.ToUpper(s[x]) : secondString += s[x];
        //     }
        //
        //     return new[] {firstString, secondString};
        // }
    }
}