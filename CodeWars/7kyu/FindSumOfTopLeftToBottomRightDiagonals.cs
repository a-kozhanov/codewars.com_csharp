/*
https://www.codewars.com/kata/5497a3c181dd7291ce000700/csharp

7 kyu
Find sum of top-left to bottom-right diagonals

Given a square matrix (i.e. an array of subarrays), find the sum of values from the first value of the first array, 
the second value of the second array, the third value of the third array, and so on...

Examples
array = [[1, 2],
         [3, 4]]

diagonal sum: 1 + 4 = 5
array = [[5, 9, 1, 0],
         [8, 7, 2, 3],
         [1, 4, 1, 9],
         [2, 3, 8, 2]]

diagonal sum: 5 + 7 + 1 + 2 = 15
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class FindSumOfTopLeftToBottomRightDiagonals
    {
        public static int DiagonalSum(int[,] matrix)
        {
            return Enumerable.Range(0, matrix.GetLength(0)).Sum(i => matrix[i, i]);
            //return matrix.Cast<int>().Where((v, i) => i % (Math.Sqrt(matrix.Length) + 1) == 0).Sum();
        }
    }
}