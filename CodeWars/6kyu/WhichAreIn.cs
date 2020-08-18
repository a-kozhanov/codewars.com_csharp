/*
https://www.codewars.com/kata/550554fd08b86f84fe000a58/csharp

6 kyu
Which are in?

Given two arrays of strings a1 and a2 return a sorted array r in lexicographical order of the strings of a1 which are substrings of strings of a2.

#Example 1: 
a1 = ["arp", "live", "strong"]
a2 = ["lively", "alive", "harp", "sharp", "armstrong"]
returns ["arp", "live", "strong"]

#Example 2: 
a1 = ["tarp", "mice", "bull"]
a2 = ["lively", "alive", "harp", "sharp", "armstrong"]
returns []

Notes:
Arrays are written in "general" notation. See "Your Test Cases" for examples in your language.

In Shell bash a1 and a2 are strings. The return is a string where words are separated by commas.

Beware: r must be without duplicates.
Don't mutate the inputs.
*/

using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class WhichAreIn
    {
        public static string[] inArray(string[] array1, string[] array2)
        {
            return array1.Where(a => array2.Any(b => b.Contains(a))).OrderBy(s => s).ToArray();

            //return array1.Where(x => array2.Count(y => y.Contains(x)) > 0).OrderBy(z => z).ToArray();
            //return array1.SelectMany(a => array2, (a, b) => new {a, b}).Where(t => t.b.Contains(t.a)).Select(t => t.a).Distinct().OrderBy(e => e).ToArray();


            // var result = new List<string>();
            // foreach (var a1 in array1)
            // {
            //     result.AddRange(array2.Where(a2 => a2.Contains(a1)).Select(a2 => a1));
            // }
            //
            // return result.Distinct().OrderBy(x => x).ToArray();
        }
    }
}