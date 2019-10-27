using System;
using System.Collections.Generic;
using System.Text;

//https://www.codewars.com/kata/even-or-odd/train/csharp
//https://www.codewars.com/kata/53da3dbb4a5168369a0000fe/solutions/csharp

//Even or Odd

//Create a function (or write a script in Shell) that takes an integer as an argument and returns "Even" for even numbers or "Odd" for odd numbers.


namespace CodeWars
{
    public class EvenOdd
    {
        public static string EvenOrOdd(int number)
        {
            return number % 2 == 0 ? "Even" : "Odd";
        }

        //public static string EvenOrOdd(int number)
        //{
        //    return Convert.ToBoolean(number & 1) ? "Odd" : "Even";
        //}

        //public static string EvenOrOdd(int number)
        //{
        //    return Convert.ToBoolean(number & 1) ? "Odd" : "Even";
        //}
    }
}
