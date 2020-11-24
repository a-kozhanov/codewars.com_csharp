/*
https://www.codewars.com/kata/5784c89be5553370e000061b/csharp

7 kyu
Product of Largest Pair

Rick wants a faster way to get the product of the largest pair in an array. 
Your task is to create a performant solution to find the product of the largest two integers in a unique array of positive numbers.
All inputs will be valid.
Passing [2, 6, 3] should return 18, the product of [6, 3].

Disclaimer: Mr. Roll will only accept solutions that are faster than his, which has a running time O(nlogn).

Kata.MaxProduct(new int[] { 2, 1, 5, 0, 4, 3 });              // 20
Kata.MaxProduct(new int[] { 7, 8, 9 })     ;                  // 72
Kata.MaxProduct(new int[] { 33, 231, 454, 11, 9, 99, 57 });   // 104874
*/

using System.Linq;

namespace CodeWars
{
    public class ProductOfLargestPair
    {
        public static int MaxProduct(int[] array)
        {
            return array.OrderBy(x => -x).Take(2).Aggregate((a, b) => a * b);
        }
    }
}