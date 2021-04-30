/*
https://www.codewars.com/kata/55749101ae1cf7673800003e/csharp

7 kyu
Complete The Pattern #5 - Even Ladder

Task:
You have to write a function pattern which creates the following pattern up to n/2 number of lines.

If n <= 1 then it should return "" (i.e. empty string).
If any odd number is passed as argument then the pattern should last up to the largest even number which is smaller than the passed odd number.
Examples:
pattern(8):

22
4444
666666
88888888
pattern(5):

22
4444
Note: There are no spaces in the pattern

Hint: Use \n in string to jump to next line
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWars
{
    public class CompletePattern5EvenLadder
    {
        public static string Pattern(int n)
        {
            return string.Join("\n", Enumerable.Range(1, Math.Max(0, n)).Where(x => x % 2 == 0)
                .Select(x => string.Concat(Enumerable.Repeat(x.ToString(), x))));

            // return n <= 1
            //     ? ""
            //     : string.Join("\n",
            //         Enumerable.Range(1, n / 2)
            //             .Select(x => string.Concat(Enumerable.Repeat((x * 2).ToString(), x * 2))));


            // var result = new List<string>();
            // for (var i = 1; i <= n; i++)
            // {
            //     if (i % 2 == 0)
            //     {
            //         result.Add(string.Concat(Enumerable.Repeat((i).ToString(), i)));
            //     }
            // }
            //
            // return string.Join("\n", result);
        }
    }
}