using System;
using System.Collections.Generic;
using System.Text;

//https://www.codewars.com/kata/544675c6f971f7399a000e79
//

//Convert a String to a Number!

//Note: This kata is inspired by Convert a Number to a String!. Try that one too.

//Description
//We need a function that can transform a string into a number. What ways of achieving this do you know?
//Note: Don't worry, all inputs will be strings, and every string is a perfectly valid representation of an integral number.

//Examples
//StringToNumber("1234") == 1234
//StringToNumber("605") == 605
//StringToNumber("1405") == 1405
//StringToNumber("-7") == -7

namespace CodeWars
{
    public class ConvertStringToNumber
    {
        public static int StringToNumber(String str)
        {
            return int.Parse(str);
        }

        //public static int StringToNumber(String str)
        //{
        //    return Convert.ToInt32(str);
        //}

        //public static int StringToNumber(String str)
        //{
        //    var ok = int.TryParse(str, out var number);
        //    return number;
        //}
    }
}
