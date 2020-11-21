/*
https://www.codewars.com/kata/556196a6091a7e7f58000018/csharp

7 kyu
Largest pair sum in array

Given a sequence of numbers, find the largest pair sum in the sequence.

For example

[10, 14, 2, 23, 19] -->  42 (= 23 + 19)
[99, 2, 2, 23, 19]  --> 122 (= 99 + 23)
Input sequence contains minimum two elements and every element is an integer.
*/

using System.Linq;

namespace CodeWars
{
    public class LargestPairSumInArray
    {
        public static int LargestPairSum(int[] numbers)
        {
            //return Enumerable.Range(0, numbers.Length).Select(x => numbers.Take(x).Select(i => i + numbers[x])).SelectMany(x => x).Max();
            //return numbers.OrderByDescending(i => i).Take(2).Sum();
            //return numbers.OrderBy(i => i).ToArray()[^2..].Sum();
            return numbers.OrderBy(i => i).TakeLast(2).Sum();
        }
    }
}