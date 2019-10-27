using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

//https://www.codewars.com/kata/sum-arrays/train/csharp
//https://www.codewars.com/kata/53dc54212259ed3d4f00071c/solutions/csharp

//Sum Arrays

//Write a method sum(sum_array in python, sumarray in julia, SumArray in C#) that takes an array of numbers and returns the sum of the numbers. 
//These may be integers or decimals for Ruby and any instance of Num for Haskell. The numbers can also be negative. 
//If the array does not contain any numbers then you should return 0.
//Examples
//Kata.SumArray(new int[] {1, 2, 3}) => 6
//Assumptions
//You can assume that you are only given numbers.
//You cannot assume the size of the array.
//You can assume that you do get an array and if the array is empty, return 0.

namespace CodeWars
{
    public class KataSumArrays
    {
        public static double SumArray(double[] array)
        {
            return array.Sum();
        }
    }
}
