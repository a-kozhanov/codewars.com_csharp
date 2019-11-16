/*
https://www.codewars.com/kata/find-multiples-of-a-number/train/csharp
https://www.codewars.com/kata/58ca658cc0d6401f2700045f/solutions/csharp

8 kyu
Find Multiples of a Number

In this simple exercise, you will build a program that takes a value, integer, and returns a list of its multiples up to another value, limit. 
If limit is a multiple of integer, it should be included as well. 
There will only ever be positive integers passed into the function, not consisting of 0. 
The limit will always be higher than the base.
For example, if the parameters passed are (2, 6), the function should return [2, 4, 6] as 2, 4, and 6 are the multiples of 2 up to 6.
If you can, try writing it in only one line of code.

 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class FindMultiplesOfNumber
    {
        public static List<int> FindMultiples(int integer, int limit)
        {
            var result = new List<int>();
            var i = integer;

            while (i <= limit)
            {
                result.Add(i);
                i += integer;
            }

            return result;
        }

        //public static List<int> FindMultiples(int num, int limit) =>
        //    Enumerable.Range(1, limit / num)
        //        .Select(x => x * num)
        //        .ToList();


        //public static List<int> FindMultiples(int integer, int limit)
        //{
        //    List <int> result = new List<int>();
        //    for (int i = integer; i <= limit; i += integer)
        //    {
        //        result.Add(i);
        //    }
        //    return result;
        //}

        //public static List<int> FindMultiples(int integer, int limit)
        //{
        //    List<int> list = new List<int>();

        //    for (int i = integer; i <= limit; i = i + integer)
        //    {
        //        list.Add(i);
        //    }
        //    return list;
        //}

        //public static List<int> FindMultiples(int integer, int limit)
        //{
        //    return Enumerable.Range(1, limit / integer).Select(x => x * integer).ToList();
        //}

        //public static List<int> FindMultiples(int integer, int limit)
        //    => Enumerable.Range(integer, limit-integer+1).Where(x => x % integer == 0).ToList();

        //public static List<int> FindMultiples(int integer, int limit) => 
        //    Enumerable.Range(1, Int32.MaxValue)
        //        .Select(x => x * integer)
        //        .TakeWhile(x => x <= limit)
        //        .ToList();


    }
}