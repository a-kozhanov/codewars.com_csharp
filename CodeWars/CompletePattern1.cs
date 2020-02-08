/*
https://www.codewars.com/kata/5572f7c346eb58ae9c000047/train/csharp
https://www.codewars.com/kata/5572f7c346eb58ae9c000047/solutions/csharp

7 kyu
Complete The Pattern #1

###Task: You have to write a function pattern which returns the following Pattern(See Pattern & Examples) upto n number of rows.

Note:Returning the pattern is not the same as Printing the pattern.
####Rules/Note:

If n < 1 then it should return "" i.e. empty string.
There are no whitespaces in the pattern.
###Pattern:

1
22
333
....
.....
nnnnnn
###Examples:

pattern(5):

1
22
333
4444
55555
pattern(11):

1
22
333
4444
55555
666666
7777777
88888888
999999999
10101010101010101010
1111111111111111111111
* Hint: Use \n in string to jump to next line
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWars
{
    public class CompletePattern1
    {
        public string Pattern(int n)
        {
            return string.Join("\n",
                Enumerable.Range(1, n < 1 ? 0 : n).Select(x => string.Concat(Enumerable.Repeat(x, x))));

            // return n < 1
            //     ? ""
            //     : string.Join("\n", Enumerable.Range(1, n).Select(x => string.Concat(Enumerable.Repeat(x, x))));
        }


        // public string Pattern(int n)
        // {
        //     if(n<1) return "";
        //     return string.Join("\n",
        //         Enumerable
        //             .Range(1, n)
        //             .Select(e => string.Concat(Enumerable.Repeat(e, e))));
        // }


        // public string Pattern(int n)
        // {
        //     var sb = new System.Text.StringBuilder();
        //
        //     for(int i = 1; i<=n; i++)
        //     {
        //         for(int j=0; j<i; j++)
        //         {
        //             sb.Append(i);
        //         }
        //         if(i<n)
        //             sb.Append("\n");
        //     }
        //     // Happy Coding ^_^
        //     return sb.ToString();
        // }


        // public string Pattern(int n)
        // {
        //     if (n < 1) return "";
        //     if (n == 1) return "1";
        //     string str = "";
        //     for (int i = 0; i < n; i++) str += n.ToString();
        //     return Pattern(n - 1) + "\n" + str;
        // }


        // public string Pattern(int n)
        // {
        //     return n > 0 ? string.Join("\n", Enumerable.Range(1, n).Select(i => string.Concat(Enumerable.Repeat(i.ToString(), i)))) : "";
        // }


        // public string Pattern(int n)
        // {
        //     return n>0 ? string.Join("\n",Enumerable.Range(1,n).Select(x=>new string('X',x).Replace("X",x+""))) : "";
        // }


        // public string Pattern(int n)
        // {
        //     if (n <= 0) return "";
        //     return String.Join("\n",
        //         Enumerable.Range(1, n)
        //             .Select(i => String.Concat(Enumerable.Repeat(i.ToString(), i))));
        // }

        // public string Pattern(int n)
        // {
        //     return n < 1 ? "" : string.Join("\n", Enumerable.Range(1, n).Select(x => string.Concat(Enumerable.Repeat(x.ToString(), x))));
        // }
    }
}


// public class Kata
// {
//     public string Pattern(int n)
//     {
//         return string.Join("\n",
//             Enumerable
//                 .Range(1, Math.Max(0, n))
//                 .Select(i => i.ToString().Repeat(i)));
//     }
// }
//
// public static class Extensions
// {
//     public static string Repeat(this string s, int n)
//     {
//         return string.Concat(Enumerable.Repeat(s, n));
//     }
// }