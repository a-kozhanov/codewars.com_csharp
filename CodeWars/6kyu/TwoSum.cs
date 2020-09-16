/*
https://www.codewars.com/kata/52c31f8e6605bcc646000082/csharp

6 kyu
Two Sum

Write a function that takes an array of numbers (integers for the tests) and a target number. 
It should find two different items in the array that, when added together, give the target value. 
The indices of these items should then be returned in a tuple like so: (index1, index2).

For the purposes of this kata, some tests may have multiple answers; any valid solutions will be accepted.

The input will always be valid (numbers will be an array of length 2 or greater, and all of the items will be numbers; 
target will always be the sum of two different items from that array).

Based on: http://oj.leetcode.com/problems/two-sum/

twoSum [1, 2, 3] 4 === (0, 2)
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class KataTwoSum
    {
        public static int[] TwoSum(int[] numbers, int target)
        {
            // return numbers.Select((x, i) => new[] {i, Array.IndexOf(numbers, target - x, i + 1)})
            //     .First(x => x[1] != -1);

            for (var i = 0; i < numbers.Length; i++)
            {
                for (var j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] + numbers[j] == target) return new[] {i, j};
                }
            }

            return new int[0];
        }
    }
}