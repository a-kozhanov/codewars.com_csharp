/*
https://www.codewars.com/kata/59f11118a5e129e591000134/train/csharp

7 kyu
Sum of array singles

In this Kata, you will be given an array of numbers in which two numbers occur once and the rest occur only twice. 
Your task will be to return the sum of the numbers that occur only once.

For example, repeats([4,5,7,5,4,8]) = 15 because only the numbers 7 and 8 occur once, and their sum is 15.

More examples in the test cases.

Documentation:
Kata.Repeats Method (List<Int32>)
Takes a list where all ints are repeated twice, 
except two ints, and returns the sum of the ints of a list where those ints only occur once.

Syntax

public static int Repeats(
List<int> source
  )

Parameters
source
Type: System.Collections.Generic.List<Int32>
The list to process.

Return Value
Type: System.Int32
The sum of the elements of the list where those elements have no duplicates.
Good luck!

If you like this Kata, please try:

Sum of prime-indexed elements

Sum of integer combinations
*/

using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class SumOfArraySingles
    {
        public static int Repeats(List<int> source)
        {
            // return source.Distinct().ToArray().Sum() - (source.Sum() - source.Distinct().ToArray().Sum());
            // return source.GroupBy(x => x).Where(x => x.Count() == 1).ToList().SelectMany(x => x).Sum();
            // return source.GroupBy(i => i).Where(g => g.Count() == 1).SelectMany(g => g).Sum();
            // return source.GroupBy(x => x).OrderBy(x => x.Count()).Take(2).Sum(x => x.Key);
            // return source.Where(str => source.Count(s => s == str) == 1).Distinct().Sum();
            // return source.GroupBy(x => x).OrderBy(x => x.Count()).Take(2).Sum(x => x.Key);
            // return source.Where(c => source.IndexOf(c) == source.LastIndexOf(c)).Sum();
            // return source.GroupBy(x => x).Where(x => x.Count() == 1).Sum(x => x.Key);
            // return source.Sum() - 2 * (source.Sum() - source.Distinct().Sum());
            // return source.Where(x => source.Count(i => i == x) < 2).Sum();
            // return source.Sum(x => source.Count(i => i == x) < 2 ? x : 0);
            // return 2 * source.Distinct().Sum() - source.Sum();
            //return 2 * source.Distinct().Sum() - source.Sum();
            //return source.Sum() - 2 * (source.Sum() - source.Distinct().Sum());

            return source.Distinct().Sum() * 2 - source.Sum();
        }
    }
}