
//https://www.codewars.com/kata/opposite-number/train/csharp
//https://www.codewars.com/kata/56dec885c54a926dcd001095/solutions/csharp

//Opposite number

//Very simple, given a number, find its opposite.

//Examples:
//1: -1
//14: -14
//-34: 34

using System;

namespace CodeWars
{
    public class OppositeNumber
    {
        public static int Opposite(int number)
        {
            return -number;
        }

        //public static int Opposite(int n)
        //{
        //    return n * -1;
        //}

        //public static int Opposite(int number)
        //{
        //    return number < 0 ? number + ((number * 2) * (-1)) : number - (number * 2);
        //}


        //public static int Opposite(int number)
        //{
        //    // Happy Coding
        //    return number - (number * 2);
        //}


        //public static int Opposite(int number)
        //{
        //    return number - number - number;
        //}
    }
}