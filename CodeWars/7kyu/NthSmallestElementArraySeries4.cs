/*
https://www.codewars.com/kata/5a512f6a80eba857280000fc/train/csharp
https://www.codewars.com/kata/5a512f6a80eba857280000fc/solutions/csharp

7 kyu
Nth Smallest Element (Array Series #4)

Introduction and Warm-up (Highly recommended)
Playing With Lists/Arrays Series
Task
Given an array/list [] of integers , Find the Nth smallest element in this array of integers

Notes
Array/list size is at least 3 .

Array/list's numbers could be a mixture of positives , negatives and zeros .

Repetition in array/list's numbers could occur , so don't Remove Duplications .

Input >> Output Examples
nthSmallest({3,1,2} ,2) ==> return (2) 
Explanation:
Since the passed number is 2 , Then * the second smallest element in this array/list is 2*

nthSmallest({15,20,7,10,4,3} ,3) ==> return (7) 
Explanation:
Since the passed number is 3 , Then * the third smallest element in this array/list is 7*

nthSmallest({2,169,13,-5,0,-1} ,4) ==> return (2) 
Explanation:
Since the passed number is 4 , Then * the fourth smallest element in this array/list is 2*

nthSmallest({177,225,243,-169,-12,-5,2,92} ,5) ==> return (92) 
Explanation:
Since the passed number is 5 , Then * the fifth smallest element in this array/list is 92*
*/


using System;
using System.Linq;

namespace CodeWars
{
    public class NthSmallestElementArraySeries4
    {
        public static int NthSmallest(int[] arr, int pos)
        {
            return arr.OrderBy(x => x).ElementAt(--pos);
        }

        // public static int NthSmallest(int[] xs, int pos) => xs.OrderBy(x => x).ElementAt(pos - 1);


        // public static int NthSmallest(int[] arr, int pos)
        // {
        //     Array.Sort(arr);
        //     return arr[pos - 1];
        // }

        // public static int NthSmallest(int[] a, int n) => a.OrderBy(m => m).ToArray()[n - 1];

        // public static int NthSmallest(int[] arr, int pos)
        // {
        //     //Do Some Magic
        //     return arr.OrderBy(z => z).Skip(pos - 1).First();
        // }

        // public static int NthSmallest(int[] arr, int pos)
        // {
        //     return arr.OrderBy(x => x).Skip(pos - 1).First();
        // }

        // public static int NthSmallest(int[] arr, int pos)
        // {
        //     //Do Some Magic
        //     for (int i = 0; i < arr.Length; i++)
        //     {
        //         for (int j = 0; j < arr.Length - 1; j++)
        //         {
        //             if (arr[j] > arr[j + 1])
        //             {
        //                 int Buff = arr[j];
        //                 arr[j] = arr[j + 1];
        //                 arr[j + 1] = Buff;
        //             }
        //         }
        //     }
        //
        //     return arr[pos - 1];
        // }

        // public static int NthSmallest(int[] arr, int pos) => arr.OrderByDescending(i => i).ElementAt(arr.Length - pos);

        // public static int NthSmallest(int[] arr, int pos) => arr.OrderBy(v => v).Where((v, i) => i + 1 == pos).First();
    }
}