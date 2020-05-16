/*
https://www.codewars.com/kata/5296455e4fe0cdf2e000059f/train/csharp

7 kyu
Basic Calculator

Write a function called calculate that takes 3 values. The first and third values are numbers. 
The second value is a character. If the character is "+" , "-", "*", or "/", 
the function will return the result of the corresponding mathematical function on the two numbers. 
If the string is not one of the specified characters, the function should return null (throw an ArgumentException in C#).

calculate(2,"+", 4); //Should return 6
calculate(6,"-", 1.5); //Should return 4.5
calculate(-4,"*", 8); //Should return -32
calculate(49,"/", -7); //Should return -7
calculate(8,"m", 2); //Should return null
calculate(4,"/",0) //should return null

Keep in mind, you cannot divide by zero. 
If an attempt to divide by zero is made, return null (throw an ArgumentException in C#).
*/

using System;
using System.Data;

namespace CodeWars
{
    public class BasicCalculator
    {
        public static double Execute(double a, char op, double b)
        {
            return op switch
            {
                '+' => a + b,
                '-' => a - b,
                '*' => a * b,
                '/' => b == 0 ? throw new ArgumentException() : a / b,
                _ => throw new ArgumentException()
            };
        }
    }
}