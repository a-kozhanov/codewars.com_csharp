/*
https://www.codewars.com/kata/find-all-occurrences-of-an-element-in-an-array/train/csharp
https://www.codewars.com/kata/59a9919107157a45220000e1/solutions/csharp

7 kyu
Find all occurrences of an element in an array

Given an array (a list in Python) of integers and an integer n, 
find all occurrences of n in the given array and return another array containing 
all the index positions of n in the given array.

If n is not in the given array, return an empty array [].

Assume that n and all values in the given array will always be integers.

Example:
Kata.FindAll(new int[] {6, 9, 3, 4, 3, 82, 11}, 3) => new int[] {2, 4}
*/

using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class FindAllCccurrencesOfAnElementInAnArray
    {
        public static int[] FindAll(int[] array, int n)
        {
            return array.Select((v, i) => v == n ? i : -1).Where(i => i >= 0).ToArray();
            // return array.Select((v, i) => (v, i)).Where(x => x.v == n).Select(x => x.i).ToArray();
            // return array.Select((x, i) => x == n ? i : -1).Where(i => i >= 0).ToArray();
            // return array.Select((x, i) => x == n ? i : -1).Where(x => x != -1).ToArray();
            //return Enumerable.Range(0, array.Length).Where(i => array[i] == n).ToArray();
        }

        // public static int[] FindAll(int[] arr, int n)
        // {
        //     int length = arr.Length;
        //     List<int> indexes = new List<int>();
        //
        //     for (int i = 0; i < length; i++) 
        //     {
        //         if (arr[i] == n) indexes.Add(i);
        //     }
        //
        //     return indexes.ToArray();
        // }


        // public static int[] FindAll(int[] array, int n)
        // {
        //     return array.Select((b, i) => b == n ? i : -1).Where(i => i != -1).ToArray();
        // }
        //
    }
}