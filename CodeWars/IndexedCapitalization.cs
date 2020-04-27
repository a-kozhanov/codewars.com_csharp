/*
https://www.codewars.com/kata/59cfc09a86a6fdf6df0000f1/train/csharp

7 kyu
Indexed capitalization

Given a string and an array of integers representing indices, capitalize all letters at the given indices.

For example:

capitalize("abcdef",[1,2,5]) = "aBCdeF"
capitalize("abcdef",[1,2,5,100]) = "aBCdeF". There is no index 100.
The input will be a lowercase string with no spaces and an array of digits.

Good luck!

Be sure to also try:

Alternate capitalization

String array revisal
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class IndexedCapitalization
    {
        public static string Capitalize(string s, List<int> idxs)
        {
            //return string.Concat(Enumerable.Range(0, s.Length).Select(i => idxs.Contains(i) ? char.ToUpper(s.ElementAt(i)) : s.ElementAt(i)));
            //return string.Concat(s.Select((c, i) => idxs.Exists(m => m == i) ? char.ToUpper(c) : c));
            //return new string(s.Select((c, i) => idxs.Contains(i) ? char.ToUpper(c) : c).ToArray());
            return string.Concat(s.Select((c, i) => idxs.Contains(i) ? char.ToUpper(c) : c));
        }
    }
}