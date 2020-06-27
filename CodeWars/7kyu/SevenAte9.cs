/*
https://www.codewars.com/kata/559f44187fa851efad000087/csharp

7 kyu
SevenAte9

Write a function that removes every lone 9 that is inbetween 7s.

Kata.SevenAteNine("79712312") => "79712312"
Kata.SevenAteNine("79797") => "777"
Input: String Output: String
*/

using System.Text.RegularExpressions;

namespace CodeWars
{
    public class SevenAte9
    {
        public static string SevenAteNine(string str)
        {
            //return str.Replace("797", "77").Replace("797", "77");
            //return Regex.Replace(str, "(?<=7)9(?=7)", "");
            return Regex.Replace(str, "79(?=7)", "7");
        }
    }
}