/*
https://www.codewars.com/kata/5574940eae1cf7d520000076/csharp

7 kyu
Complete The Pattern #6 - Odd Ladder

###Task:

You have to write a function pattern which creates the following pattern (see examples) up to the desired number of rows.

If the Argument is 0 or a Negative Integer then it should return "" i.e. empty string.

If any even number is passed as argument then the pattern should last upto the largest odd number which is smaller than the passed even number.

###Examples:

pattern(9):

1
333
55555
7777777
999999999
pattern(6):

1
333
55555
Note: There are no spaces in the pattern

Hint: Use \n in string to jump to next line
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class CompletePattern6OddLadder
    {
        public static string OddLadder(int n)
        {
            return string.Join("\n", Enumerable.Range(1, Math.Max(0, n)).Where(i => i % 2 == 1)
                .Select(i => string.Concat(Enumerable.Repeat(i.ToString(), i))));

            // return string.Join("\n",
            //     Enumerable.Range(0, n % 2 == 0 ? n / 2 : n / 2 + 1)
            //         .Select(i => string.Concat(Enumerable.Repeat(i * 2 + 1, i * 2 + 1))));

            // return string.Join("\n",
            //     Enumerable.Range(0, (n + 1) / 2).Select(x => 2 * x + 1)
            //         .Select(x => string.Concat(Enumerable.Repeat(x.ToString(), x))));

            // return string.Join("\n",
            //     Enumerable.Range(0, (n + 1) / 2)
            //         .Select(x => string.Concat(Enumerable.Repeat((2 * x + 1).ToString(), 2 * x + 1))));

            // return string.Concat(Enumerable.Range(1, Math.Max(0, n)).Select(x =>
            //     x % 2 != 0 ? string.Concat(Enumerable.Repeat(x.ToString(), x)) : (x != n ? "\n" : "")));
        }
    }
}