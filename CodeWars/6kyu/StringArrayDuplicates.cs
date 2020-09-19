/*
https://www.codewars.com/kata/59f08f89a5e129c543000069/csharp

6 kyu
String array duplicates

In this Kata, you will be given an array of strings and your task is to remove all consecutive duplicate letters from each string in the array.

For example:

dup(["abracadabra","allottee","assessee"]) = ["abracadabra","alote","asese"].

dup(["kelless","keenness"]) = ["keles","kenes"].

Strings will be lowercase only, no spaces. See test cases for more examples.

Good luck!

If you like this Kata, please try:

Alternate capitalization

Vowel consonant lexicon
*/

using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class StringArrayDuplicates
    {
        public static string[] dup(string[] arr)
        {
            return arr.Select(x => Regex.Replace(x, @"(\w)\1+", "$1")).ToArray();
            //return arr.Select(x => Regex.Replace(x, "(.)\\1+", "$1")).ToArray();
            //return arr.Select(x => Regex.Replace(x, @"(\S)\1+", "$1")).ToArray();

            //return arr.Select(s => s.Aggregate("", (x, y) => x.EndsWith(y) ? x : x + y)).ToArray();

            // return arr.Select(s => $"{s[0]}" + string.Concat(s.Skip(1).Select((c, i) => c == s[i] ? "" : $"{c}")))
            //     .ToArray();
        }
    }
}