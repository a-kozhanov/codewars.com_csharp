using System;
using System.Collections.Generic;
using System.Text;

//https://www.codewars.com/kata/make-a-function-that-does-arithmetic/train/csharp
//https://www.codewars.com/kata/583f158ea20cfcbeb400000a/solutions/csharp

//Given two numbers and an arithmetic operator (the name of it, as a string), return the result of the two numbers having that operator used on them.

//a and b will both be positive integers, and a will always be the first number in the operation, and b always the second.

//The four operators are "add", "subtract", "divide", "multiply".

//A few examples:

//Kata.Arithmetic(5, 2, "add") => 7
//Kata.Arithmetic(5, 2, "subtract") => 3
//Kata.Arithmetic(5, 2, "multiply") => 10
//Kata.Arithmetic(5, 2, "divide")   => 2.5
//Try to do it without using if statements!

namespace CodeWars
{
    public static class Arithmetic
    {
        public static double arithmetic(double a, double b, string op)
        {
            switch (op)
            {
                case "add":
                    return a + b;
                case "subtract":
                    return a - b;
                case "multiply":
                    return a * b;
                case "divide":
                    return a / b;
                default:
                    return 0;
            }
        }

        //Best Practices
        //public static double Arithmetic(double a, double b, string op)
        //{
        //    switch (op)
        //    {
        //        case "add":
        //            return a + b;
        //        case "subtract":
        //            return a - b;
        //        case "multiply":
        //            return a * b;
        //        case "divide":
        //            return a / b;
        //        default:
        //            return Double.NaN;
        //    }
        //}

    }

}
