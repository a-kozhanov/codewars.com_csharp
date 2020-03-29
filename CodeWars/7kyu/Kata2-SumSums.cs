/*
https://www.codewars.com/kata/5804acd4e053562b5f00004d/train/csharp
https://www.codewars.com/kata/5804acd4e053562b5f00004d/solutions

7 kyu
2-Sum Sums

2-Sum is a common task to find the pair of integers in the array such that their sum equals to the target.
Array = [1,2,3,4,5]
target - 7
Pair is [2, 5]

#Task
There is an array of unique integers.

The task is to find a sum of all targets in the specific range [from, to), 
which has a pair in the array, such that sum of the pair equals to the target.

#Example
Array = [2, 4, 6, 10] target range is [6, 10)
target = 6 - there is a pair (2, 4)
target = 7 - there is no pair
target = 8 - there is a pair (2, 6)
target = 9 - there is no pair
So the Result is 14 = 6 + 8
*/

using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class Kata2_SumSums
    {
        public int SumOfTwoSumTargets(int[] numbers, int from, int to)
        {
            var set = new HashSet<int>();

            for (var i = 0; i < numbers.Length; i++)
            {
                for (var j = i + 1; j < numbers.Length; j++)
                {
                    var s = numbers[i] + numbers[j];
                    if (s >= from && s < to) set.Add(s);
                }
            }

            return set.Sum();

            //Performance Test Fails - Test exceeded Timeout value of 500ms
            // return Enumerable.Range(from, to - from)
            //     .Where(x => numbers.Where(t => x - t != t).Any(t => numbers.Contains(x - t))).Sum();
        }
    }
}