/*
https://www.codewars.com/kata/52829c5fe08baf7edc00122b/train/csharp
https://www.codewars.com/kata/52829c5fe08baf7edc00122b/solutions/csharp

7 kyu
Number Of Occurrences

Write a functionthat returns the number of occurrences of an element in an array.

Examples
var sample = { 1, 0, 2, 2, 3 };
NumberOfOccurrences(0, sample) == 1;
NumberOfOccurrences(4, sample) == 0;
NumberOfOccurrences(2, sample) == 2;
NumberOfOccurrences(3, sample) == 1;
*/


using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class KataNumberOfOccurrences
    {
        public static int NumberOfOccurrences(int x, int[] xs)
        {
            //return xs.Count(n => n == x);
            return xs.Count(x.Equals);
        }


        // public static int NumberOfOccurrences(int x, int[] xs) => (from int i in xs
        //     where i == x
        //     select i).Count();


        // public static int NumberOfOccurrences(int x, int[] xs)
        // {
        //     int count = 0;
        //     foreach (int i in xs) if (i == x) count += 1;
        //     return count;
        // }


        // public static int NumberOfOccurrences(int x, int[] xs)
        // {
        //     return xs.Count(x.Equals);
        // }

        // public static int NumberOfOccurrences(int x, int[] xs)
        // {
        //     List<int> numbers = new List<int>(xs);
        //     return numbers.Where(i => i == x).Count();
        // }


        // public static int NumberOfOccurrences(int x, int[] xs)
        // {
        //     return xs.Where(element => element == x).Count();
        // }


        // public static int NumberOfOccurrences(int x, int[] xs)
        // {
        //     return xs.Count(i => i.Equals(x));
        // }


        // public static int NumberOfOccurrences(int x, int[] xs)=>xs.Count(d=>d.Equals(x));
    }
}