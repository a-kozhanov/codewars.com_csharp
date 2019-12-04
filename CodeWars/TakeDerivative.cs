/*
https://www.codewars.com/kata/take-the-derivative/train/csharp
https://www.codewars.com/kata/5963c18ecb97be020b0000a2/solutions/csharp

8 kyu
Take the Derivative

This function takes two numbers as parameters, the first number being the coefficient, and the second number being the exponent. 
Your coefficient should multiply the two numbers, and then subtract 1 from the exponent. Then, it has to print out an expression (like 28x^7).

  derive(7,8) // in this case, the function should multiply 7  and 8, and then subtract 1 from 8.
It should output "56x^7", the first number 56 being the product of the two numbers, and the second number being the exponent minus 1.

  derive(7,8) // this should output "56x^7" 
  derive(5,9) // this should output "45x^8" 

The output of this function should be a string! The exponent will never be 1, and neither number will ever be 0.
*/

using System;

namespace CodeWars
{
    public class TakeDerivative
    {
        public static string Derive(double coefficient, double exponent)
        {
            return $"{coefficient * exponent}x^{exponent - 1}";
        }

        //public static string Derive(double coefficient, double exponent)
        //{
        //    return String.Format("{0}x^{1}", coefficient * exponent, exponent - 1);
        //}

        //public static string Derive(double coefficient, double exponent)
        //{
        //    return (coefficient * exponent) + "x^" + (exponent-1);
        //}
    }
}