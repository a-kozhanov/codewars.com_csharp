/*
https://www.codewars.com/kata/596f6385e7cd727fff0000d6/train/csharp
https://www.codewars.com/kata/596f6385e7cd727fff0000d6/solutions/csharp

7 kyu
Average Array

ASC Week 1 Challenge 5 (Medium #2)
Create a function that takes a 2D array as an input, 
and outputs another array that contains the average values for the numbers in the nested arrays at the corresponding indexes.

Note: the function should also work with negative numbers and floats.

Examples
[ [1, 2, 3, 4], [5, 6, 7, 8] ]  ==>  [3, 4, 5, 6]

1st array: [1, 2, 3, 4]
2nd array: [5, 6, 7, 8]
            |  |  |  |
            v  v  v  v
average:   [3, 4, 5, 6]
And another one:

[ [2, 3, 9, 10, 7], [12, 6, 89, 45, 3], [9, 12, 56, 10, 34], [67, 23, 1, 88, 34] ]  ==>  [22.5, 11, 38.75, 38.25, 19.5]

1st array: [  2,   3,    9,   10,    7]
2nd array: [ 12,   6,   89,   45,    3]
3rd array: [  9,  12,   56,   10,   34]
4th array: [ 67,  23,    1,   88,   34]
              |    |     |     |     |
              v    v     v     v     v
average:   [22.5, 11, 38.75, 38.25, 19.5]
*/


using System.Linq;

namespace CodeWars
{
    public class AverageArray
    {
        public static double[] AvgArray(double[][] arr)
        {
            // return Enumerable.Range(0, arr.First().Length)
            //     .Select(i => Enumerable.Range(0, arr.Length).Select(j => arr[j][i])).ToArray().Select(a => a.Average())
            //     .ToArray();

            return arr[0].Select((d, i) => arr.Average(x => x[i])).ToArray();
        }

        // public static double[] AvgArray(double[][] a)
        // {
        //     return a[0].Select((b, i) => a.Select(c => c[i]).Aggregate((d, e) => d + e) / a.Length).ToArray();
        // }

        // public static double[] AvgArray(double[][] arr)
        // {
        //     return arr.Aggregate((prev, next) => prev.Zip(next, (a, b) => (a + b)).ToArray())
        //         .Select(r => r / arr.Length).ToArray();
        // }

        // public static double[] AvgArray(double[][] arr)
        // {
        //     return Enumerable.Range(0, arr[0].Count()).Select(i => arr.Average(r => r[i])).ToArray();
        // }

        // public static double[] AvgArray(double[][] arr)
        // {
        //     for (int i = 0; i < arr[0].Length; i++)
        //     {
        //         for (int j = 1; j < arr.Length; j++)
        //         {
        //             arr[0][i] += arr[j][i];
        //         }
        //
        //         arr[0][i] /= arr.Length;
        //     }
        //
        //     return arr[0];
        // }


        //     public static double[] AvgArray(double[][] arr)
        //     {
        //         return Enumerable.Range(0, arr[0].Length)
        //             .Select(i => arr.Average(r => r[i]))
        //             .ToArray();
        //     }
    }
}