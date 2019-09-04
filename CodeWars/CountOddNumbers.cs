
//https://www.codewars.com/kata/count-odd-numbers-below-n/train/csharp
//https://www.codewars.com/kata/59342039eb450e39970000a6/solutions/csharp

//Count Odd Numbers below n

//Given a number n, return the number of positive odd numbers below n, EASY!

//Kata.OddCount(7) => 3, i.e[1, 3, 5]
//Kata.OddCount(15) => 7, i.e[1, 3, 5, 7, 9, 11, 13]
//Expect large Inputs!

using System;
using System.Collections;
using System.Linq;

namespace CodeWars
{
    public class CountOddNumbers
    {
        public static ulong OddCount(ulong n)
        {

            return (ulong)Math.Floor((decimal)n / 2);
        }

        //Best Practices
        //public static ulong OddCount(ulong n)
        //{
        //    return n / 2;
        //}

        //public static ulong OddCount(ulong n) => n / 2;

    }
}