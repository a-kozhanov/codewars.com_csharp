/*
https://www.codewars.com/kata/5a54e796b3bfa8932c0000ed/train/csharp
https://www.codewars.com/kata/5a54e796b3bfa8932c0000ed/solutions/csharp

7 kyu
Jumping Number (Special Numbers Series #4)

Definition
Jumping number is the number that All adjacent digits in it differ by 1.

Task
Given a number, Find if it is Jumping or not .

Warm-up (Highly recommended)
Playing With Numbers Series
Notes
Number passed is always Positive .

Return the result as String .

The difference between ‘9’ and ‘0’ is not considered as 1 .

All single digit numbers are considered as Jumping numbers.

Input >> Output Examples
jumpingNumber(9) ==> return "Jumping!!"
Explanation:
It's single-digit number
jumpingNumber(79) ==> return "Not!!"
Explanation:
Adjacent digits don't differ by 1
jumpingNumber(23) ==> return "Jumping!!"
Explanation:
Adjacent digits differ by 1
jumpingNumber(556847) ==> return "Not!!"
Explanation:
Adjacent digits don't differ by 1
jumpingNumber(4343456) ==> return "Jumping!!"
Explanation:
Adjacent digits differ by 1
jumpingNumber(89098) ==> return "Not!!"
Explanation:
Adjacent digits don't differ by 1
jumpingNumber(32) ==> return "Jumping!!"
Explanation:
Adjacent digits differ by 1
Playing with Numbers Series
Playing With Lists/Arrays Series
For More Enjoyable Katas
ALL translations are welcomed
Enjoy Learning !!
Zizou
*/


using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class JumpingNumberSpecialNumbersSeries4
    {
        public static string JumpingNumber(int n)
        {
            while (true)
            {
                if (n < 10) return "Jumping!!";
                if (Math.Abs(n % 10 - n / 10 % 10) != 1) return "Not!!";
                n /= 10;
            }
        }

        // public static string JumpingNumber(int n)
        // {
        //     return n < 10 ? "Jumping!!" : Math.Abs(n % 10 - (n / 10) % 10) != 1 ? "Not!!" : JumpingNumber(n / 10);
        // }


        // public static string JumpingNumber(int number)
        // {
        //     string str = number.ToString();
        //     for (int i = 0; i < str.Length - 1; i++)
        //     {
        //         if (str[i + 1] - str[i] != 1)
        //         {
        //             if (str[i] - str[i + 1] != 1)
        //                 return "Not!!";
        //         }
        //     }
        //
        //     return "Jumping!!";
        // }


        // public static string JumpingNumber(int number)
        // {
        //     string s = number.ToString();
        //     for (int i = 0; i < s.Length - 1; i++)
        //         if (System.Math.Abs(int.Parse(s[i].ToString()) - int.Parse(s[i + 1].ToString())) != 1)
        //             return "Not!!";
        //     return "Jumping!!";
        // }


        // public static string JumpingNumber(int number)
        // {
        //     if (number < 10) return "Jumping!!";
        //     if (Math.Abs(number % 10 - number % 100 / 10) != 1) return "Not!!";
        //     return JumpingNumber(number / 10); // Could be done shorter with split, but recursion is more fun
        // }


        // public static string JumpingNumber(int number)
        // {
        //     var ecks = number.ToString().ToCharArray();
        //     for (int i = 1; i < number.ToString().Length; i++)
        //     {
        //         if (Math.Abs(ecks[i - 1] - ecks[i]) != 1) return "Not!!";
        //     }
        //
        //     return "Jumping!!";
        // }
    }
}