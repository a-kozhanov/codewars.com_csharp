/*
https://www.codewars.com/kata/5a262cfb8f27f217f700000b/csharp

7 kyu
Unique string characters

In this Kata, you will be given two strings a and b and your task will be to return the characters that are not common in the two strings.

For example:

solve("xyab","xzca") = "ybzc" 
--The first string has 'yb' which is not in the second string. 
--The second string has 'zc' which is not in the first string. 
Notice also that you return the characters from the first string concatenated with those from the second string.

More examples in the tests cases.

Good luck!
Please also try Simple remove duplicates
*/

using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class UniqueStringCharacters
    {
        public static string Solve(string a, string b)
        {
            //return string.Concat(a.Where(x => a.Except(b).Contains(x)).Concat(b.Where(x => b.Except(a).Contains(x))));
            //return $"{string.Concat(a.Where(x => !b.Contains(x)))}{string.Concat(b.Where(x => !a.Contains(x)))}";
            //return string.Concat(a.Where(x => !b.Any(y => y == x)).Concat(b.Where(x => !a.Any(y => y == x))));
            //return string.Concat(a.Where(c => b.IndexOf(c) == -1).Concat(b.Where(c => a.IndexOf(c) == -1)));
            //return string.Concat(a.Where(x => b.All(y => y != x)).Concat(b.Where(x => a.All(y => y != x))));
            return Regex.Replace(a, $"[{b}]", "") + Regex.Replace(b, $"[{a}]", "");
        }
    }
}