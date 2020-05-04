/*
https://www.codewars.com/kata/5569b10074fe4a6715000054/train/csharp

7 kyu
Counting Array Elements

Write a function that takes an array and counts the number of each unique element present.

Kata.Count(new List<string> {"James", "James", "John"}) =>
  new Dictionary<string, int> {{"James", 2}, {"John", 1}};
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class CountingArrayElements
    {
        public static Dictionary<string, int> Count(List<string> lst)
        {
            //return lst.Distinct().ToDictionary(x => x, x => lst.Count(s => s == x));
            return lst.ToLookup(x => x).ToDictionary(x => x.Key, x => x.Count());
            //return lst.GroupBy(s => s).ToDictionary(x => x.Key, x => x.Count());
        }
    }
}