/*
https://www.codewars.com/kata/5656b6906de340bd1b0000ac/train/csharp
https://www.codewars.com/kata/5656b6906de340bd1b0000ac/solutions/csharp

7 kyu
Two to One

Take 2 strings s1 and s2 including only letters from ato z. 
Return a new sorted string, the longest possible, containing distinct letters,

each taken only once - coming from s1 or s2.
Examples:
a = "xyaabbbccccdefww"
b = "xxxxyyyyabklmopq"
longest(a, b) -> "abcdefklmopqwxy"

a = "abcdefghijklmnopqrstuvwxyz"
longest(a, a) -> "abcdefghijklmnopqrstuvwxyz"
*/

using System.Linq;

namespace CodeWars
{
    public class TwoToOne
    {
        public static string Longest(string s1, string s2)
        {
            //return string.Concat(s1.Union(s2).OrderBy(x => x));
            //return string.Concat(s1 + s2.OrderBy(c => c).Distinct());
            //return new string((s1 + s2).OrderBy(x => x).ToArray());
            return string.Concat(s1.Union(s2).OrderBy(x => x));
        }

        // public static string Longest(string s1, string s2)
        // {
        //     return new string(s1.Concat(s2).Distinct().OrderBy(s => s).ToArray());
        // }

        // public static string Longest(string s1, string s2)
        // {
        //     return new string((s1 + s2).Distinct().OrderBy(x => x).ToArray());
        // }

        // public static string Longest(string s1, string s2)
        // {
        //     return string.Join("", s1.Union(s2).Distinct().OrderBy(x => x));
        // }
    }
}