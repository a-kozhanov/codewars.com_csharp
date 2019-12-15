/*
https://www.codewars.com/kata/pole-vault-starting-marks/csharp
https://www.codewars.com/kata/5786f8404c4709148f0006bf/solutions/csharp

8 kyu
Pole Vault Starting Marks


For a pole vaulter, it is very important to begin the approach run at the best possible starting mark. 
This is affected by numerous factors and requires fine-tuning in practice. 
But there is a guideline that will help a beginning vaulter start at approximately the right location for the so-called "three-step approach," 
based on the vaulter's body height.

This guideline was taught to me in feet and inches, 
but due to the international nature of Codewars, 
I am creating this kata to use metric units instead.

You are given the following two guidelines to begin with: (1) A vaulter with a height of 1.52 meters should start at 9.45 meters on the runway. 
(2) A vaulter with a height of 1.83 meters should start at 10.67 meters on the runway.

You will receive a vaulter's height in meters (which will always lie in a range between a minimum of 1.22 meters and a maximum of 2.13 meters). 
Your job is to return the best starting mark in meters, rounded to two decimal places.

Hint: Based on the two guidelines given above, you will want to account for the change in starting mark per change in body height. 
This involves a linear relationship. But there is also a constant offset involved. 
If you can determine the rate of change described above, you should be able to determine that constant offset.

*/

using System;

namespace CodeWars
{
    public class PoleVaultStartingMarks
    {
        public static double StartingMark(double bodyHeight)
        {
            return Math.Round((3.935 * bodyHeight + 10.67 - 3.935 * 1.83) * 100) / 100;
        }


        //public static double StartingMark(double bodyHeight) => Math.Round(1.22 / 0.31 * bodyHeight + 9.45 - (1.52 * 1.22 / 0.31), 2);

        //public static double StartingMark(double bodyHeight)
        //{
        //    double delta = (11.85 - 8.27) / (2.13 - 1.22);
        //    return Math.Round(11.85 - (2.13 - bodyHeight) * delta, 2);
        //}

        //public static double StartingMark(double bodyHeight)
        //{
        //    return Math.Round(1.22 / 0.31 * bodyHeight + 9.45 - (1.52 * 1.22 / 0.31), 2);
        //}

    }
}