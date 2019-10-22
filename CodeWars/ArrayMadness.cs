
//https://www.codewars.com/kata/speedcode-number-2-array-madness/train/csharp
//https://www.codewars.com/kata/56ff6a70e1a63ccdfa0001b1/solutions/csharp

//8 kyu
//SpeedCode #2 - Array Madness

//SpeedCode #2 - Array Madness
//Objective
//Given two integer arrays a, b, both of length >= 1,
//create a program that returns true if the sum of the squares of each element in a is strictly greater than the sum of the cubes of each element in b.

//E.g.

//Kata.ArrayMadness(new int[] {4, 5, 6}, new int[] {1, 2, 3}) => true // because 4 ** 2 + 5 ** 2 + 6 ** 2 > 1 ** 3 + 2 ** 3 + 3 ** 3
//Get your timer out. Are you ready? Ready, get set, GO!!!


using System;
using System.Linq;

namespace CodeWars
{
    public class KataArrayMadness
    {
        public static bool ArrayMadness(int[] a, int[] b)
        {
            return a.Sum(x => Math.Pow(x, 2)) > b.Sum(x => Math.Pow(x, 3));
        }


        //public static bool ArrayMadness(int[] a, int[] b) => a.Sum(n => n * n) > b.Sum(n => n * n * n);


        //public static bool ArrayMadness(int[] a, int[] b)
        //{
        //    return a.Sum(x => x * x) > b.Sum(x => x * x * x);
        //}


        //public static bool ArrayMadness(int[] a, int[] b)
        //{
        //    return a.Sum(t => Math.Pow(t, 2)) > b.Sum(t => Math.Pow(t, 3));
        //}



    }
}