/*
https://www.codewars.com/kata/5753b987aeb792508d0010e2/csharp

7 kyu
Every nth array element. (Basic)

Create a method (JS: function) every which returns every nth element of an array.

Usage
With no arguments, array.every it returns every element of the array.
With one argument, array.every(interval) it returns every intervalth element.
With two arguments, array.every(interval, start_index) it returns every intervalth element starting at index start_index

Note: due to fact JS translation ask for a function instead of an Array method the above uses will be :

javascript:                          ruby:
every(array)                         array.every
every(array, interval)               array.every(interval)
every(array, interval, start_index)  array.every(interval, start_index)
Examples
C# can work either as "Kata.Every" or "array.Every" due to the nature of extension functions.

new int []{0,1,2,3,4}.Every());     // [0,1,2,3,4]
Kata.Every(new int []{0,1,2,3,4}, 5, 1));         // [1]
Notes
    Test cases:

interval will always be a positive integer (but may be larger than the size of the array).
    start_index will always be within the bounds of the array.

    Once you have completed this kata, try the advanced version (http://www.codewars.com/kata/every-nth-array-element-advanced) which allows negative intervals and unbounded start_indexes

    Translator notes
Ruby is the original language for this kata.
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public static class EveryNthArrayElementBasic
    {
        public static IEnumerable<T> Every<T>(this IEnumerable<T> arr, int interval = 1, int start = 0)
        {
            return arr.Skip(start).Where((_, i) => i % interval == 0);

            // for (var i = start; i < arr.Count(); i += interval)
            // {
            //     yield return arr.ToList()[i];
            // }
        }

        // public static IEnumerable<T> Every<T>(this IEnumerable<T> arr, int interval, int start) =>
        //     arr.Skip(start).Where((x, i) => i % interval == 0);
        // public static IEnumerable<T> Every<T>(this IEnumerable<T> arr, int interval) =>
        //     arr.Where((x, i) => i % interval == 0);
        // public static IEnumerable<T> Every<T>(this IEnumerable<T> arr) => arr;
    }
}