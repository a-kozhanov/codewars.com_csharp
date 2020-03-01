/*
https://www.codewars.com/kata/5d5ee4c35162d9001af7d699/train/csharp
https://www.codewars.com/kata/5d5ee4c35162d9001af7d699/solutions/csharp

7 kyu
Sum of Minimums!

Given a 2D array of size m * n. Your task is to find the sum of minimum value in each row.

For Example:

{
  {1,2,3,4,5},       // minimum value of row is 1
  {5,6,7,8,9},       // minimum value of row is 5
  {20,21,34,56,100}  // minimum value of row is 20
}
So, the function should return 26 because sum of minimums is as 1 + 5 + 20 = 26

ENJOY CODING :)
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class KataSumOfMinimums
    {
        public static int SumOfMinimums(int[,] numbers)
        {
            // var result = new List<int>();
            //
            // for (var i = 0; i < numbers.GetLength(0); i++)
            // {
            //     var arr = new List<int>();
            //     for (var j = 0; j < numbers.GetLength(1); j++)
            //     {
            //         arr.Add(numbers[i, j]);
            //     }
            //
            //     result.Add(arr.Min());
            // }
            //
            // return result.Sum();

            return Enumerable.Range(0, numbers.GetLength(0))
                .Select(x => Enumerable.Range(0, numbers.GetLength(1)).Select(y => numbers[x, y]))
                .Sum(s => s.Min());
        }

        // public static int SumOfMinimums(int[,] numbers)
        // {
        //     var sum = 0;
        //
        //     for (var i = 0; i < numbers.GetLength(0); i++)
        //     {
        //         var min = numbers[i, 0];
        //         for (var j = 1; j < numbers.GetLength(1); j++)
        //             min = min < numbers[i, j] ? min : numbers[i, j];
        //         sum += min;
        //     }
        //
        //     return sum;
        // }


        // public static int SumOfMinimums(int[,] numbers)
        // {
        //     int sum = 0;
        //     for (int i = 0; i < numbers.GetLength(0); i++)
        //     {
        //         int min = numbers[i, 0];
        //         for (int j = 1; j < numbers.GetLength(1); j++)
        //         {
        //             if (min > numbers[i, j]) min = numbers[i, j];
        //         }
        //
        //         sum += min;
        //     }
        //
        //     return sum;
        // }


        // public static int SumOfMinimums(int[,] numbers)
        // {
        //     int sum = 0;
        //     for (int i = 0; i < numbers.GetUpperBound(0) + 1; i++)
        //     {
        //         int min = 0;
        //         min = numbers[i, 0];
        //         for (int j = 1; j < numbers.GetUpperBound(1) + 1; j++)
        //         {
        //             if (min > numbers[i, j])
        //                 min = numbers[i, j];
        //         }
        //
        //         sum += min;
        //     }
        //
        //     return sum;
        // }


        // public static int SumOfMinimums(int[,] numbers)
        // {
        //     int sum = 0;
        //     for (int i = 0; i < numbers.GetUpperBound(0) + 1; i++)
        //     {
        //         int min = 0;
        //         min = numbers[i, 0];
        //         for (int j = 1; j < numbers.GetUpperBound(1) + 1; j++)
        //         {
        //             if (min > numbers[i, j])
        //                 min = numbers[i, j];
        //         }
        //
        //         sum += min;
        //     }
        //
        //     return sum;
        // }
    }
}