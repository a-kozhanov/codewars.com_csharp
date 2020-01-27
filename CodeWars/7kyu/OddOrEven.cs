/*
https://www.codewars.com/kata/5949481f86420f59480000e7/train/csharp
https://www.codewars.com/kata/5949481f86420f59480000e7/solutions/csharp

7 kyu
Odd or Even?

Task:
Given an vector of numbers, determine whether the sum of all of the numbers is odd or even.

Give your answer as a String matching 'odd' or 'even'.

If the input array is empty consider it as: [0] (array with a zero).

Example:
odd_or_even(vec![0]) returns "even"
odd_or_even(vec![0, 1, 4]) returns "odd"
odd_or_even(vec![0, -1, -5]) returns "even"
Have fun!
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class KataOddOrEven
    {
        public static string OddOrEven(int[] a)
        {
            return a.Sum() % 2 == 0 ? "even" : "odd";
        }
    }
}