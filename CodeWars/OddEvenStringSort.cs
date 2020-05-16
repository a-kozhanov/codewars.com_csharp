/*
https://www.codewars.com/kata/580755730b5a77650500010c/csharp

7 kyu
Odd-Even String Sort

Given a string S. You have to return another string such that even-indexed and odd-indexed characters of S are grouped and groups are space-separated (see sample below)

Note: 
0 is considered to be an even index. 
All input strings are valid with no spaces
input: 'CodeWars'
output 'CdWr oeas'

S[0] = 'C'
S[1] = 'o'
S[2] = 'd'
S[3] = 'e'
S[4] = 'W'
S[5] = 'a'
S[6] = 'r'
S[7] = 's'
Even indices 0, 2, 4, 6, so we have 'CdWr' as the first group
odd ones are 1, 3, 5, 7, so the second group is 'oeas'
And the final string to return is 'Cdwr oeas'

Enjoy.
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class OddEvenStringSort
    {
        public static string SortMyString(string s)
        {
            return $"{string.Concat(s.Where((x, i) => i % 2 == 0))} {string.Concat(s.Where((x, i) => i % 2 != 0))}";

            //return string.Join(" ", Enumerable.Range(0, 2).Select(x => string.Concat(s.Where((c, i) => i % 2 == x))));

            // return string.Concat(s.Where((x, index) => index % 2 == 0)) + " " + string.Concat(s.Where((x, index) => index % 2 == 1));

            // return string
            //     .Concat(s.Select((x, i) => new {x, i}).GroupBy(x => x.i % 2 == 0).SelectMany(x => x).Select(x => x.x))
            //     .Insert(s.Length % 2 == 0 ? s.Length / 2 : s.Length / 2 + 1, " ");
        }
    }
}