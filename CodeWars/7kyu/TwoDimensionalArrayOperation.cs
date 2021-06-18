/*
https://www.codewars.com/kata/60bcef3c4a3ef30015bc05dd/csharp

7 kyu
Two-Dimensional Array Operation

Calculate the product of all the sum of the rows.

-The length and width of the array may be different (from 1 to 5).

-All integers are between 1 and 9.

Example :
[0, 4, 8, 5], 0+4+8+5 = 17
[2, 4, 7, 1], 2+4+7+1 = 14
[7, 5, 3, 2], 7+5+3+2 = 17
[2, 9, 2, 6], 2+9+2+6 = 19
17 * 14 * 17 * 19 = 76874
*/

using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class TwoDimensionalArrayOperation
    {
        public static int Result(int[,] array)
        {
            return Enumerable.Range(0, array.GetLength(0))
                .Select(x => Enumerable.Range(0, array.GetLength(1)).Sum(i => array[x, i]))
                .Aggregate(1, (a, b) => a * b);


            // var result = 1;
            // for (var i = 0; i < array.GetLength(0); i++)
            // {
            //     result *= Enumerable.Range(0, array.GetLength(1)).Sum(j => array[i, j]);
            // }
            //
            // return result;


            // return Enumerable.Range(0, array.GetLength(0)).Aggregate(1,
            //     (acc, i) => acc * Enumerable.Range(0, array.GetLength(1)).Sum(j => array[i, j]));


            // var result = 1;
            // for (var i = 0; i < array.GetLength(0); i++)
            // {
            //     var sum = 0;
            //     for (var j = 0; j < array.GetLength(1); j++)
            //     {
            //         sum += array[i, j];
            //     }
            //
            //     result *= sum;
            // }
            //
            //
            // return result;
        }
    }
}