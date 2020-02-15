/*
https://www.codewars.com/kata/57be674b93687de78c0001d9/train/csharp
https://www.codewars.com/kata/57be674b93687de78c0001d9/solutions/csharp

7 kyu
Powers of 3

Given a positive integer N, return the largest integer k such that 3^k < N.

For example,
Kata.LargestPower(3) => 0
Kata.LargestPower(4) => 1
You may assume that the input to your function is always a positive integer.
*/


using System;

namespace CodeWars
{
    public class PowersOf3
    {
        public static int LargestPower(int n)
        {
            //var k = 0;
            //while (Math.Pow(3, k) < n) k++;
            //return k - 1;

            //return (int)Math.Ceiling(Math.Log10(n) / Math.Log10(3)) - 1;
            return (int)Math.Ceiling(Math.Log(n, 3)) - 1;
        }


        //public static int LargestPower(int n) => (int)Math.Ceiling(Math.Log(n, 3)) - 1;


        //public static int LargestPower(int n)
        //{
        //    int k = 0;
        //    while (Math.Pow(3, k) < n)
        //    {
        //        k++;
        //    }
        //    return k - 1;
        //}


        //public static int LargestPower(int n)
        //{
        //    int k = 0;
        //    while (Math.Pow(3, k) < n)
        //    {
        //        k++;
        //    }
        //    return --k;
        //}


        //public static int LargestPower(int n)
        //{
        //    int k = (int)Math.Log(n, 3);
        //    int hh = (int)Math.Pow(3, k);
        //    k = n > hh ? k : k - 1;
        //    return k;
        //}


        //public static int LargestPower(int n)
        //{

        //    double result = 0;
        //    int count = -2;

        //    for (int i = 0; result < n; i++)
        //    {
        //        result = Math.Pow(3, i);
        //        count++;
        //    }

        //    return count;
        //}

    }
}