/*
https://www.codewars.com/kata/57c7231c484cf9e6ac000090/csharp

7 kyu
Adding values of arrays in a shifted way

You have to write a method, that gets two parameter:

1. An array of arrays with int-numbers
2. The shifting value
#The method should add the values of the arrays to one new array.

The arrays in the array will all have the same size and this size will always be greater than 0.
The shifting value is always a value from 0 up to the size of the arrays.
There are always arrays in the array, so you do not need to check for null or empty.

#1. Example:

[[1,2,3,4,5,6], [7,7,7,7,7,-7]], 0

1,2,3,4,5,6
7,7,7,7,7,-7

--> [8,9,10,11,12,-1]
#2. Example

[[1,2,3,4,5,6], [7,7,7,7,7,7]], 3

1,2,3,4,5,6
      7,7,7,7,7,7

--> [1,2,3,11,12,13,7,7,7]
#3. Example

[[1,2,3,4,5,6], [7,7,7,-7,7,7], [1,1,1,1,1,1]], 3


1,2,3,4,5,6
      7,7,7,-7,7,7
            1,1,1,1,1,1

--> [1,2,3,11,12,13,-6,8,8,1,1,1]
Have fun coding it and please don't forget to vote and rank this kata! :-)

I have created other katas. Have a look if you like coding and challenges.
*/

using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class AddingValuesOfArraysInShiftedWay
    {
        public static int[] AddingShifted(int[][] arrayOfArrays, int shift)
        {
            return arrayOfArrays.Select((x, i) => Enumerable.Repeat(0, i * shift).Concat(x))
                .Aggregate((a, b) => a.Concat(Enumerable.Repeat(0, shift)).Zip(b, (m, n) => m + n)).ToArray();


            // return Enumerable.Range(1, arrayOfArrays[0].Length + shift * (arrayOfArrays.Length - 1)).Select(c =>
            //         arrayOfArrays.Select((x, r) =>
            //             c > r * shift && c - 1 - r * shift < arrayOfArrays[0].Length ? x[c - 1 - r * shift] : 0).Sum())
            //     .ToArray();


            // return arrayOfArrays.Select((arr, i) => Enumerable.Repeat(0, shift * i).Concat(arr)
            //         .Concat(Enumerable.Repeat(0, shift * (arrayOfArrays.Length - 1 - i))))
            //     .Aggregate((a, b) => a.Zip(b, (x, y) => x + y)).ToArray();


            // int[] result = new int[arrayOfArrays[0].Length + shift * (arrayOfArrays.Length - 1)];
            // for (var i = 0; i < arrayOfArrays.Length; i++)
            // {
            //     result = result.Concat(new int[] { }.Concat(new int[shift * i]).Concat(arrayOfArrays[i]))
            //         .Zip(new int[] { }.Concat(new int[shift * i]).Concat(arrayOfArrays[i]), (a, b) => a + b).ToArray();
            // }
            //
            // return result;
        }
    }
}