/*
https://www.codewars.com/kata/558dd9a1b3f79dc88e000001/csharp

7 kyu
Find The Duplicated Number in a Consecutive Unsorted List


You are given an array of n+1 integers 1 through n. In addition there is a single duplicate integer.

The array is unsorted.

An example valid array would be [3, 2, 5, 1, 3, 4]. It has the integers 1 through 5 and 3 is duplicated. [1, 2, 4, 5, 5] would not be valid as it is missing 3.

You should return the duplicate value as a single integer.
*/

using System.Linq;

namespace CodeWars
{
    public class FindDuplicatedNumberConsecutiveUnsortedList
    {
        public static int FindDup(int[] arr)
        {
            //return arr.GroupBy(x => x).OrderByDescending(g => g.Count()).First().Key;
            //return arr.GroupBy(x => x).First(x => x.Count() == 2).First();
            //return arr.Sum() - Enumerable.Range(1, arr.Length - 1).Sum();
            //return arr.Distinct().First(c => arr.Count(q => q == c) > 1);
            //return arr.GroupBy(x => x).Single(x => x.Count() == 2).Key;
            //return arr.GroupBy(x => x).First(x => x.Count() == 2).Key;
            //return arr.Sum() - arr.Length * (arr.Length - 1) / 2;
            //return arr.First(n => arr.Count(i => i == n) == 2);
            //return arr.Sum() - arr.Distinct().Sum();
            return arr.Sum() - arr.Union(arr).Sum();
        }
    }
}