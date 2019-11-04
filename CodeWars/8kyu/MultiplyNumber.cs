/*
https://www.codewars.com/kata/multiply-the-number/train/csharp
https://www.codewars.com/kata/5708f682c69b48047b000e07/solutions/csharp

8 kyu
Multiply the number

Jack really likes his number five: the trick here is that you have to multiply each number by 5 raised to the number of digits of each numbers, so, for example:

multiply(3)==15
multiply(10)==250
multiply(200)==25000
multiply(0)==0
multiply(-3)==-15

*/


using System;

namespace CodeWars
{
    public class MultiplyNumber
    {
        public static int Multiply(int number)
        {
            return number * (int)Math.Pow(5, (int)Math.Log10(Math.Abs(number)) + 1);
        }


        //public static int Multiply(int number)
        //{
        //    return (int)(number * (Math.Pow(5, (Math.Abs(number) + "").Length)));
        //}


        //public static int Multiply(int number)
        //{
        //    return (int)Math.Pow(5, number.ToString().TrimStart('-').Length) * number;
        //}


        //public static int Multiply(int number)
        //{
        //    int x = 5;
        //    var tmp = number;
        //    while (tmp / 10 >= 1)
        //    {
        //        tmp /= 10;
        //        x *= 5;
        //    }
        //    return number * x;
        //}


        //public static int Multiply(int number)
        //{
        //    int n = (int)Math.Floor(Math.Log10(Math.Abs(number)) + 1);
        //    int accumulator = 1;
        //    for (int i = 0; i < n; i++) { accumulator *= 5; }
        //    return (accumulator * number);
        //}


        //public static int Multiply(int number) => number * (int)Math.Pow(5, Math.Floor(Math.Log10(Math.Abs(number)) + 1));

        //public static int Multiply(int number)
        //{
        //    var five = Math.Abs(number).ToString().Length;
        //    return (int)Math.Pow(5, five) * number;
        //}


    }
}