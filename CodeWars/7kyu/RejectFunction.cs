/*
https://www.codewars.com/kata/52988f3f7edba9839c00037d/csharp

7 kyu
The reject() function

Implement a function which filters out array values which satisfy the given predicate.

Kata.Reject(new int[] {1, 2, 3, 4, 5, 6}, (n) => n % 2 == 0)  =>  new int[] {1, 3, 5}
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class RejectFunction
    {
        public static int[] Reject(int[] array, Func<int, bool> predicate)
        {
            //return array.Where(i => !predicate(i)).ToArray();
            return Array.FindAll(array, i => !predicate(i));
        }
    }
}