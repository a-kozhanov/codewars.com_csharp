/*
https://www.codewars.com/kata/5831c204a31721e2ae000294/train/csharp

7 kyu
Changing letters

When provided with a String, capitalize all vowels

For example:
Input : "Hello World!"
Output : "HEllO WOrld!"

Note: Y is not a vowel in this kata.
*/

using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class ChangingLetters
    {
        public static string Swap(string s)
        {
            //return string.Concat(s.Select(x => "aeiou".Contains(x) ? x.ToString().ToUpper() : x.ToString()));
            //return new string(s.Select(x => "aeiou".Contains(x) ? char.ToUpper(x) : x).ToArray());
            //return string.Concat(s.Select(x => "aeiou".Contains(l) ? $"{x}".ToUpper() : $"{x}"));
            //return string.Concat(s.Select(x => "aeiou".Contains(x) ? char.ToUpper(x) : x));
            //return string.Concat(s.Select(x => "aeiou".Contains(x) ? (char) (x - 32) : x));
            //return Regex.Replace(s, "[aeiou]", m => m.ToString().ToUpper());        
            return Regex.Replace(s, "[aeiou]", m => m.Value.ToUpper());
        }
    }
}