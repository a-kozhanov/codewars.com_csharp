using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

//https://www.codewars.com/kata/57356c55867b9b7a60000bd7/train/csharp
//https://www.codewars.com/kata/57356c55867b9b7a60000bd7/solutions/csharp

//Basic Mathematical Operations
//8 kyu

//Your task is to create a function that does four basic mathematical operations.
//The function should take three arguments - operation(string/char), value1(number), value2(number).
//The function should return result of numbers after applying the chosen operation.

//Examples:
//basicOp('+', 4, 7)         // Output: 11
//basicOp('-', 15, 18)       // Output: -3
//basicOp('*', 5, 5)         // Output: 25
//basicOp('/', 49, 7)        // Output: 7


namespace CodeWars
{
    public class BasicMathematicalOperations
    {
        public static double basicOp(char operation, double value1, double value2)
        {
            // switch (operation)
            // {
            //     case '+':
            //         return value1 + value2;
            //     case '-':
            //         return value1 - value2;
            //     case '*':
            //         return value1 * value2;
            //     case '/':
            //         return value1 / value2;
            // }
            //
            // return 0;

            // return operation switch
            // {
            //     '+' => value1 + value2,
            //     '-' => value1 - value2,
            //     '*' => value1 * value2,
            //     '/' => value1 / value2,
            //     _ => throw new ArgumentException("Unknown operation", $"{operation}")
            // };


            return Convert.ToDouble(new DataTable().Compute($"{value1}{operation}{value2}", ""));
        }
    }
}