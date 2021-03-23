/*
https://www.codewars.com/kata/54b7c8d2cd7f51a839000ebf/csharp

7 kyu
Easy mathematical callback

Task
Write the processArray function, which takes an array and a callback function as parameters. 
The callback function can be, for example, a mathematical function that will be applied on each element of this array. 
Optionally, also write tests similar to the examples below.

Examples
Array [4, 8, 2, 7, 5] after processing with function

Kata.ProcessArray(new int[] {4, 8, 2, 7, 5}, (Func<int, int>)((v) => v * 2));
will be [ 8, 16, 4, 14, 10 ].

Array [7, 8, 9, 1, 2] after processing with function

Kata.ProcessArray(new int[] {7, 8, 9, 1, 2}, (Func<int, int>)((v) => v + 5));
will be [ 12, 13, 14, 6, 7 ].
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class EasyMathematicalCallback
    {
        public static int[] ProcessArray(int[] arr, Func<int, int> callback)
        {
            return arr.Select(callback).ToArray();
        }
    }
}