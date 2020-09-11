/*
https://www.codewars.com/kata/5a71939d373c2e634200008e/csharp

7 kyu
Simple string reversal

In this Kata, we are going to reverse a string while maintaining the spaces (if any) in their original place.

For example:

solve("our code") = "edo cruo"
-- Normal reversal without spaces is "edocruo". 
-- However, there is a space at index 3, so the string becomes "edo cruo"

solve("your code rocks") = "skco redo cruoy". 
solve("codewars") = "srawedoc"
More examples in the test cases. All input will be lower case letters and in some cases spaces.

Good luck!

Please also try:

Simple time difference

Simple remove duplicates
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class SimpleStringReversal
    {
        public static String solve(String s)
        {
            return s.Select((c, i) => (c, i)).Where(x => x.c == ' ')
                .Aggregate(string.Concat(s.Replace(" ", "").Reverse()), (r, x) => r.Insert(x.i, " "));
        }
    }
}