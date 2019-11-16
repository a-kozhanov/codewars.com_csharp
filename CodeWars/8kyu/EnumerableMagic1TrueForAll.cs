
/*
https://www.codewars.com/kata/enumerable-magic-number-1-true-for-all/train/csharp


8 kyu
Enumerable Magic #1 - True for All?

Create a method all which takes an array and a predicate (function pointer), and returns true if the predicate returns true for every element in the array. 
Otherwise, it should return false. If the array is empty, it should return true, since technically nothing failed the test.

Here's a (Ruby) resource if you get stuck: http://www.rubycuts.com/enum-all

*/


using System;
using System.Linq;

namespace CodeWars
{
    public class EnumerableMagic1TrueForAll
    {
        public static bool All(int[] arr, Func<int, bool> fun)
        {
            return arr.All(fun);
        }

        //public static bool All(int[] arr, Func<int, bool> fun)
        //{
        //    foreach (int n in arr)
        //    {
        //        if (!fun(n))
        //        {
        //            return false;
        //        }
        //    }
        //    return true;
        //}

        //public static bool All(int[] arr, Func<int, bool> fun)
        //{
        //    return arr.Where(x => fun(x)).Count() == arr.Count();
        //}


        //public static bool All(int[] arr, Func<int, bool> fun)=>Array.TrueForAll(arr, new Predicate<int>(fun));

        //public static bool All(int[] arr, Func<int, bool> fun)
        //{
        //    return arr.Length == 0 ? true : arr.All(fun);
        //}


        //public static bool All(int[] arr, Func<int, bool> fun)
        //{
        //    bool answer = true;
        //    for(int i = 0; i < arr.Length; i++)
        //    {
        //        if(!fun(arr[i]))
        //        {
        //            answer = false;
        //        }
        //    }
        //    return answer;
        //}

        //public static bool All(int[] arr, Func<int, bool> fun)
        //{
        //    foreach (int item in arr)
        //    {
        //        if (!fun(item))
        //        {
        //            return false;
        //        }
        //    }
        //    return true;
        //}

    }
}