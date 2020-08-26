/*
https://www.codewars.com/kata/5590961e6620c0825000008f/csharp

7 kyu
Case swapping

Given a string, swap the case for each of the letters.

e.g. CodEwArs --> cODeWaRS

Examples
""           ->   ""
"CodeWars"   ->   "cODEwARS"
"abc"        ->   "ABC"
"ABC"        ->   "abc"
"123235"     ->   "123235"
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class CaseSwapping
    {
        public static string Swap(string str)
        {
            //return string.Concat(string.Empty, str.Select(c => c >= 'a' && c <= 'z' ? char.ToUpper(c) : char.ToLower(c)));
            //return str.Aggregate("", (s, c) => s + (char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c)));
            //return string.Concat(str.Select(x => char.IsUpper(x) ? char.ToLower(x) : char.ToUpper(x)));
            //return string.Concat(str.Select(x => char.IsLetter(x) ? (char) (x ^ ' ') : x));
            return string.Concat(str.Select(c => char.IsLetter(c) ? (char) (c ^ 32) : c));
        }
    }
}