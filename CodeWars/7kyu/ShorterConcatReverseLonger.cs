/*
https://www.codewars.com/kata/54557d61126a00423b000a45/csharp

7 kyu
shorter concat [reverse longer]

Given 2 strings, a and b, return a string of the form: shorter+reverse(longer)+shorter.

In other words, the shortest string has to be put as prefix and as suffix of the reverse of the longest.

Strings a and b may be empty, but not null (In C# strings may also be null. Treat them as if they are empty.).
If a and b have the same length treat a as the longer producing b+reverse(a)+b
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class ShorterConcatReverseLonger
    {
        public static string ShorterReverseLonger(string a, string b)
        {
            a ??= "";
            b ??= "";
            return b.Length > a.Length ? a + string.Concat(b.Reverse()) + a : b + string.Concat(a.Reverse()) + b;
        }
    }
}