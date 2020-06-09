/*
https://www.codewars.com/kata/57a62154cf1fa5b25200031e/train/csharp

7 kyu
Alternate case

Write function alternateCase which switch every letter in string from upper to lower and from lower to upper. 
E.g: Hello World -> hELLO wORLD
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class AlternateCase
    {
        public static string alternateCase(string s)
        {
            //return new string(s.Select(c => char.IsLetter(c) ? (char) (c ^ 0x20) : c).ToArray());
            //return new string(s.Select(c => (char)(!char.IsLetter(c) ? c : c < 97 ? c + 32 : c - 32)).ToArray());
            //return new string(s.Select(t => (t >= 'a' && t <= 'z') ? char.ToUpper(t) : char.ToLower(t)).ToArray());
            //return string.Concat(s.Select(t => t >= 'a' && t <= 'z' ? char.ToUpper(t) : char.ToLower(t)).ToArray());
            //return string.Concat(s.Select(c => (char)(!char.IsLetter(c) ? c : c < 97 ? c + 32 : c - 32)));
            return string.Concat(s.Select(c => char.IsLower(c) ? char.ToUpper(c) : char.ToLower(c)));
            //return string.Concat(s.Select(c => char.IsLetter(c) ? (char) (c ^ 0x20) : c));
        }
    }
}