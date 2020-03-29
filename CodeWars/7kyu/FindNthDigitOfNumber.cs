/*
https://www.codewars.com/kata/577b9960df78c19bca00007e/train/csharp
https://www.codewars.com/kata/577b9960df78c19bca00007e/solutions/csharp

7 kyu
Find the nth Digit of a Number

Complete the function that takes two numbers as input, 
num and nth and return the nth digit of num (counting from right to left).

Note
If num is negative, ignore its sign and treat it as a positive value
If nth is not positive, return -1
Keep in mind that 42 = 00042. This means that findDigit(42, 5) would return 0
Examples
findDigit(5673, 4)     returns 5
findDigit(129, 2)      returns 2
findDigit(-2825, 3)    returns 8
findDigit(-456, 4)     returns 0
findDigit(0, 20)       returns 0
findDigit(65, 0)       returns -1
findDigit(24, -8)      returns -1
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class FindNthDigitOfNumber
    {
        public static int FindDigit(int num, int nth)
        {
            return nth <= 0 ? -1 : (int) Math.Abs(num / Math.Pow(10, nth - 1) % 10);
        }

        // public static int FindDigit(int n, int m) =>
        //     m < 1 ? -1 : n.ToString().Replace("-", "").PadLeft(m, '0').Reverse().ElementAt(m - 1) - 48;

        // public static int FindDigit(int num, int nth)
        // {
        //     return nth <= 0
        //         ? -1
        //         : (Math.Abs(num).ToString().Length >= nth
        //             ? Int32.Parse(Math.Abs(num).ToString()[Math.Abs(num).ToString().Length - nth].ToString())
        //             : 0);
        // }
    }
}