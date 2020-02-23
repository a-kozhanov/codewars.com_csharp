/*
https://www.codewars.com/kata/57f609022f4d534f05000024/train/csharp
https://www.codewars.com/kata/57f609022f4d534f05000024/solutions/csharp

7 kyu
Find the stray number

You are given an odd-length array of integers, in which all of them are the same, except for one single number.
Complete the method which accepts such an array, and returns that single different number.
The input array will always be valid! (odd-length >= 3)

Examples
[1, 1, 2] ==> 2
[17, 17, 3, 17, 17, 17, 17] ==> 3
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class FindStrayNumber
    {
        public static int Stray(int[] numbers)
        {
            Console.WriteLine(string.Join(", ", numbers));
            //return numbers.Select(x => numbers.Count(c => c == x)).First();
            //return numbers.Single(x => numbers.Count(c => c == x) == 1);
            return numbers.First(x => numbers.Count(i => i == x) == 1);
        }

        // public static int Stray(int[] numbers)
        // {
        //     Array.Sort(numbers);
        //     return numbers[0] == numbers[1] ? numbers.Last() : numbers.First();
        // }

        // public static int Stray(int[] numbers)
        // {
        //     return numbers.Aggregate((a, b) => a ^ b);
        // }

        // public static int Stray(int[] numbers)
        // {
        //     return numbers.GroupBy(g => g).Single(o => o.Count() == 1).Key;
        // }

        // public static int Stray(int[] numbers)
        // {
        //     int stray = numbers[0];
        //     int sentinel = numbers[0] == numbers[1] ? numbers[0] : numbers[1];
        //     sentinel = numbers[1] == numbers[2] ? numbers[1] : numbers[0];
        //
        //     foreach (int num in numbers)
        //     {
        //         if (num != sentinel)
        //         {
        //             stray = num;
        //             break;
        //         }
        //     }
        //
        //     return stray;
        // }

        // public static int Stray(int[] numbers)
        // {
        //     int a = numbers[0];
        //     return numbers.Count(i => i != a) == 1 ? numbers.Where(i => i != a).Sum() : a;
        // }

        // public static int Stray(int[] numbers)
        // {
        //     return numbers.GroupBy(x => x).OrderBy(x => x.Count()).First().First();
        // }
    }
}