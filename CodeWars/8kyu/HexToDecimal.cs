
//https://www.codewars.com/kata/hex-to-decimal/train/csharp
//https://www.codewars.com/kata/57a4d500e298a7952100035d/solutions/csharp

//Hex to Decimal
//8 kyu

//Complete the function which converts hex number (given as a string) to a decimal number.


using System;

namespace CodeWars
{
    public class HexToDecimal
    {
        public static int HexToDec(string hexString)
        {
            return hexString.StartsWith("-") ? -Convert.ToInt32(hexString.Replace("-", ""), 16) : Convert.ToInt32(hexString, 16);
        }

        //public static int HexToDec(string hexString)
        //{
        //    return Convert.ToInt32(hexString.TrimStart('-'), 16) * (hexString[0] == '-' ? -1 : 1);
        //}

        //public static int HexToDec(string hexString)
        //{
        //    var n = Convert.ToInt32(hexString.Replace("-", ""), 16);
        //    return hexString.StartsWith("-") ? n * -1 : n;
        //}

        //public static int HexToDec(string hexString)
        //{
        //    return Convert.ToInt32(hexString.TrimStart('-'), 16) * (hexString.StartsWith("-") ? -1 : 1);
        //}

        //public static int HexToDec(string hexString)
        //{
        //    return (hexString.Contains('-') ? -1 : 1) * Convert.ToInt32(hexString.TrimStart('-'), 16);
        //}

        //public static int HexToDec(string hexString)
        //{
        //    return hexString[0]!='-'? Convert.ToInt32(hexString, 16): -Convert.ToInt32(hexString.Replace("-",""), 16);
        //}




    }
}