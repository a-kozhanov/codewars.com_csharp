/*
https://www.codewars.com/kata/5a19701d80171fd71d000029/csharp

7 kyu
Cipher

This cipher involves taking each character of a string and multiplying their char codes by 6.

For example, `Hello World!` would become `ưɞʈʈʚÀȊʚʬʈɘÆ`.

You must write two functions:
`encode` to encode a given string,
`decode` to decode a given string.
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class Cipher
    {
        public static string Encode(string str)
        {
            return string.Concat(str.Select(x => (char) (x * 6)));
        }

        public static string Decode(string str)
        {
            return string.Concat(str.Select(x => (char) (x / 6)));
        }

        // public static string Encode(string s) => Cipher1(s, i => i * 6);
        // public static string Decode(string s) => Cipher1(s, i => i / 6);
        // private static string Cipher1(string s, Func<int, int> f) => string.Concat(s.Select(c => (char) f(c)));
    }
}