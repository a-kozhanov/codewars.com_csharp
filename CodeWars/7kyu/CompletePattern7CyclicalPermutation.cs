/*
https://www.codewars.com/kata/557592fcdfc2220bed000042/csharp

7 kyu
Complete The Pattern #7 - Cyclical Permutation

Task:
You have to write a function pattern which creates the following pattern (See Examples) upto desired number of rows.

If the Argument is 0 or a Negative Integer then it should return "" i.e. empty string.

Examples:
pattern(9):

123456789
234567891
345678912
456789123
567891234
678912345
789123456
891234567
912345678
pattern(5):

12345
23451
34512
45123
51234
Note: There are no spaces in the pattern

Hint: Use \n in string to jump to next line
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class CompletePattern7CyclicalPermutation
    {
        public static string Pattern(int n)
        {
            // return n < 1
            //     ? ""
            //     : string.Join("\n",
            //         Enumerable.Range(1, n).Select(x =>
            //             string.Join("", Enumerable.Range(x, n).Select(y => y > n ? y - n : y))));

            // return n <= 0
            //     ? string.Empty
            //     : string.Join('\n',
            //         Enumerable.Range(0, n).Select(m =>
            //             string.Join(string.Empty, Enumerable.Range(0, n).Select(p => 1 + ((m + p) % n)))));

            // return n < 1
            //     ? ""
            //     : string.Join("\n", Enumerable.Range(0, n).Select(
            //         i => string.Join("", Enumerable.Range(1, n).Concat(Enumerable.Range(1, n)).Skip(i).Take(n))
            //     ));

            // return (n <= 0)
            //     ? ""
            //     : String.Join("\n",
            //         Enumerable.Range(0, n).Select(x =>
            //             String.Join("", Enumerable.Range(x + 1, n - x).Concat(Enumerable.Range(1, x)))));

            // var ptn = string.Concat(Enumerable.Range(1, Math.Max(n, 0)));
            // var result = new List<string>();
            // for (var i = 0; i < n; i++)
            // {
            //     result.Add(string.Concat(ptn.Skip(i)) + string.Concat(ptn.Take(i)));
            // }
            //
            // return string.Join("\n", result);


            // return string.Join("\n", Enumerable.Range(0, Math.Max(n, 0)).Select(i =>
            //     string.Concat(Enumerable.Range(i + 1, n - i).Concat(Enumerable.Range(1, i)))));


            return string.Join("\n", Enumerable.Range(1, Math.Max(n, 0)).Select(i =>
                string.Concat(Enumerable.Range(i, n).Select(x => x > n ? x - n : x))));
        }
    }
}