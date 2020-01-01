/*
https://www.codewars.com/kata/remove-duplicate-words/train/csharp
https://www.codewars.com/kata/5b39e3772ae7545f650000fc/solutions/csharp

7 kyu
Remove duplicate words

Your task is to remove all duplicate words from a string, leaving only single (first) words entries.

Example:

Input:
'alpha beta beta gamma gamma gamma delta alpha beta beta gamma gamma gamma delta'

Output:
'alpha beta gamma delta'
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class KataRemoveDuplicateWords
    {
        public static string RemoveDuplicateWords(string s)
        {
            return string.Join(" ", s.Split().Distinct());
        }
    }
}