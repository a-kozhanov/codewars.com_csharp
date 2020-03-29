/*
https://www.codewars.com/kata/5a4138acf28b82aa43000117/train/csharp
https://www.codewars.com/kata/5a4138acf28b82aa43000117/solutions/csharp

7 kyu
Maximum Product

Task
Given an array of integers , Find the maximum product obtained from multiplying 2 adjacent numbers in the array.

Notes
Array/list size is at least 2.

Array/list numbers could be a mixture of positives, negatives also zeroes .

Input >> Output Examples
adjacentElementsProduct([1, 2, 3]); ==> return 6
Explanation:
The maximum product obtained from multiplying 2 * 3 = 6, and they're adjacent numbers in the array.
adjacentElementsProduct([9, 5, 10, 2, 24, -1, -48]); ==> return 50
Explanation:
Max product obtained from multiplying 5 * 10 = 50.

adjacentElementsProduct([-23, 4, -5, 99, -27, 329, -2, 7, -921])  ==>  return -14
Explanation:
The maximum product obtained from multiplying -2 * 7 = -14, and they're adjacent numbers in the array.
Playing with Numbers Series
Playing With Lists/Arrays Series
For More Enjoyable Katas
ALL translations are welcomed
Enjoy Learning !!
Zizou
*/


using System;
using System.Linq;

namespace CodeWars
{
    public class MaximumProduct
    {
        public static int AdjacentElementsProduct(int[] array)
        {
            //return Enumerable.Range(0, array.Length - 1).Aggregate(int.MinValue, (s, n) => Math.Max(s, array[n] * array[n + 1]));
            //return Enumerable.Range(0, array.Length - 1).Select((x, i) => array[i] * array[i + 1]).Max();
            //return Enumerable.Range(0, array.Length - 1).Max(x => array[x] * array[x + 1]);
            //return Enumerable.Range(1, array.Length - 1).Max(i => array[i - 1] * array[i]);
            //return array.Take(array.Length - 1).Zip(array.Skip(1), (a, b) => a * b).Max();
            //return array.Skip(1).Select((x, i) => x * array[i]).Max();
            //return array.Zip(array.Skip(1), (x, i) => x * i).Max();
            return array.Skip(1).Zip(array, (x, y) => x * y).Max();
        }
    }
}