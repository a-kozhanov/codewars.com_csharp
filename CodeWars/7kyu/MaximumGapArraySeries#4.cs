/*
https://www.codewars.com/kata/5a7893ef0025e9eb50000013/csharp

7 kyu
Maximum Gap (Array Series #4)

Introduction and Warm-up (Highly recommended)
Playing With Lists/Arrays Series
Task
Given an array/list [] of integers , Find The maximum difference between the successive elements in its sorted form.

Notes
Array/list size is at least 3 .

Array/list's numbers Will be mixture of positives and negatives also zeros_

Repetition of numbers in the array/list could occur.

The Maximum Gap is computed Regardless the sign.

Input >> Output Examples
maxGap ({13,10,5,2,9}) ==> return (4)
Explanation:
The Maximum Gap after sorting the array is 4 , The difference between 9 - 5 = 4 .
maxGap ({-3,-27,-4,-2}) ==> return (23)
Explanation:
The Maximum Gap after sorting the array is 23 , The difference between |-4- (-27) | = 23 .

Note : Regardless the sign of negativity .

maxGap ({-7,-42,-809,-14,-12}) ==> return (767)  
Explanation:
The Maximum Gap after sorting the array is 767 , The difference between | -809- (-42) | = 767 .

Note : Regardless the sign of negativity .

maxGap ({-54,37,0,64,640,0,-15}) //return (576)
Explanation:
The Maximum Gap after sorting the array is 576 , The difference between | 64 - 640 | = 576 .

Note : Regardless the sign of negativity .
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class MaximumGapArraySeries_4
    {
        public static int MaxGap(int[] numbers)
        {
            Array.Sort(numbers);
            return numbers.Zip(numbers.Skip(1), (a, b) => b - a).Max();

            // Array.Sort(numbers);
            // return Enumerable.Range(1, numbers.Length - 1).Max(i => numbers[i] - numbers[i - 1]);

            // int[] arr = numbers.OrderBy(x => x).ToArray();
            // return arr.Select((x, i) => (i == 0) ? 0 : arr[i] - arr[i - 1]).Max();

            // numbers = numbers.OrderBy(i => i).ToArray();
            // return numbers.Zip(numbers.Skip(1), (a, b) => b - a).Max();

            // var sorted = numbers.OrderBy(i => i);
            // return sorted.Zip(sorted.Skip(1), (a, b) => b - a).Max();

            // numbers = numbers.OrderByDescending(n => n).ToArray();
            // return numbers.Zip(numbers.Skip(1), (a, b) => a - b).Max();

            // numbers = numbers.OrderBy(x => x).ToArray();
            // return numbers.Skip(1).Select((x, i) => Math.Abs(numbers[i] - x)).Max();

            // return numbers.OrderBy(i => i).Skip(1).Zip(numbers.OrderBy(i => i), (a, b) => Math.Abs(b - a)).Max();

            // numbers = numbers.OrderBy(v => v).ToArray();
            // return Enumerable.Range(0, numbers.Length).Select((x, i) => i > 0 ? numbers[i] - numbers[i - 1] : 0).Max();
        }
    }
}