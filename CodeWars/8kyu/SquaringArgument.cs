using System;

//https://www.codewars.com/kata/function-2-squaring-an-argument/train/csharp
//https://www.codewars.com/kata/523b623152af8a30c6000027/solutions/csharp

//Function 2 - squaring an argument
//8 kyu

//Now you have to write a function called square that takes an argument and returns the square of it.

namespace CodeWars
{
    public class SquaringArgument
    {
        public static double Square(double n)
        {
            return Math.Pow(n, 2);
        }

        //public static double Square(double x) => x * x;


        //public static double Square(double number)
        //{
        //    return number * number;
        //}


        //public static double Square(double n)
        //{
        //    return n * n;
        //}



    }
}