using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

//https://www.codewars.com/kata/beginner-lost-without-a-map/train/csharp
//https://www.codewars.com/kata/57f781872e3d8ca2a000007e/solutions/csharp

//Beginner - Lost Without a Map

//Given an array of integers, return a new array with each value doubled.
//For example:
//[1, 2, 3] --> [2, 4, 6]
//For the beginner, try to use the map method - it comes in very handy quite a lot so is a good one to know.

namespace CodeWars
{
    public class BeginnerLostWithoutMap
    {
        public static int[] Maps(int[] x)
        {
            return x.Select(n => n + n).ToArray();
        }

        //public static int[] Maps(int[] x)
        //{
        //    return x.Select(e => e * 2).ToArray();
        //}

        //public static int[] Maps(int[] x)
        //{
        //    for (int i = 0; i < x.Length; i++)
        //    {
        //        x[i] *= 2;
        //    }
        //    return x;
        //}

        //public static int[] Maps(int[] x)
        //{
        //    return Array.ConvertAll(x, n => n * 2);
        //}

        //public static int[] Maps(int[] x) => x.Select(y => y *= 2).ToArray();

        //public static int[] Maps(int[] x)
        //{
        //    return x.Select(i => i *= 2).ToArray();
        //}


    }
}
