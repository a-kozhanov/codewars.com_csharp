/*
https://www.codewars.com/kata/summing-a-numbers-digits/train/csharp
https://www.codewars.com/kata/52f3149496de55aded000410/solutions/csharp

7 kyu
Summing a number's digits

Write a function named sumDigits which takes a number as input and returns the sum of the absolute value of each of the number's decimal digits. For example:

  SumDigits(10)  // Returns 1
  SumDigits(99)  // Returns 18
  SumDigits(-32) // Returns 5
Let's assume that all numbers in the input will be integer values.
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class SummingNnumbersDigits
    {
        public static int SumDigits(int number)
        {
            return Math.Abs(number).ToString().Select(x => int.Parse(x.ToString())).Sum();
        }

        // public static int SumDigits(int number)
        // {
        //     return (int) number.ToString().Sum(x => char.IsNumber(x) ? char.GetNumericValue(x) : 0);
        // }
        //
        // public static int SumDigits(int n) => n.ToString().Sum(t => t == '-' ? 0 : t - 48);
        //
        //
        // public static int SumDigits(int number)
        // {
        //     List<int> digits=new List<int>();
        //
        //     foreach(char c in Math.Abs(number).ToString())
        //         digits.Add(int.Parse(c.ToString()));
        //
        //
        //     return digits.Sum();
        // }
        //
        //
        // public static int SumDigits(int number) => (int)(Math.Abs(number) + "").Select(char.GetNumericValue).Sum();
        
    }
}