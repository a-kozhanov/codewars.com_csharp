/*
https://www.codewars.com/kata/58545549b45c01ccab00058c/csharp

7 kyu
Calculate Meal Total

Create a function that returns the total of a meal including tip and tax. You should not tip on the tax.
You will be given the subtotal, the tax as a percentage and the tip as a percentage. 
Please round your result to two decimal places.
*/

using System;

namespace CodeWars
{
    public class CalculateMealTotal
    {
        public static double CalculateTotal(double subtotal, int tax, int tip)
        {
            //return Math.Round(subtotal + subtotal * (tax + tip) * 0.01, 2);
            //return Math.Round((1 + 0.01 * tax + 0.01 * tip) * subtotal, 2);
            return Math.Round(subtotal * (1 + (tax + tip) / 100.0), 2);
        }
    }
}