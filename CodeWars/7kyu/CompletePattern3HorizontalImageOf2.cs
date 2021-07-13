/*
https://www.codewars.com/kata/557341907fbf439911000022/csharp

7 kyu
Complete The Pattern #3 (Horizontal Image of #2)

Task:
You have to write a function pattern which creates the following pattern upto n number of rows. 
If the Argument is 0 or a Negative Integer then it should return "" i.e. empty string.

Pattern:
(n)
(n)(n-1)
(n)(n-1)(n-2)
................
.................
(n)(n-1)(n-2)....4
(n)(n-1)(n-2)....43
(n)(n-1)(n-2)....432
(n)(n-1)(n-2)....4321
Examples:
pattern(4):

4
43
432
4321
pattern(6):

6
65
654
6543
65432
654321
Note: There are no blank spaces

Hint: Use \n in string to jump to next line
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class CompletePattern3HorizontalImageOf2
    {
        public static string Pattern(int n)
        {
            // return n < 1
            //     ? ""
            //     : string.Join("\n",
            //         Enumerable.Range(1, n).Select(i => string.Concat(Enumerable.Range(1 + n - i, i).Reverse())));

            // return n <= 0
            //     ? ""
            //     : string.Join('\n', Enumerable.Range(1, n)
            //         .Select(i => string.Concat(Enumerable.Range(n - i + 1, i).Reverse())));


            return string.Join("\n",
                Enumerable.Range(0, Math.Max(n, 0))
                    .Select(i => string.Concat(Enumerable.Range(0, i + 1).Select(j => n - j))));
        }
    }
}