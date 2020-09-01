/*
https://www.codewars.com/kata/55c04b4cc56a697bb0000048/csharp

5 kyu
Scramblies

Complete the function scramble(str1, str2) that returns true if a portion of str1 characters can be rearranged to match str2, otherwise returns false.

Notes:

Only lower case letters will be used (a-z). No punctuation or digits will be included.
Performance needs to be considered
Input strings s1 and s2 are null terminated.
Examples
scramble('rkqodlw', 'world') ==> True
scramble('cedewaraaossoqqyt', 'codewars') ==> True
scramble('katas', 'steak') ==> False


*/

using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class KataScramblies
    {
        public static bool Scramble(string str1, string str2)
        {
            //var s = str1.ToList();
            //return str2.All(c => s.Remove(c));

            //return str2.All(x => str1.Count(y => y == x) >= str2.Count(y => y == x));
            //return str2.ToLookup(x => x).All(c => str1.ToLookup(e => e)[c.Key].Count() >= c.Count());
            //return str1.Aggregate(str2, (current, c) => new Regex(c.ToString()).Replace(current, "", 1)) == "";
            //return str2.GroupBy(c => c).All(g => str1.Where(c => c == g.Key).Count() >= g.Count());
            //return str2.GroupBy(c => c).All(g => str1.Count(c => c == g.Key) >= g.Count());

            //return str1.Aggregate(str2, (current, c) => new Regex($"{c}").Replace(current, "", 1)) == "";
            //return str1.Aggregate(str2, (s, c) => new Regex($"{c}").Replace(s, "", 1)) == "";
            //return !str1.Aggregate(str2, (s, c) => new Regex($"{c}").Replace(s, "", 1)).Any();
            return !str1.Aggregate(str2, (s, c) => new Regex($"{c}").Replace(s, "", 1)).Any();
        }
    }
}