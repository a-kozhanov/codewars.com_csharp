/*
https://www.codewars.com/kata/59d9ff9f7905dfeed50000b0/csharp

7 kyu
Alphabet symmetry

Consider the word "abode". We can see that the letter a is in position 1 and b is in position 2. 
In the alphabet, a and b are also in positions 1 and 2. 
Notice also that d and e in abode occupy the positions they would occupy in the alphabet, which are positions 4 and 5.

Given an array of words, return an array of the number of letters that occupy their positions in the alphabet for each word. For example,

solve(["abode","ABc","xyzD"]) = [4, 3, 1]
See test cases for more examples.

Input will consist of alphabet characters, both uppercase and lowercase. No spaces.

Good luck!

If you like this Kata, please try:

Last digit symmetry

Alternate capitalization
*/

using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class AlphabetSymmetry
    {
        public static List<int> Solve(List<string> arr)
        {
            //return arr.Select(v => v.Where((c, i) => char.ToLower(c) - 97 == i).Count()).ToList();
            //return arr.Select(s => s.ToUpper().Where((c, i) => c - 65 == i).Count()).ToList();
            //return arr.Select(s => s.Where((c, i) => (c & 31) == i + 1).Count()).ToList();
            return arr.Select(s => s.Where((c, i) => c % 32 == i + 1).Count()).ToList();
        }
    }
}