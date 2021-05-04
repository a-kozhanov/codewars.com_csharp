/*
https://www.codewars.com/kata/56f253dd75e340ff670002ac/csharp

7 kyu
Composing squared strings

A squared string is a string of n lines, each substring being n characters long. We are given two n-squared strings. For example:

s1 = "abcd\nefgh\nijkl\nmnop" s2 = "qrst\nuvwx\nyz12\n3456"

Let us build a new string strng of size (n + 1) x n in the following way:

The first line of strng has the first char of the first line of s1 plus the chars of the last line of s2.
The second line of strng has the first two chars of the second line of s1 plus the chars of the penultimate line of s2 except the last char
and so on until the nth line of strng has the n chars of the nth line of s1 plus the first char of the first line of s2.
Calling this function compose(s1, s2) we have:

compose(s1, s2) -> "a3456\nefyz1\nijkuv\nmnopq"
or printed:
abcd    qrst  -->  a3456
efgh    uvwx       efyz1
ijkl    yz12       ijkuv
mnop    3456       mnopq
*/

using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class ComposingSquaredStrings
    {
        public static string Compose(string s1, string s2)
        {
            var sp1 = s1.Split('\n');
            var sp2 = s2.Split('\n');
            var result = new List<string>();
            for (int i = 0, length = sp1.Length; i < length; i++)
            {
                result.Add(sp1[i][..(i + 1)] + sp2[length - i - 1][..(length - i)]);
            }

            return string.Join("\n", result);


            // return string.Join("\n", Enumerable.Range(1, 1000)
            //     .Zip(s1.Split('\n'), (i, a) => (i, a))
            //     .Zip(s2.Split('\n').Reverse(), (_, b) => (_.i, _.a, b))
            //     .Select(_ => string.Concat(_.a.Take(_.i).Concat(_.b.SkipLast(_.i - 1)))));
        }
    }
}