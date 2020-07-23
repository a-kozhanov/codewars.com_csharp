/*
https://www.codewars.com/kata/54b42f9314d9229fd6000d9c/csharp

6 kyu
Duplicate Encoder

The goal of this exercise is to convert a string to a new string where each character in the new string is "(" 
if that character appears only once in the original string, or ")" 
if that character appears more than once in the original string. 
Ignore capitalization when determining if a character is a duplicate.

Examples
"din"      =>  "((("
"recede"   =>  "()()()"
"Success"  =>  ")())())"
"(( @"     =>  "))((" 

Notes
Assertion messages may be unclear about what they display in some languages. 
If you read "...It Should encode XXX", the "XXX" is the expected result, not the input!
*/

using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class DuplicateEncoder
    {
        public static string DuplicateEncode(string word)
        {
            //return Regex.Replace(word.ToLower(), @"[/s]|[^/s]", m => word.ToLower().Count(c => c.ToString() == m.Value) > 1 ? ")" : "(");
            //return string.Concat(word.ToLower().Select(x => word.ToLower().IndexOf(x) == word.ToLower().LastIndexOf(x) ? '(' : ')'));
            //return word.ToUpper().Select(c => word.ToUpper().Count(w => w == c) > 1 ? ")" : "(").Aggregate((r, n) => r + n);
            //return (word = word.ToLower()).Aggregate("", (acc, c) =>  acc + (word.Count(c1 => c1 == c) > 1 ? ')' : '('));
            //return word.ToLower().Aggregate("", (s, c) => s + (word.ToLower().Count(a => a == c) > 1 ? ')' : '('));
            //return string.Concat(word.ToUpper().Select(x => word.ToUpper().Count(i => i == x) == 1 ? "(" : ")"));
            //return string.Concat(word.ToLower().Select(c => word.ToLower().Count(x => x == c) == 1 ? "(" : ")"));
            return string.Concat(word.ToUpper().Select(x => word.ToUpper().Split(x).Length == 2 ? "(" : ")"));
        }
    }
}