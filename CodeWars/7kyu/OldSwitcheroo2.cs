/*
https://www.codewars.com/kata/55d6a0e4ededb894be000005/csharp

7 kyu
The old switcheroo 2

This is a follow up from my kata The old switcheroo

Write

public static string Encode(string str)
that takes in a string str and replaces all the letters with their respective positions in the English alphabet.

Encode("abc") == "123" // a is 1st in English alpabet, b is 2nd and c is 3rd
Encode("codewars") == "315452311819"
Encode("abc-#@5") == "123-#@5"
String are case sensitive.

// Bonus point if you don't use ToLower()
*/

using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class OldSwitcheroo2
    {
        public static string Encode(string str)
        {
            return string.Concat(str.Select(c => char.IsLetter(c) ? $"{c % 32}" : $"{c}"));
            //return string.Concat(str.Select(c => char.IsLetter(c) ? (c % 32).ToString() : c.ToString()));
            //return Regex.Replace(str, "[a-zA-Z]", s => str[s.Index] - (str[s.Index] > 96 ? 96 : 64) + "");
            //return string.Concat(str.ToLower().Select(c => c > 64 && c < 91 ? (c % 64).ToString() : c.ToString()));
            //return string.Concat(str.ToUpper().Select(c => char.IsLetter(c) ? (c % 64).ToString() : c.ToString()));
            //return string.Concat(str.ToLower().Select(c => char.IsLetter(c) ? (c - 96).ToString() : c.ToString()));

            // return string.Concat(str.ToLower().Select(x => char.IsLetter(x) ? x - 96 : x)
            //     .Select(x => x < 27 ? x.ToString() : ((char) x).ToString()));

            // return string.Concat(str.ToLower().Select(x => (int) x > 96 && (int) x < 123 ? x - 96 : x)
            //     .Select(x => x < 27 ? x.ToString() : ((char) x).ToString()));
        }
    }
}