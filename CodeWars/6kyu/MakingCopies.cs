/*
https://www.codewars.com/kata/53d2697b7152a5e13d000b82/csharp

7 kyu
Making Copies

Write a function that takes a list (in Python) or array (in other languages) of numbers, and makes a copy of it.

Note that you may have troubles if you do not return an actual copy, item by item, just a pointer or an alias for an existing list or array.

If not a list or array is given as a parameter in interpreted languages, the function should raise an error.

Examples:

List<int> lst = new int[] {1, 2, 3, 4}.ToList();
List<int> lstCopy = lst.Copy();
lst[1] += 5;
lst == {1, 7, 3, 4};
lstCopy == {1, 2, 3, 4};
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public static class MakingCopies
    {
        public static List<T> Copy<T>(this List<T> lst)
        {
            //return new List<T>(lst);
            return lst.ToList();
        }
    }
}