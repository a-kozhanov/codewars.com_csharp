/*
https://www.codewars.com/kata/5ce6728c939bf80029988b57/csharp

7 kyu
Consecutive letters

In this Kata, we will check if a string contains consecutive letters as they appear in the English alphabet and if each letter occurs only once.

Rules are: (1) the letters are adjacent in the English alphabet, and (2) each letter occurs only once.

For example: 
solve("abc") = True, because it contains a,b,c
solve("abd") = False, because a, b, d are not consecutive/adjacent in the alphabet, and c is missing.
solve("dabc") = True, because it contains a, b, c, d
solve("abbc") = False, because b does not occur once.
solve("v") = True
All inputs will be lowercase letters.

More examples in test cases. Good luck!
*/

using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class ConsecutiveLetters
    {
        public static bool solve(string s)
        {
            //return string.Concat(Enumerable.Range('a', 26).Select(x => (char) x)).Contains(string.Concat(s.OrderBy(x => x)));
            //return "abcdefghijklmnopqrstuvwxyz".Contains(string.Concat(Regex.Split(s.ToLower(), "(?=a)").Reverse()));
            //return "abcdefghijklmnopqrstuvwxyz".Contains(new string(s.OrderBy(c => c).ToArray()));
            //return Enumerable.Range(s.OrderBy(c => c).First(), s.Length).Sum() == s.Sum(c => c);
            //return "abcdefghijklmnopqrstuvwxyz".Contains(string.Concat(s.OrderBy(c => c)));
            //return Enumerable.Range(s.Min(c => c), s.Length).Sum() == s.Sum(c => c);
            return Enumerable.Range(s.Min(), s.Length).Sum() == s.Sum(c => c);
        }
    }
}