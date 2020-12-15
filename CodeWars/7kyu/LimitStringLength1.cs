/*
https://www.codewars.com/kata/5208fc3cb613bc725f000142/csharp

7 kyu
Limit string length - 1

Complete the solution, so that it returns the truncated version of the string followed by '...'.

Example:
solution('Testing String',3) // should return 'Tes...'
solution('Testing String',8) // should return 'Testing ...'
solution('Test',8) // should return 'Test'
*/

using System;

namespace CodeWars
{
    public class LimitStringLength1
    {
        public static string Limit(string text, int limit)
        {
            return limit < text.Length ? text[..limit] + "..." : text;
            //return text[..Math.Min(text.Length, limit)] + (text.Length > limit ? "..." : "");
            //return text[..(text.Length > limit ? limit : text.Length)] + (text.Length > limit ? "..." : "");
            //return text.Substring(0, (text.Length > limit ? limit : text.Length)) + (text.Length > limit ? "..." : "");
        }
    }
}