/*
https://www.codewars.com/kata/5886c6b2f3b6ae33dd0000be/csharp

7 kyu
Simple Fun #20: First Reverse Try

Task
Reversing an array can be a tough task, especially for a novice programmer. 
Mary just started coding, so she would like to start with something basic at first. 
Instead of reversing the array entirely, she wants to swap just its first and last elements.

Given an array arr, swap its first and last elements and return the resulting array.

Example
For arr = [1, 2, 3, 4, 5], the output should be [5, 2, 3, 4, 1]

Input/Output
[input] integer array arr

Constraints: 0 ≤ arr.length ≤ 50, -1000 ≤ arr[i] ≤ 1000

[output] an integer array

Array arr with its first and its last elements swapped.
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class SimpleFun20FirstReverseTry
    {
        public int[] FirstReverseTry(int[] arr)
        {
            // return arr.Length > 1
            //     ? new int[] { }.Concat(new[] {arr.Last()}).Concat(arr.Skip(1).SkipLast(1)).Concat(new[] {arr.First()}).ToArray()
            //     : arr;

            // return arr.Length > 1
            //     ? new int[] { }.Concat(new[] {arr[^1]}).Concat(arr[1..^1]).Concat(new[] {arr[0]}).ToArray()
            //     : arr;

            //return arr.Length > 1 ? arr.Skip(1).SkipLast(1).Prepend(arr.Last()).Append(arr.First()).ToArray() : arr;
            //return arr.Length > 1 ? arr.Skip(1).SkipLast(1).Prepend(arr[^1]).Append(arr[0]).ToArray() : arr;
            return arr.Length > 1 ? arr[1..^1].Prepend(arr[^1]).Append(arr[0]).ToArray() : arr;
        }
    }
}