/*
https://www.codewars.com/kata/5639bdcef2f9b06ce800005b/csharp

7 kyu
Return String of First Characters

In this exercise, a string is passed to a method and a new string has to be returned with the first character of each word in the string.

For example:

"This Is A Test" ==> "TIAT"
*/

using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class ReturnStringOfFirstCharacters
    {
        public static string MakeString(string s)
        {
            //return Regex.Replace(s, @"([a-z])([a-z]+)| ", m => m.Groups[1].Value);
            //return Regex.Replace(s, @"\w+ |\w+$", m => $"{m.Value[0]}");
            //return s.Split().Aggregate("", (c, w) => c + w[0]);
            return string.Concat(s.Split().Select(e => e[0]));
        }
    }
}