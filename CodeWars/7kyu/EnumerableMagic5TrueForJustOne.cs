/*
https://www.codewars.com/kata/54599705cbae2aa60b0011a4/csharp

7 kyu
Enumerable Magic #5- True for Just One?

Task
Create a function called one that accepts two params:

a sequence
a function
and returns true only if the function in the params returns true for exactly one (1) item in the sequence.

Example
one([1, 3, 5, 6, 99, 1, 3], bigger_than_ten) -> true
one([1, 3, 5, 6, 99, 88, 3], bigger_than_ten) -> false
one([1, 3, 5, 6, 5, 1, 3], bigger_than_ten) -> false
If you need help, here is a resource ( in Ruby ).
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class EnumerableMagic5TrueForJustOne
    {
        public static bool One(int[] arr, Func<int, bool> fun)
        {
            return arr.Count(fun) == 1;
        }
    }
}