/*
https://www.codewars.com/kata/56b5dd1702a30326ce000b02/csharp

7 kyu
Basics 04: Rotate Matrix

Your task is to rotate a matrix 90 degree to the left. 
The matrix is an array of integers with dimension n,m. 
So this kata checks some basics, it's not too difficult.

There's nothing more to explain, no tricks, no "bad cases";-). Perhaps you take a look at the testcases...

One easy example:

Input: {{-1, 4, 5},
        { 2, 3, 4}}

Output: {{ 5, 4},
         { 4, 3},
         {-1, 2}}
First there are some static tests, later on random tests too...


Hope you have fun:-)!
*/

namespace CodeWars
{
    public class Basics04RotateMatrix
    {
        public int[,] rotateMatrixLeft(int[,] matrix)
        {
            var w = matrix.GetLength(0);
            var h = matrix.GetLength(1);
            var result = new int[h, w];

            for (var i = 0; i < w; i++)
            for (var j = 0; j < h; j++)
                result[h - j - 1, i] = matrix[i, j];

            return result;
        }
    }
}