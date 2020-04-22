/*
https://www.codewars.com/kata/576bb3c4b1abc497ec000065/train/csharp

7 kyu
Compare Strings by Sum of Chars

Compare two strings by comparing the sum of their values (ASCII character code).

For comparing treat all letters as UpperCase
null/NULL/Nil/None should be treated as empty strings
If the string contains other characters than letters, treat the whole string as it would be empty
Your method should return true, if the strings are equal and false if they are not equal.

Examples:
"AD", "BC"  -> equal
"AD", "DD"  -> not equal
"gf", "FG"  -> equal
"zz1", ""   -> equal (both are considered empty)
"ZzZz", "ffPFF" -> equal
"kl", "lz"  -> not equal
null, ""    -> equal
*/

using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class CompareStringsBySumOfChars
    {
        public static bool Compare(string s1, string s2)
        {
            // s1 = !string.IsNullOrEmpty(s1) && s1.ToUpper().All(x => x >= 'A' && x <= 'Z') ? s1.ToUpper() : "";
            // s2 = !string.IsNullOrEmpty(s2) && s2.ToUpper().All(x => x >= 'A' && x <= 'Z') ? s2.ToUpper() : "";

            // s1 = s1 == null ? "" : Regex.Match(s1, "[^a-zA-Z]").Success ? "" : s1.ToUpper();
            // s2 = s2 == null ? "" : Regex.Match(s2, "[^a-zA-Z]").Success ? "" : s2.ToUpper();

            // return s1.Sum(x => (int) x) == s2.Sum(x => (int) x);

            int GetSum(string s) => s.All(char.IsLetter) ? s.Sum(c => (int) char.ToUpper(c)) : 0;
            return GetSum(s1 ?? "") == GetSum(s2 ?? "");
        }
    }
}

// s1 = s1==null?"":Regex.Match(s1, "[^a-zA-Z]").Success?"":s1.ToUpper();
// s2 = s2==null?"":Regex.Match(s2, "[^a-zA-Z]").Success?"":s2.ToUpper();
// return s1.Sum(a=>a) == s2.Sum(a=>a);


// private static int StringValue(string str) {
// return str == null || str.Any(c => !Char.IsLetter(c)) ? 0 : str.ToUpper().Select(c => (int)c).Sum();
// }
//
// public static bool Compare(string s1, string s2)
// { 
// return StringValue(s1) == StringValue(s2);
// }

// s1 = s1 != null ? (s1.All(char.IsLetter) ? s1.ToUpper() : "") : "";
// s2 = s2 != null ? (s2.All(char.IsLetter) ? s2.ToUpper() : "") : "";
// return s1.Sum(c => c).Equals(s2.Sum(c => c));


// if (s1 == null || Regex.IsMatch(s1, @"[^a-zA-Z]")) s1 = "";
// if (s2 == null || Regex.IsMatch(s2, @"[^a-zA-Z]")) s2 = "";
// return s1.ToUpper().Sum(x => (int)x) == s2.ToUpper().Sum(x => (int)x);


// if (s1 == null || s1.Any(x => !char.IsLetter(x))) s1 = "";
// if (s2 == null || s2.Any(x => !char.IsLetter(x))) s2 = "";
// return s1.ToUpper().Sum(x => (int)x) == s2.ToUpper().Sum(x => (int)x);


// if (s1 == null || !s1.All(c => char.IsLetter(c))) s1 = string.Empty;
// if (s2 == null || !s2.All(c => char.IsLetter(c))) s2 = string.Empty;
// return s1.ToUpper().Select(c => (int)c).Sum() == s2.ToUpper().Select(c => (int)c).Sum();


// var n1 = s1 == null || s1.Any(c => !char.IsLetter(c))? string.Empty : s1.ToUpper();
// var n2 = s2 == null || s2.Any(c => !char.IsLetter(c)) ? string.Empty : s2.ToUpper();
// return n1.Sum(_ => _) == n2.Sum(_ => _);


// return (!string.IsNullOrEmpty(s1) && s1.All(c => char.IsLetter(c)) ? s1.ToUpper().Sum(c => c) : 0)
// == (!string.IsNullOrEmpty(s2) && s2.All(c => char.IsLetter(c)) ? s2.ToUpper().Sum(c => c) : 0);


// Func<string, int> f = s => s.All(Char.IsLetter) ? s.Sum(ch => (int)Char.ToUpper(ch)) : 0;
// return f(s1 ?? String.Empty) == f(s2 ?? String.Empty);


// Func<string, string> convert = s => s == null || s.ToUpper().Any(c => c < 65 || c > 90) ? string.Empty : s.ToUpper();
// return convert(s1).Sum(c => c) == convert(s2).Sum(c => c);

// var firstSum = ((s1 ?? "").All(char.IsLetter) ? (s1?.ToUpper() ?? "") : "").Select(x => (int)x).Sum();
// var secondSum = ((s2 ?? "").All(char.IsLetter) ? (s2?.ToUpper() ?? "") : "").Select(x => (int)x).Sum();
// return firstSum == secondSum;