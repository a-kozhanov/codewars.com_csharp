/*
https://www.codewars.com/kata/580a4001d6df740d61000301/csharp

7 kyu
Complete Series

You are given an array of non-negative integers, 
your task is to complete the series from 0 to the highest number in the array.

If the numbers in the sequence provided are not in order you should order them, but if a value repeats, 
then you must return a sequence with only one item, and the value of that item must be 0. like this:

inputs        outputs
[2,1]     ->  [0,1,2]
[1,4,4,6] ->  [0]
Notes: all numbers are positive integers.

This is set of example outputs based on the input sequence.

inputs        outputs
[0,1]   ->    [0,1]
[1,4,6] ->    [0,1,2,3,4,5,6]
[3,4,5] ->    [0,1,2,3,4,5]
[0,1,0] ->    [0]
*/

using System.Linq;

namespace CodeWars
{
    public class KataCompleteSeries
    {
        public static int[] CompleteSeries(int[] arr)
        {
            //return arr.Count() == arr.Distinct().Count() ? Enumerable.Range(0, arr.OrderBy(n => n).Last() + 1).ToArray() : new int[] { 0 };
            //return arr.Distinct().Count() != arr.Count() ? new int[] {0} : Enumerable.Range(0, arr.Max() + 1).ToArray();
            //return arr.Any(i => arr.Count(a => a == i) > 1) ? new[] {0} : Enumerable.Range(0, arr.Max() + 1).ToArray();
            //return arr.Length > arr.Distinct().Count() ? new int[] {0} : Enumerable.Range(0, arr.Max() + 1).ToArray();
            //return arr.Distinct().SequenceEqual(arr) ? Enumerable.Range(0, arr.Max() + 1).ToArray() : new[] {0};
            //return Enumerable.Range(0, arr.Any(x => arr.Count(n => n == x) > 1) ? 1 : arr.Max() + 1).ToArray();
            //return Enumerable.Range(0, arr.Length > arr.Distinct().Count() ? 1 : arr.Max() + 1).ToArray();
            return Enumerable.Range(0, arr.Distinct().SequenceEqual(arr) ? arr.Max() + 1 : 1).ToArray();
        }
    }
}