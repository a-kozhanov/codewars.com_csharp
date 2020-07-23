/*
https://www.codewars.com/kata/counting-duplicates/csharp

6 kyu
Counting Duplicates

Count the number of Duplicates
Write a function that will return the count of distinct case-insensitive alphabetic characters and numeric
digits that occur more than once in the input string. The input string can be assumed to contain only
alphabets(both uppercase and lowercase) and numeric digits.

Example
"abcde" -> 0 # no characters repeats more than once
"aabbcde" -> 2 # 'a' and 'b'
"aabBcde" -> 2 # 'a' occurs twice and 'b' twice (`b` and `B`)
"indivisibility" -> 1 # 'i' occurs six times
"Indivisibilities" -> 2 # 'i' occurs seven times and 's' occurs twice
"aA11" -> 2 # 'a' and '1'
"ABBA" -> 2 # 'A' and 'B' each occur twice
*/

using System.Collections.Generic;
using System.Linq;


namespace CodeWars
{
    public class CountingDuplicates
    {
        public static int DuplicateCount(string str)
        {
            //return str.Where(x => str.ToLower().Count(y => y == x) > 1).Distinct().Count();
            //return str.ToLower().GroupBy(x => x).Where(x=>x.Count() > 1).Count();
            //return str.GroupBy(char.ToLower).Sum(g => g.Count() > 1 ? 1 : 0);
            //return str.ToLower().GroupBy(x => x).Count(x => x.Count() > 1);
            //return str.ToLookup(char.ToLower).Count(g => g.Count() > 1);
            return str.GroupBy(char.ToLower).Count(x => x.Count() > 1);
        }
    }
}