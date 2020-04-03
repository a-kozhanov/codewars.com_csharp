/*
https://www.codewars.com/kata/5700c9acc1555755be00027e/train/csharp

7 kyu
All Inclusive?

Input:
a string strng
an array of strings arr
Output of function contain_all_rots(strng, arr) (or containAllRots or contain-all-rots):

a boolean true if all rotations of strng are included in arr (C returns 1)
false otherwise (C returns 0)

Examples:
contain_all_rots(
  "bsjq", ["bsjq", "qbsj", "sjqb", "twZNsslC", "jqbs"]) -> true

contain_all_rots(
  "Ajylvpy", ["Ajylvpy", "ylvpyAj", "jylvpyA", "lvpyAjy", "pyAjylv", "vpyAjyl", "ipywee"]) -> false)

Note:
Though not correct in a mathematical sense

we will consider that there are no rotations of strng == ""
and for any array arr: contain_all_rots("", arr) --> true

Ref: https://en.wikipedia.org/wiki/String_(computer_science)#Rotations
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class AllInclusive
    {
        public static Boolean ContainAllRots(string s, List<string> arr)
        {
            //return s.Select((c, i) => string.Concat(s.Skip(i).Concat(s.Take(i)))).All(x => arr.IndexOf(x) != -1);
            //return Enumerable.Range(0, s.Length).All(i => arr.Contains((s + s).Substring(i, s.Length)));
            //return s.Select((c, i) => (s + s).Substring(i, s.Length)).All(x => arr.IndexOf(x) != -1);
            //return s.Select((c, i) => arr.Contains((s + s).Substring(i, s.Length))).All(x => x);
            //return !s.Where((c, i) => arr.IndexOf((s + s).Substring(i, s.Length)) == -1).Any();
            return !s.Where((c, i) => !arr.Contains((s + s).Substring(i, s.Length))).Any();
        }
    }
}