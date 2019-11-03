
/*
https://www.codewars.com/kata/find-the-remainder/train/csharp
https://www.codewars.com/kata/524f5125ad9c12894e00003f/solutions/csharp

8 kyu
Find the Remainder

Write a function that accepts two arguments and returns the remainder after dividing the larger number by the smaller number. 
Division by zero should return NaN (in C#, throw a new DivideByZeroException instead). Arguments will both be integers.
*/


using System;
using System.Linq;

namespace CodeWars
{
    public class FindRemainder
    {
        public static int Remainder(params int[] n)
        {
            return n.Max() % n.Min();
        }


        //public static int Remainder(int a, int b) => Math.Max(a, b) % Math.Min(a, b);


        //public static int Remainder(int a, int b)
        //{
        //    if(Math.Min(a, b) == 0) throw new DivideByZeroException();
        //    return Math.Max(a, b) % Math.Min(a, b);
        //}

        //public static int Remainder(int a, int b) => a > b ? a % b : b % a;


        //public static int Remainder(int a, int b) => a >= b? a % b: b % a;


        //public static int Remainder(int a, int b)
        //{
        //    if (a <= b && a != 0) return b%a;
        //    else if (b <= a && b != 0) return a%b;
        //    else throw new DivideByZeroException();
        //}


        //public static int Remainder(int a, int b)
        //{
        //    return a >= b ? a % b : b % a;
        //}

    }
}