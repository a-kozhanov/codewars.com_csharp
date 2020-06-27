/*
https://www.codewars.com/kata/56f3a1e899b386da78000732/csharp

7 kyu
Parts of a list

Write a function partlist that gives all the ways to divide a list (an array) of at least two elements into two non-empty parts.

Each two non empty parts will be in a pair (or an array for languages without tuples or a structin C - C: see Examples test Cases - )
Each part will be in a string
Elements of a pair must be in the same order as in the original array.
Examples of returns in different languages:
a = ["az", "toto", "picaro", "zone", "kiwi"] -->

[["az", "toto picaro zone kiwi"], ["az toto", "picaro zone kiwi"], ["az toto picaro", "zone kiwi"], ["az toto picaro zone", "kiwi"]]

or

a = {"az", "toto", "picaro", "zone", "kiwi"} -->

{{"az", "toto picaro zone kiwi"}, {"az toto", "picaro zone kiwi"}, {"az toto picaro", "zone kiwi"}, {"az toto picaro zone", "kiwi"}}

or

a = ["az", "toto", "picaro", "zone", "kiwi"] -->

[("az", "toto picaro zone kiwi"), ("az toto", "picaro zone kiwi"), ("az toto picaro", "zone kiwi"), ("az toto picaro zone", "kiwi")]

or

a = [|"az", "toto", "picaro", "zone", "kiwi"|] -->

[("az", "toto picaro zone kiwi"), ("az toto", "picaro zone kiwi"), ("az toto picaro", "zone kiwi"), ("az toto picaro zone", "kiwi")]

or

a = ["az", "toto", "picaro", "zone", "kiwi"] -->

"(az, toto picaro zone kiwi)(az toto, picaro zone kiwi)(az toto picaro, zone kiwi)(az toto picaro zone, kiwi)"

You can see other examples for each language in "Your test cases"
*/

using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class PartsOfList
    {
        public static string[][] Partlist(string[] arr)
        {
            // return Enumerable.Range(1, arr.Length - 1)
            //     .Select(i => new[] {string.Join(" ", arr.Take(i)), string.Join(" ", arr.Skip(i))})
            //     .ToArray();

            return arr
                .Select((s, i) => new[] {string.Join(" ", arr.Take(i)), string.Join(" ", arr.Skip(i))})
                .Skip(1)
                .ToArray();
        }
    }
}