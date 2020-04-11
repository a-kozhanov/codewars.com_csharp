/*
https://www.codewars.com/kata/555bfd6f9f9f52680f0000c5/train/csharp

7 kyu
Reverse a Number

Given a number, write a function to output its reverse digits. (e.g. given 123 the answer is 321)
Numbers should preserve their sign; i.e. a negative number should still be negative when reversed.

Examples
 123 ->  321
-456 -> -654
1000 ->    1
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class KataReverseNumber
    {
        public int ReverseNumber(int n)
        {
            //return int.Parse(new string(n.ToString().Reverse().OrderBy(c => c != '-').Select(x => x).ToArray()));
            //return  (n < 0 ? -1 : 1) * int.Parse(new string(Math.Abs(n).ToString().Reverse().ToArray()));
            //return Math.Sign(n) * int.Parse(new string(Math.Abs(n).ToString().Reverse().ToArray()));
            //return (n < 0 ? -1 : 1) * int.Parse(string.Concat(Math.Abs(n).ToString().Reverse()));
            //return n < 0 ? -1 * ReverseNumber(-n) : int.Parse(string.Concat($"{n}".Reverse()));
            //return int.Parse((n < 0 ? "-" : "+") + string.Concat($"{Math.Abs(n)}".Reverse()));
            //return  (n < 0 ? -1 : 1) * int.Parse(string.Concat($"{Math.Abs(n)}".Reverse()));
            //return  (n < 0 ? -1 : 1) * int.Parse(new string($"{Math.Abs(n)}".Reverse()));
            return Math.Sign(n) * int.Parse(string.Concat($"{Math.Abs(n)}".Reverse()));
        }
    }
}