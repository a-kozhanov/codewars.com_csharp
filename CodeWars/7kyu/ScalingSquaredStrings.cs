/*
https://www.codewars.com/kata/56ed20a2c4e5d69155000301/csharp

7 kyu
Scaling Squared Strings

You are given a string of n lines, each substring being n characters long. For example:

s = "abcd\nefgh\nijkl\nmnop"

We will study the "horizontal" and the "vertical" scaling of this square of strings.

A k-horizontal scaling of a string consists of replicating k times each character of the string (except '\n').

Example: 2-horizontal scaling of s: => "aabbccdd\neeffgghh\niijjkkll\nmmnnoopp"
A v-vertical scaling of a string consists of replicating v times each part of the squared string.

Example: 2-vertical scaling of s: => "abcd\nabcd\nefgh\nefgh\nijkl\nijkl\nmnop\nmnop"
Function scale(strng, k, v) will perform a k-horizontal scaling and a v-vertical scaling.

Example: a = "abcd\nefgh\nijkl\nmnop"
scale(a, 2, 3) --> "aabbccdd\naabbccdd\naabbccdd\neeffgghh\neeffgghh\neeffgghh\niijjkkll\niijjkkll\niijjkkll\nmmnnoopp\nmmnnoopp\nmmnnoopp"
Printed:

abcd   ----->   aabbccdd
efgh            aabbccdd
ijkl            aabbccdd
mnop            eeffgghh
                eeffgghh
                eeffgghh
                iijjkkll
                iijjkkll
                iijjkkll
                mmnnoopp
                mmnnoopp
                mmnnoopp
Task:
Write function scale(strng, k, v) k and v will be positive integers. If strng == "" return "".
*/

using System.Linq;

namespace CodeWars
{
    public class ScalingSquaredStrings
    {
        public static string Scale(string s, int k, int n)
        {
            return string.Join('\n', s.Split('\n').Select(x => x.Any()
                ? string.Join('\n', Enumerable.Repeat(string.Concat(x.Select(c => new string(c, k))), n))
                : ""));


            // if (!strng.Any()) return "";
            // var r = strng.Split("\n");
            // var r1 = r.Select(x => string.Concat(x.Select(c => string.Concat(Enumerable.Repeat(c, k)))));
            // var r2 = r1.Select(x => string.Join("\n", Enumerable.Repeat(x, n)));
            // return string.Join("\n", r2);


            // return string.Join("\n",
            //     strng.Split('\n').Select(a =>
            //         string.Join("\n", Enumerable.Repeat(string.Concat(a.Select(b => new string(b, k))), n))));


            // return strng.Length < 1
            //     ? ""
            //     : string.Join("\n", strng.Split('\n')
            //         .Select(e =>
            //             string.Join("\n", Enumerable.Repeat(string.Concat(e.Select(x => new string(x, k))), n))));


            // return strng == ""
            //     ? ""
            //     : string.Join("\n",
            //         strng.Split('\n').Select(x => string.Join("", x.Select(y => new string(y, k))))
            //             .Select(x => string.Join("\n", Enumerable.Range(0, n).Select(y => x))));


            // return string.IsNullOrEmpty(strng)
            //     ? ""
            //     : string.Join("\n",
            //         strng.Split("\n")
            //             .Select(t => string.Concat(t.Select(u => new string(u, k))))
            //             .SelectMany(t => Enumerable.Range(1, n).Select(u => t))
            //     );


            // return strng.Any()
            //     ? string.Join("\n",
            //         strng.Split("\n").Select(x => string.Concat(x.Select(c => string.Concat(Enumerable.Repeat(c, k)))))
            //             .Select(x => string.Join("\n", Enumerable.Repeat(x, n))))
            //     : "";


            // return string.Join('\n', strng.Split('\n').Select(s => s.Any()
            //     ? string.Join('\n', Enumerable.Repeat(string.Concat(s.Select(c => new string(c, k))), n))
            //     : ""));
        }
    }
}