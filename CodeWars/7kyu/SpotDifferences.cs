/*
https://www.codewars.com/kata/5881460c780e0dd207000084/csharp

7 kyu
Spot the Differences

This kata is part of the collection Mary's Puzzle Books.

Mary brought home a "spot the differences" book. 
The book is full of a bunch of problems, and each problem consists of two strings that are similar. 
However, in each string there are a few characters that are different. 

An example puzzle from her book is:
String 1: "abcdefg"
String 2: "abcqetg"
Notice how the "d" from String 1 has become a "q" in String 2, and "f" from String 1 has become a "t" in String 2.

It's your job to help Mary solve the puzzles. 
Write a program spot_diff/Spot that will compare the two strings and return a list with the positions where the two strings differ. 
In the example above, your program should return [3, 5] because String 1 is different from String 2 at positions 3 and 5.

NOTES:
• If both strings are the same, return new List<int>()
• Both strings will always be the same length
• Capitalization and punctuation matter
*/

using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class SpotDifferences
    {
        public static List<int> Spot(string s1, string s2)
        {
            // return Enumerable.Range(0, s1.Length).Where((x, i) => s1[i] != s2[i]).ToList();
            // return s1.Select((x, i) => x != s2[i] ? i : -1).Where(x => x >= 0).ToList();
            return s1.Select((_, i) => i).Where(i => s1[i] != s2[i]).ToList();
        }
    }
}