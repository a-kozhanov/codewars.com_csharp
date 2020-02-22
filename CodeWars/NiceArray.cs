/*
https://www.codewars.com/kata/59b844528bcb7735560000a0/train/csharp
https://www.codewars.com/kata/59b844528bcb7735560000a0/solutions/csharp

7 kyu
Nice Array

A Nice array is defined to be an array where for every value n in the array, 
there is also an element n-1 or n+1 in the array.

example:
[2,10,9,3] is Nice array because

2=3-1
10=9+1
3=2+1
9=10-1

Write a function named isNice/IsNice that returns true if its array argument is a Nice array, else false. 
You should also return false if input array has no elements.
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class NiceArray
    {
        public static bool IsNice(int[] arr)
        {
            Console.WriteLine($"{string.Join(", ", arr)}; Length: {arr.Length}; Any: {arr.Any()}");
            return arr.Any() && arr.All(x => arr.Contains(x - 1) || arr.Contains(x + 1));
        }

        // public static bool IsNice(int[] arr)
        // {
        //     return arr.Length > 0 && arr.All(x => arr.Contains(x + 1) || arr.Contains(x - 1));
        // }

        // public static bool IsNice(int[] arr)
        // {
        //     if (arr.ToList().Count == 0)
        //     {
        //         return false;
        //     }
        //     else
        //     {
        //         foreach (var u in arr)
        //         {
        //             if ((!arr.Contains(u + 1)) && (!arr.Contains(u - 1)))
        //             {
        //                 return false;
        //             }
        //         }
        //
        //         return true;
        //     }
        // }


        // public static bool IsNice(int[] arr)
        // {
        //     if (arr.Length <= 1)
        //     {
        //         return false;
        //     }
        //
        //     foreach (int i in arr)
        //     {
        //         if (!(arr.Contains(i - 1)) && !(arr.Contains(i + 1)))
        //         {
        //             return false;
        //         }
        //     }
        //
        //     return true;
        // }


        // public static bool IsNice(int[] arr) =>
        //     arr.Length == 0 ? false : arr.All(x => arr.Except(new[] {x}).Any(y => Math.Abs(x - y) == 1));


        // public static bool IsNice(int[] arr)
        // {
        //     return arr.Length > 0 && arr.Count(x => arr.Contains(x - 1) || arr.Contains(x + 1)) == arr.Length;
        // }

        // public static bool IsNice(int[] arr)
        // {
        //     if (arr.Length == 0) return false;
        //     for (int i = 0; i < arr.Length; i++)
        //         if (!arr.Contains(arr[i] + 1) && !arr.Contains(arr[i] - 1))
        //             return false;
        //     return true;
        // }
    }
}