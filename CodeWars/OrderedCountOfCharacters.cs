/*
https://www.codewars.com/kata/57a6633153ba33189e000074/train/csharp

7 kyu
Ordered Count of Characters

Count the number of occurrences of each character and return it as a list of tuples in order of appearance.

Example:
        Kata.OrderedCount("abracadabra") == new List<Tuple<char, int>> () {
            new Tuple<char, int>('a', 5),
            new Tuple<char, int>('b', 2), new Tuple<char, int>('r', 2), new Tuple<char, int>('c', 1), new
                Tuple<char, int>('d', 1)       
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class OrderedCountOfCharacters
    {
        public static IEnumerable<Tuple<char, int>> OrderedCount(string input)
        {
            // return input.Distinct().Select(x => new Tuple<char, int>(x, input.Count(s => s == x))).ToList();
            // return input.GroupBy(t => t).Select(u => new Tuple<char, int>(u.Key, u.Count())).ToList();
            // return input.Distinct().Select(x => Tuple.Create(x, input.Count(c => c == x))).ToList();
            // return input.GroupBy(c => c, (c, g) => new Tuple<char, int>(c, g.Count())).ToList();
            // return input.GroupBy(x => x).Select(a => Tuple.Create(a.Key, a.Count())).ToList();
            // return input.GroupBy(x => x).Select(a => (a.Key, a.Count()).ToTuple()).ToList();
            // return input.GroupBy(x => x, (c, g) => Tuple.Create(c, g.Count())).ToList();
            return input.GroupBy(x => x, (c, g) => (c, g.Count()).ToTuple()).ToList();
        }
    }
}