/*
https://www.codewars.com/kata/56bf3287b5106eb10f000899/csharp

7 kyu
Move all vowels

Given a string as input, move all of its vowels to the end of the string, in the same order as they were before.

Vowels are (in this kata): a, e, i, o, u

Note: all provided input strings are lowercase.

Examples
"day"    ==>  "dya"
"apple"  ==>  "pplae"
*/

using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class MoveAllVowels
    {
        public static string MoveVowel(string input)
        {
            //return string.Concat(input.Where(x => !"aeiou".Contains(x))) + string.Concat(input.Where(x => "aeiou".Contains(x)));
            //return Regex.Replace(input, "[aeiou]", "") + string.Concat(input.Where("aeiou".Contains));
            //return Regex.Replace(input, "[aeiou]", "") + Regex.Replace(input, "[^aeiou]", "");
            //return input.OrderBy(c => "aeiou".Contains(c)).Aggregate("", (x, y) => x + y);
            return string.Concat(input.OrderBy(x => "aeiou".Contains(x)));
        }
    }
}