/*
https://www.codewars.com/kata/what-is-between/train/csharp
https://www.codewars.com/kata/55ecd718f46fba02e5000029/solutions/csharp

8 kyu
What is between?

Write a function taking two parameters and returning an int array of all elements between the input parameters and including them.
*/

using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class WhatIsBetween
    {
        public static int[] Between(int a, int b)
        {
            var result = new List<int>();
            for (var i = a; i <= b; i++)
            {
                result.Add(i);
            }
            return result.ToArray();
        }


        //public static int[] Between(int a, int b)
        //{
        //    return Enumerable.Range(a, b - a + 1).ToArray();
        //}

        //public static int[] Between(int a, int b) => Enumerable.Range(a, b - a + 1).ToArray();


        //public static int[] Between(int a, int b)
        //{
        //    return Enumerable.Range(Min(a, b), Abs(a - b) + 1).ToArray();
        //}


        //public static int[] Between(int a, int b) {
        //    return Enumerable.Range(a, b - a + 1).ToArray();
        //}


        //public static int[] Between(int a, int b) => Enumerable.Range(a,b-a+1).ToArray();


        //public static int[] Between(int a, int b) => Enumerable.Range(a,b-a+1).Select(i=>i).ToArray();



    }
}