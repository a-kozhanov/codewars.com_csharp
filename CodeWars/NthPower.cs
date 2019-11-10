
/*
https://www.codewars.com/kata/n-th-power/train/csharp
https://www.codewars.com/kata/57d814e4950d8489720008db/solutions/csharp

8 kyu
N-th Power


This kata is from check py.checkio.org

You are given an array with positive numbers and a number N. You should find the N-th power of the element in the array with the index N. If N is outside of the array, then return -1. Don't forget that the first element has the index 0.

Let's look at a few examples:

array = [1, 2, 3, 4] and N = 2, then the result is 3^2 == 9;
array = [1, 2, 3] and N = 3, but N is outside of the array, so the result is -1.

*/


using System;

namespace CodeWars
{
    public class NthPower
    {
        public static double Index(int[] array, int n)
        {
            try
            {
                return Math.Pow(array[n], n);
            }
            catch
            {
                return -1;
            }
        }


        //public static double Index(int[] array, int n) => n < array.Length ? Math.Pow(array[n], n) : -1;

        //public static double Index(int[] array, int n)
        //{
        //    return (n >= array.Length) ? -1 : Math.Pow(array[n], n);
        //}


        //public static double Index(int[] array, int n)
        //{
        //    try
        //    {
        //        return System.Math.Pow(array[n], n);
        //    }
        //    catch (System.IndexOutOfRangeException)
        //    {
        //        return -1;
        //    }
        //}


        //public static double Index(int[] array, int n)
        //{
        //    return array.Length - 1 < n ? -1 : (double)Math.Pow(array[n], n);
        //}


        //public static double Index(int[] array, int n)
        //{
        //    if ((array.Length - 1) < n)
        //    {
        //        return -1;
        //    }
        //    return Math.Pow((double)array[n], (double)n);
        //}


        //public static double Index(int[] array, int n) => n >= 0 && array.Length - 1 >= n ? Math.Pow(array[n], n) : -1;

        //public static double Index(int[] array, int n)
        //{
        //    if (n < 0 || array.Length <= n)
        //    {
        //        return -1;
        //    }
        //    return Math.Pow(array[n], n);
        //}


    }
}