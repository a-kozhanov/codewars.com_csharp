/*
https://www.codewars.com/kata/5b83c1c44a6acac33400009a/csharp

7 kyu
Find array

You are given two arrays arr1 and arr2, where arr2 always contains integers.

Write the function find_array(arr1, arr2) such that:
For arr1 = ['a', 'a', 'a', 'a', 'a'], arr2 = [2, 4] find_array returns ['a', 'a']
For arr1 = [0, 1, 5, 2, 1, 8, 9, 1, 5], arr2 = [1, 4, 7] find_array returns [1, 1, 1]
For arr1 = [0, 3, 4], arr2 = [2, 6] find_array returns [4]
For arr1=["a","b","c","d"] , arr2=[2,2,2], find_array returns ["c","c","c"]
For arr1=["a","b","c","d"], arr2=[3,0,2] find_array returns ["d","a","c"]

If either arr1 or arr2 is empty, you should return an empty arr (empty list in python, empty vector in c++). Note for c++ use std::vector arr1, arr2.
*/

using System.Linq;

namespace CodeWars
{
    public class KataFindArray
    {
        public static object[] FindArray(object[] arr1, int[] arr2)
        {
            //return arr2.Select(x => arr1.Length > x ? arr1[x] : null).Where(x => x != null).ToArray();
            //return arr1.Length >= arr2.Length ? arr2.Select(x => arr1[x]).ToArray() : new object[0];
            //return arr2.Where(x => x < arr1.Length).Select(x => arr1[x]).ToArray();

            return arr2.Select(arr1.ElementAtOrDefault).Where(o => !(o is null)).ToArray();
        }
    }
}