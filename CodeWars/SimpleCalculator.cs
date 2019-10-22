

//https://www.codewars.com/kata/simple-calculator/train/csharp
//https://www.codewars.com/kata/5810085c533d69f4980001cf/solutions/csharp

//8 kyu
//simple calculator


//You are required to create a simple calculator that returns the result of addition, subtraction, multiplication or division of two numbers.

//Your function will accept three arguments:
//The first and second argument will be numbers.
//The third argument will represent a sign indicating the operation to perform on these two numbers.

//Example:
//Kata.Calculator(1, 2, '+') => 3
//If the sign is not a valid sign, throw an ArgumentException.

//Example:
//Kata.Calculator(1, 2, '$') // throws ArgumentException
//Good luck!


using System;

namespace CodeWars
{
    public class SimpleCalculator
    {
        public static double Calculator(double a, double b, char op)
        {
            switch (op)
            {
                case '+': return a + b;
                case '-': return a - b;
                case '*': return a * b;
                case '/': return a / b;
                default: throw new ArgumentException();
            }
        }

        //public static double Calculator(double a, double b, char op)
        //{
        //    return (op == '+') ? a + b : (op == '-') ? a - b : (op == '*') ? a * b : (op == '/') ? a / b : throw new System.ArgumentException();
        //}



        //public static double Calculator(double a, double b, char op)
        //{

        //    switch (op)
        //    {
        //        case '+':
        //            return a + b;
        //        case '-':
        //            return a - b;
        //        case '*':
        //            return a * b;
        //        case '/':
        //            return a / b;
        //        default:
        //            throw new System.ArgumentException("Parameter cannot be null", "original");
        //    }

        //}



        //public static double Calculator(double a, double b, char op)
        //{
        //    return op == '+' ? a + b : op == '-' ? a - b : op == '*' ? a * b : op == '/' ? a / b : throw new ArgumentException();
        //}






    }
}