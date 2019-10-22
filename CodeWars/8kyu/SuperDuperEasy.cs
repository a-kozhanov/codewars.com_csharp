using System;

//https://www.codewars.com/kata/super-duper-easy/train/csharp
//https://www.codewars.com/kata/55a5bfaa756cfede78000026/solutions/csharp

//Super Duper Easy
//8 kyu

//Make a function that returns the value multiplied by 50 and increased by 6. If the value entered is a string it should return "Error".
//Note: in C#, you'll always get the input as a string, so the above applies if the string isn't representing a double value.

namespace CodeWars
{
    public class SuperDuperEasy
    {
        public static string Problem(String a)
        {
            var isNum = double.TryParse(a, out var result);
            return isNum ? (result * 50 + 6).ToString() : "Error";
        }


        //public static String Problem(String Input)
        //{
        //    Double value;
        //    return (Double.TryParse(Input, out value)) ? (value * 50 + 6).ToString() : "Error";
        //}


        //public static string Problem(String a) => double.TryParse(a, out double n) ? $"{n*50+6}" : "Error";


        //public static string Problem(String a)
        //{
        //    return double.TryParse(a, out double r) ? (r * 50 + 6).ToString() : "Error";
        //}




    }
}