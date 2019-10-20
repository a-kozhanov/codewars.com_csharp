

//https://www.codewars.com/kata/enumerable-magic-number-3-does-my-list-include-this/train/csharp
//https://www.codewars.com/kata/545991b4cbae2a5fda000158/solutions/csharp

//Enumerable Magic #3 - Does My List Include This?
//8 kyu

//Create a method that accepts a list and an item, and returns true if the item belongs to the list, otherwise false.


using System;
using System.Linq;

namespace CodeWars
{
    public class EnumerableMagic3
    {
        public static bool Include(int[] arr, int item)
        {
            return arr.Contains(item);
        }


        //public static bool Include(int[] arr, int item) => Array.IndexOf(arr, item) != -1;


        //public static bool Include(int[] arr, int item)
        //{
        //    return arr.Any(x => x == item);
        //}


        //public static bool Include(int[] arr, int item)
        //{
        //    return Array.Exists(arr, x => x == item);
        //}

        //public static bool Include(int[] arr, int item)
        //{
        //    bool retVal = false;

        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if (arr[i] == item)
        //            retVal = true;
        //    }

        //    return retVal;
        //}

        //public static bool Include(int[] arr, int item)
        //{
        //    return Array.FindIndex(arr, i => i == item) > -1;
        //}


        //public static bool Include(int[] arr, int item)
        //{
        //    return arr.Where(n => n == item).Count() > 0;
        //}


        //public static bool Include(int[] arr, int item)
        //{
        //    return arr.Count(n => n == item) > 0;
        //}


        //public static bool Include(int[] arr, int item)
        //{
        //    return Array.IndexOf(arr, item) >= 0;
        //}




    }
}