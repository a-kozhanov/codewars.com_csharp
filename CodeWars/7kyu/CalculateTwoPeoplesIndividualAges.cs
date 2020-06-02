/*
https://www.codewars.com/kata/58e0bd6a79716b7fcf0013b1/csharp

7 kyu
Calculate Two People's Individual Ages

Create a function that takes in the sum and age difference of two people, calculates their individual ages, 
and returns a pair of values (oldest age first) if those exist or null/None if:

sum < 0
difference < 0
Either of the calculated ages come out to be negative
*/

using System;

namespace CodeWars
{
    public class CalculateTwoPeoplesIndividualAges
    {
        public static double[] GetAges(int sum, int difference)
        {
            // Console.WriteLine($"sum: {sum}; difference: {difference}");
            // var a = (double) (sum + difference) / 2;
            // var b = (double) (sum - difference) / 2;
            // if (sum < 0 || difference < 0 || sum < difference) return null;
            // return new[] {a, b};

            return sum < 0 || difference < 0 || sum < difference
                ? null
                : new[] {(sum + difference) / 2d, (sum - difference) / 2d};
        }
    }
}