/*
https://www.codewars.com/kata/5a63948acadebff56f000018/train/csharp

7 kyu
Product Of Maximums Of Array (Array Series #2)

Introduction and Warm-up (Highly recommended)
Playing With Lists/Arrays Series
Task
Given an array/list [] of integers , Find the product of the k maximal numbers.

Notes
Array/list size is at least 3 .

Array/list's numbers Will be mixture of positives , negatives and zeros

Repetition of numbers in the array/list could occur.

Input >> Output Examples
maxProduct ({4, 3, 5}, 2) ==>  return (20)
Explanation:
Since the size (k) equal 2 , then the subsequence of size 2 whose gives product of maxima is 5 * 4 = 20 .
maxProduct ({8, 10 , 9, 7}, 3) ==>  return (720)
Explanation:
Since the size (k) equal 3 , then the subsequence of size 2 whose gives product of maxima is 8 * 9 * 10 = 720 .
maxProduct ({10, 8, 3, 2, 1, 4, 10}, 5) ==> return (9600)
Explanation:
Since the size (k) equal 5 , then the subsequence of size 2 whose gives product of maxima is 10 * 10 * 8 * 4 * 3 = 9600 .
maxProduct ({-4, -27, -15, -6, -1}, 2) ==> return (4)
Explanation:
Since the size (k) equal 2 , then the subsequence of size 2 whose gives product of maxima is -4 * -1 = 4 .
maxProduct ({10, 3, -1, -27} , 3)  return (-30)
Explanation:
Since the size (k) equal 3 , then the subsequence of size 2 whose gives product of maxima is 10 * 3 * -1 = -30 .
Playing with Numbers Series
Playing With Lists/Arrays Series
For More Enjoyable Katas
ALL translations are welcomed
Enjoy Learning !!
Zizou
*/


using System;
using System.Linq;

namespace CodeWars
{
    public class ProductOfMaximumsOfArrayArraySeries2
    {
        public static int MaxProduct(int[] arr, int size)
        {
            //return arr.OrderByDescending(x => x).Take(size).Aggregate((x, y) => x * y);
            //return arr.OrderBy(x => x).TakeLast(size).Aggregate((x, y) => x * y);
            return arr.OrderBy(i => -i).Take(size).Aggregate((x, y) => x * y);
        }


        // public static int MaxProduct(int[] arr, int size)
        // {
        //     int r = 1;
        //     Array.Sort(arr);
        //     for (int i = arr.Length - 1; i >= arr.Length - size; i--) r *= arr[i];
        //     return r;
        // }


        // public static int MaxProduct(int[] arr, int size)
        // {
        //     var r = arr.OrderByDescending(i => i).ToList();
        //     var s = 1;
        //     for (var i = 0; i < size; i++)
        //     {
        //         s *= r[i];
        //     }
        //
        //     return s;
        // }
    }
}