/*
https://www.codewars.com/kata/559e10e2e162b69f750000b4/train/csharp

7 kyu
What dominates your array?

A zero-indexed array arr consisting of n integers is given. 
The dominator of array arr is the value that occurs in more than half of the elements of arr.
For example, consider array arr such that arr = [3,4,3,2,3,1,3,3]
The dominator of arr is 3 because it occurs in 5 out of 8 elements of arr and 5 is more than a half of 8.
Write a function dominator(arr) that, given a zero-indexed array arr consisting of n integers, returns the dominator of arr. 
The function should return −1 if array does not have a dominator. All values in arr will be >=0.
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class WhatdominatesYourArray
    {
        public static int WhoDominates(int[] array)
        {
            return array.GroupBy(i => i).FirstOrDefault(g => g.Count() > array.Length / 2)?.Key ?? -1;
        }


        // public static int WhoDominates(int[] array)
        // {
        //     return array.GroupBy(x => x)
        //         .Where(x => x.Count() > array.Length / 2)
        //         .OrderByDescending(x => x.Count())
        //         .FirstOrDefault()?.Key ?? -1;
        // }


        // public static int WhoDominates(int[] array)
        // {
        //     try
        //     {
        //         return Enumerable.Range(array.Min(), array.Max())
        //             .First(x => array.Count(c => c == x) > array.Length / 2);
        //     }
        //     catch (Exception ex)
        //     {
        //         return -1;
        //     }
        // }


        // public static int WhoDominates(int[] array)
        // {
        //     var groups = array.GroupBy(a => a);
        //     if (groups.Max(g => g.Count()) > array.Length / 2)
        //     {
        //         return groups.OrderByDescending(g => g.Count()).First().Key;
        //     }
        //
        //     return -1;
        // }


        // public static int WhoDominates(int[] array)
        // {
        //     if (array.Length == 0) return -1;
        //
        //     var groups = array.GroupBy(x => x).OrderByDescending(x => x.Count()).ToArray();
        //
        //     return groups[0].Count() > array.Length / 2 ? groups[0].Key : -1;
        // }
    }
}