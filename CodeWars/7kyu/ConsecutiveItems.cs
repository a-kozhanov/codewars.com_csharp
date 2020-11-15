/*
https://www.codewars.com/kata/5f6d533e1475f30001e47514/csharp

7 kyu
Consecutive items

You are given a list of unique integers arr, and two integers a and b. 
Your task is to find out whether or not a and b appear consecutively in arr, 
and return a boolean value (True if a and b are consecutive, False otherwise).

It is guaranteed that a and b are both present in arr.
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class ConsecutiveItems
    {
        public static bool Consecutive(int[] arr, int a, int b)
        {
            return Math.Abs(arr.ToList().IndexOf(a) - arr.ToList().IndexOf(b)) == 1;
            //return Math.Abs(Array.IndexOf(arr, a) - Array.IndexOf(arr, b)) == 1;
        }
    }
}