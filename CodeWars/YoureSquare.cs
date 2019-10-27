/*
https://www.codewars.com/kata/youre-a-square/train/csharp
https://www.codewars.com/kata/54c27a33fb7da0db0100040e/solutions/csharp

7 kyu
You're a square!

A square of squares
You like building blocks. You especially like building blocks that are squares. And what you even like more, is to arrange them into a square of square building blocks!

However, sometimes, you can't arrange them into a square. Instead, you end up with an ordinary rectangle! Those blasted things! If you just had a way to know, whether you're currently working in vain… Wait! That's it! You just have to check if your number of building blocks is a perfect square.

Task
Given an integral number, determine if it's a square number:

In mathematics, a square number or perfect square is an integer that is the square of an integer; in other words, it is the product of some integer with itself.

The tests will always use some integral number, so don't worry about that in dynamic typed languages.

Examples
isSquare(-1) returns  false
isSquare(0) returns   true
isSquare(3) returns   false
isSquare(4) returns   true
isSquare(25) returns  true  
isSquare(26) returns  false

*/

using System;
using System.Linq;

namespace CodeWars
{
    public class YoureSquare
    {
        public static bool IsSquare(int n)
        {
            return Math.Sqrt(n) % 1 == 0;
        }



        //public static bool IsSquare(int n)
        //{
        //    return Math.Sqrt(n) == (int)Math.Sqrt(n);
        //}


        //public static bool IsSquare(int n)
        //{
        //    return n < 0 ? false : Math.Sqrt(n) == Math.Round(Math.Sqrt(n));
        //}


        //public static bool IsSquare(int n) => (Math.Sqrt(n) % 1 == 0);


        //public static bool IsSquare(int n)
        //{
        //    return Math.Abs(Math.Sqrt(n) - (int)Math.Sqrt(n)) < double.Epsilon;
        //}


        //public static bool IsSquare(int n) => Math.Abs(Math.Sqrt(n) % 1) < double.Epsilon;


        //public static bool IsSquare(int n)
        //{
        //    return Int32.TryParse(Math.Sqrt(n).ToString(), out int num);
        //}


        //public static bool IsSquare(int n)
        //{
        //    return Math.Pow(Math.Floor(Math.Sqrt(n)), 2) == n;
        //}


        //public static bool IsSquare(int n)
        //{
        //    //Your code goes here!
        //    return n == Math.Pow(Math.Floor(Math.Sqrt(n)), 2);
        //}


    }
}