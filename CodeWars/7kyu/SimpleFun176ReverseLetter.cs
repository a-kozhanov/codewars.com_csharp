/*
https://www.codewars.com/kata/58b8c94b7df3f116eb00005b/train/csharp

7 kyu
Simple Fun #176: Reverse Letter

Task
Given a string str, reverse it omitting all non-alphabetic characters.

Example
For str = "krishan", the output should be "nahsirk".
For str = "ultr53o?n", the output should be "nortlu".

Input/Output
[input] string str

A string consists of lowercase latin letters, digits and symbols.

[output] a string
*/

using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class SimpleFun176ReverseLetter
    {
        public string ReverseLetter(string str)
        {
            //return new string(str.Where(char.IsLetter).Reverse().ToArray());
            //return string.Concat(Regex.Replace(str, "[^a-z]", "").Reverse());
            return string.Concat(str.Where(char.IsLetter).Reverse());
        }
    }
}