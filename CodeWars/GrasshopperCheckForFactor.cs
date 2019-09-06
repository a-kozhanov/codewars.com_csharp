﻿
//https://www.codewars.com/kata/grasshopper-check-for-factor/train/csharp
//https://www.codewars.com/kata/55cbc3586671f6aa070000fb/solutions/csharp

//Grasshopper - Check for factor

//Check for Factor
//This function should test if the factor is a factor of base.
//Return true if it is a factor or false if it is not.
//Information
//Factors are numbers you can multiply together to get another number.
//2 and 3 are factors of 6 because:
//2 * 3 = 6
//You can find a factor by dividing numbers. If the remainder is 0 then the number is a factor.
//In Javascript and C# you can use % to check for a remainder
//For example 2 is not a factor of 7 because:
//7 % 2 = 1

using System;

namespace CodeWars
{
    public class GrasshopperCheckForFactor
    {
        public static bool CheckForFactor(int num, int factor)
        {
            return num % factor == 0;
        }

        //public static bool CheckForFactor(int num, int factor)
        //{
        //    return num % factor != 0 ? false : true;
        //}

        //public static bool CheckForFactor(int num, int factor)
        //{
        //    return true ? num % factor == 0 : false;
        //}
    }
}