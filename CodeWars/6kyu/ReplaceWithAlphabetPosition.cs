/*
https://www.codewars.com/kata/546f922b54af40e1e90001da/csharp

6 kyu
Replace With Alphabet Position

Welcome.
In this kata you are required to, given a string, replace every letter with its position in the alphabet.
If anything in the text isn't a letter, ignore it and don't return it.

"a" = 1, "b" = 2, etc.

Example
Kata.AlphabetPosition("The sunset sets at twelve o' clock.")
Should return "20 8 5 19 21 14 19 5 20 19 5 20 19 1 20 20 23 5 12 22 5 15 3 12 15 3 11" (as a string)
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class ReplaceWithAlphabetPosition
    {
        public static string AlphabetPosition(string text)
        {
            //return string.Join(" ", text.ToLower().Select(x => x - 96).Where(x => x > 0 && x < 28));
            //return string.Join(" ", text.ToLower().Where(char.IsLetter).Select(x => x - 'a' + 1));
            //return String.Join(" ", text.Where(x => char.IsLetter(x)).Select(x => (int) x % 32));
            //return string.Join(" ", text.ToLower().Where(char.IsLetter).Select(x => x - 96));
            //return string.Join(" ", text.Where(char.IsLetter).Select(x => (int) x % 32));
            return string.Join(" ", text.Where(char.IsLetter).Select(c => c & 31));
        }
    }
}