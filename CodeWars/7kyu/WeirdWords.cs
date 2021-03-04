/*
https://www.codewars.com/kata/57b2020eb69bfcbf64000375/csharp

7 kyu
Weird words

In this kata you will have to change every letter in a given string to the next letter in the alphabet. 
You will write a function nextLetter (Javascript) / next_letter (Python, Ruby) to do this. 
The function will take a single parameter s (string).

Examples:

"Hello" --> "Ifmmp"

"What is your name?" --> "Xibu jt zpvs obnf?"

"zoo" --> "app"

"zzZAaa" --> "aaABbb"
Note: spaces and special characters should remain the same. 
Capital letters should transfer in the same way but remain capitilized.
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class WeirdWords
    {
        public static string NextLetter(string str)
        {
            //return string.Concat(str.Select(c => char.IsLetter(c) ? (char) (c + (c % 32 == 26 ? -25 : 1)) : c));
            return string.Concat(str.Select(c => char.IsLetter(c) ? (char) (c + ("zZ".Contains(c) ? -25 : 1)) : c));
            //return string.Concat(str.Select(c => char.IsLetter(c) ? (char) (c + (char.ToLower(c) == 'z' ? -25 : 1)) : c));
            //return string.Concat(str.Select(c => char.IsLetter(c) ? "zZ".Contains(c) ? (char) (c - 25) : (char) (c + 1) : c));
            //return string.Concat(str.Select(c => char.IsLetter(c) ? char.IsLetter((char) (c + 1)) ? (char) (c + 1) : (char) (c - 25) : c));
        }
    }
}