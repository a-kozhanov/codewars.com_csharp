/*
https://www.codewars.com/kata/numbers-to-letters/train/csharp


7 kyu
Numbers to Letters

Given an array of numbers, you must return a string. 
The numbers correspond to the letters of the alphabet in reverse order: a=26, z=1 etc. 
You should also account for '!', '?' and ' ' that are represented by '27', '28' and '29' respectively.

All inputs will be valid.
*/

using System.Linq;

namespace CodeWars
{
    public class NumbersToLetters
    {
        public static string Switcher(string[] x)
        {
            var letters = "zyxwvutsrqponmlkjihgfedcba!? ";
            return string.Concat(x.Select(n => "zyxwvutsrqponmlkjihgfedcba!? "[int.Parse(n) - 1]));
        }
    }
}