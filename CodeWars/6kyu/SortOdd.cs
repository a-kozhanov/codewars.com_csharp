/*
https://www.codewars.com/kata/578aa45ee9fd15ff4600090d/csharp

6 kyu
Sort the odd

You have an array of numbers.
Your task is to sort ascending odd numbers but even numbers must be on their places.

Zero isn't an odd number and you don't need to move it. If you have an empty array, you need to return it.

Example
sortArray([5, 3, 2, 8, 1, 4]) == [1, 3, 2, 8, 5, 4]
*/

using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class SortOdd
    {
        public static int[] SortArray(int[] array)
        {
            var odds = new Queue<int>(array.Where(i => i % 2 == 1).OrderBy(i => i));
            return array.Select(i => i % 2 == 1 ? odds.Dequeue() : i).ToArray();


            // var odds = array.Where(x => x % 2 == 1).OrderBy(x => x).ToArray();
            // int index = 0;
            //
            // for (int i = 0; i < array.Length; i++)
            // {
            //     if (array[i] % 2 == 1) array[i] = odds[index++];
            // }
            //
            // return array;


            // var odds = array.Where(x => x % 2 == 1).OrderBy(x => x).ToArray();
            // var oddsPlaced = 0;
            // return array.Select(x => x % 2 == 1 ? odds[oddsPlaced++] : x).ToArray();


            // var odds = new Stack(array.Where(x => x % 2 != 0).OrderByDescending(c => c).ToArray());
            // return array.Select(x => x % 2 != 0 ? (int) odds.Pop() : x).ToArray();


            // var odds = new Queue<int>(array.Where(i => i % 2 != 0).OrderBy(i => i));
            // return array.Select(i => i % 2 == 0 ? i : odds.Dequeue()).ToArray();


            // int temp;
            // for (var i = 0; i < array.Length; i++)
            // {
            //     if (array[i] % 2 == 0)
            //         continue;
            //
            //     for (var j = i + 1; j < array.Length; j++)
            //     {
            //         if (array[j] % 2 == 0 || array[i] <= array[j]) continue;
            //
            //         temp = array[i];
            //         array[i] = array[j];
            //         array[j] = temp;
            //     }
            // }
            //
            // return array;
        }
    }
}