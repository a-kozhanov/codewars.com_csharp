/*
https://www.codewars.com/kata/55733d3ef7c43f8b0700007c/train/csharp
https://www.codewars.com/kata/55733d3ef7c43f8b0700007c/solutions/csharp

7 kyu
Complete The Pattern #2

Task:
You have to write a function pattern which returns the following Pattern (See Pattern & Examples) upto n number of rows.

Note: Returning the pattern is not the same as Printing the pattern.
Rules/Note:
If n < 1 then it should return "" i.e. empty string.
There are no whitespaces in the pattern.
Pattern:
(n)(n-1)(n-2)...4321
(n)(n-1)(n-2)...432
(n)(n-1)(n-2)...43
(n)(n-1)(n-2)...4
...............
..............
(n)(n-1)(n-2)
(n)(n-1)
(n)
Examples:
pattern(4):

4321
432
43
4
pattern(11):

1110987654321
111098765432
11109876543
1110987654
111098765
11109876
1110987
111098
11109
1110
11

Hint: Use \n in string to jump to next line
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//using static System.Linq.Enumerable;

namespace CodeWars
{
    public class CompletePattern2
    {
        public string Pattern(int n)
        {
            // List<string> list = new List<string>();
            // for (var i = 1; i <= n; i++)
            // {
            //     var s = "";
            //     for (var j = n; i <= j; j--)
            //     {
            //         s += j;
            //     }
            //     list.Add(s);
            // }
            // return string.Join("\n", list);

            // return string.Join("\n",
            //     Enumerable.Range(0, Math.Max(0, n))
            //         .Select(x => string.Concat(Enumerable.Range(0, n - x).Select(a => n - a))));

            //return string.Join("\n", Enumerable.Range(1, Math.Max(0, n)).Reverse().Select(x => string.Concat(Enumerable.Range(n - x + 1, x).Reverse())));

            // return n < 0 ? "" : string.Join("\n",
            //     Enumerable.Range(1, n).Reverse().Select(x => string.Concat(Enumerable.Range(n - x + 1, x).Reverse())));  

            return string.Join("\n",
                Enumerable.Range(0, Math.Max(0, n))
                    .Select(x => string.Concat(Enumerable.Range(0, n - x).Select(i => n - i))));
        }

        // public string Pattern(int n)
        // {
        //     StringBuilder strBuilder = new StringBuilder();
        //     for (int i = 0; i < n; i++)
        //     {
        //         strBuilder.Append(i == 0 ? "" : "\n");
        //         for (int k = n; k > i; k--)
        //             strBuilder.Append(k.ToString());
        //     }
        //
        //     return strBuilder.ToString();
        // }


        // public string Pattern(int n)
        // {
        //     if (n <= 0) return string.Empty;
        //
        //     return string.Join("\n", Enumerable
        //         .Range(1, n)
        //         .Select(x =>
        //             string.Concat(Enumerable
        //                 .Range(x, n - x + 1)
        //                 .Reverse()
        //                 .Select(y => y.ToString()))));
        // }


        // public string Pattern(int n)
        // {
        //     string pattern = "", current = "";
        //
        //     for (int i = n; i > 0; i--)
        //     {
        //         current += i;
        //         pattern = i != n ? current + "\n" + pattern : pattern + current;
        //     }
        //
        //     return pattern;
        // }


        // public string Pattern(int n) {
        //     return String.Join("\n", Enumerable.Range(0, Math.Max(0, n)).Select(i => String.Join("", Enumerable.Range(0, n - i).Select(j => n - j))));
        // }


        // public string Pattern(int n)
        // {
        //     if (n <= 0) return "";
        //     var nums = Enumerable.Range(1, n).Reverse().ToArray();
        //     return String.Join("\n", nums.Select(i => String.Concat(nums.Take(i))));
        // }


        // public string Pattern(int n)
        // {
        //     var textList = new List<string>();
        //     var text = "";
        //
        //     for (int i = n; i > 0; i--)
        //     {
        //         text += i.ToString();
        //         textList.Add(text);
        //     }
        //
        //     return string.Join("\n", textList.OrderByDescending(item => item));
        // }


        // public string Pattern(int n)
        // {
        //     if(n<1) return "";
        //     var r = Enumerable.Range(1, n).Reverse();
        //     return string.Join("\n", Enumerable.Range(1, n).Select(e => string.Concat(r.Take(e))).Reverse());
        // }


        // public string Pattern(int n) =>
        //     n < 1 ? "" : string.Join("\n", Range(1, n).Reverse().Select((x, i) => String.Join("", Range(1, n).Reverse().SkipLast(i))));


        // public string Pattern(int n)
        // {
        //     if (n < 1) return string.Empty;
        //     return string.Join('\n', Enumerable.Range(0, n).Select(i => string.Concat(Enumerable.Range(0, n - i).Select(j => n - j))));
        // }


        // public string Pattern(int n)
        // {
        //     return n >= 1 ? string.Join('\n', Enumerable.Range(1, n).Select(x => string.Concat(Enumerable.Range(x, n-x+1).Reverse()))) : "";
        // }
    }
}