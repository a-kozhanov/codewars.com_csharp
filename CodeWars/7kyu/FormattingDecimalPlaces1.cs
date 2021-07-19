/*
https://www.codewars.com/kata/5641c3f809bf31f008000042/csharp

7 kyu
Formatting decimal places #1

Each floating-point number should be formatted that only the first two decimal places are returned. 
You don't need to check whether the input is a valid number because only valid numbers are used in the tests.

Don't round the numbers! Just cut them after two decimal places!

Right examples:  
32.8493 is 32.84  
14.3286 is 14.32

Incorrect examples (e.g. if you round the numbers):  
32.8493 is 32.85  
14.3286 is 14.33
*/

using System;
using System.Globalization;

namespace CodeWars
{
    public class FormattingDecimalPlaces1
    {
        public static double TwoDecimalPlaces(double number)
        {
            //return double.Parse(number.ToString().Substring(0, number.ToString().IndexOf('.') + 3));
            //return double.Parse(number.ToString()[..(number.ToString().IndexOf('.') + 3)]);
            //return Math.Round(number - Math.Sign(number) * 0.005, 2);
            //return Math.Round(number, 2, MidpointRounding.ToZero);
            //return (double) (int) (number * 100) / 100;
            //return Math.Truncate(number * 100.0) / 100.0;
            //return Math.Truncate(number * 100) / 100;
            //return (int) (number * 100) / 100.0;
            //return (int) (number * 1e2) / 1e2D;
            return (int) (number * 100) / 100d;
        }
    }
}