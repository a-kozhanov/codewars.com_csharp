using System;
using System.Collections.Generic;
using System.Text;

//https://www.codewars.com/kata/convert-a-number-to-a-string/train/csharp
//https://www.codewars.com/kata/5265326f5fda8eb1160004c8/solutions/csharp

//Convert a Number to a String!

//We need a function that can transform a number into a string.
//What ways of achieving this do you know?

//Examples:
//Kata.NumberToString(123) => "123";
//Kata.NumberToString(999) => "999";

namespace CodeWars
{
    public class ConvertNumberToString
    {
        public static string NumberToString(int num)
        {
            return num.ToString();
        }
        //Best Practices

    }
}
