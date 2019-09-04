using System;

//
//https://www.codewars.com/kata/57a5c31ce298a7e6b7000334/solutions/csharp

//Bin to Decimal

//Complete the function which converts a binary number (given as a string) to a decimal number.


namespace CodeWars
{
    public class BinToDecimal
    {
        public static int binToDec(string s)
        {
            return Convert.ToInt32(s, 2);
        }
    }
}