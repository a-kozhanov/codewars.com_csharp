/*
https://www.codewars.com/kata/553e8b195b853c6db4000048/train/csharp

7 kyu
All unique

Write a program to determine if a string contains all unique characters. Return true if it does and false otherwise.

The string may contain any of the 128 ASCII characters.
*/


using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class AllUnique
    {
        public static bool HasUniqueChars(string str)
        {
            // return str.Length == new HashSet<char>(str.Select(char.ToLower)).Count;
            // return new HashSet<char>(str.ToCharArray()).Count == str.Length;
            // return string.Concat(str.Distinct()).Length == str.Length;
            // return str.All(x => str.Where(y => y == x).Count() == 1);
            // return str.GroupBy(c => c).All(g => g.Count() == 1);
            // return str == new string(str.Distinct().ToArray());
            // return str.Length == new HashSet<char>(str).Count;
            // return str.All(e => str.Count(x => x == e) == 1);
            // return str.All(c => str.Count(x => x == c) <= 1);
            // return string.Concat(str.Distinct()).Equals(str);
            // return str.Distinct().Count() == str.Count();
            // return str.Length == str.Distinct().Count();
            return string.Concat(str.Distinct()) == str;
            // return str.Distinct().SequenceEqual(str);
        }
    }
}