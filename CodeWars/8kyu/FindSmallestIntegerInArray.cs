
//https://www.codewars.com/kata/find-the-smallest-integer-in-the-array/train/csharp
//https://www.codewars.com/kata/55a2d7ebe362935a210000b2/solutions/csharp

//Find the smallest integer in the array

//Given an array of integers your solution should find the smallest integer.
//For example:
//Given [34, 15, 88, 2] your solution will return 2
//Given [34, -345, -1, 100] your solution will return -345
//You can assume, for the purpose of this kata, that the supplied array will not be empty.


using System;
using System.Linq;

namespace CodeWars
{
    public class FindSmallestIntegerInArray
    {
        public static int FindSmallestInt(int[] args)
        {
            return args.Min();
        }

        //public static int FindSmallestInt(int[] args) 
        //{
        //    Array.Sort(args);
        //    return args[0];
        //}

        //public static int FindSmallestInt(int[] args) 
        //{
        //    return (from e in args orderby e ascending select e).FirstOrDefault();
        //}

        //public static int FindSmallestInt(int[] args) 
        //{
        //    return Enumerable.Min(args);
        //}


        //public static int FindSmallestInt(int[] args) 
        //{
        //    int a = args.Length;
        //    int min = args[0];

        //    for(int i = 1; i < a; i++)
        //    {
        //        if(args[i] < min)
        //            min = args[i];
        //    }
        //    return min;
        //}


        //public static int FindSmallestInt(int[] args) 
        //{
        //    return args.OrderBy(a => a).First();
        //}
    }
}