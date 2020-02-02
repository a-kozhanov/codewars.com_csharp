/*
https://www.codewars.com/kata/58c9322bedb4235468000019
https://www.codewars.com/kata/58c9322bedb4235468000019/solutions/csharp

7 kyu
"Very Even" Numbers.

Description:
#Task:
Write a function that returns true if the number is a "Very Even" number.
If the number is odd, it is not a "Very Even" number.
If the number is even, return whether the sum of the digits is a "Very Even" number.

#Examples:
input(88) => returns false -> 8 + 8 = 16 -> 1 + 6 = 7 => 7 is odd 
input(222) => returns true
input(5) => returns false

Note: The numbers will always be positive!
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class VeryEvenNumbers
    {
        public static bool IsVeryEvenNumber(int number)
        {
            return (--number % 9 + 1) % 2 == 0;
        }

        // public static bool IsVeryEvenNumber(int n)
        // {
        //     return n-- == 0 || n % 9 % 2 == 1;
        // }

        // public static bool IsVeryEvenNumber(int number)
        // {
        //     while (number > 9)
        //     {
        //         String s = number.ToString();
        //         int sum = 0;
        //         for (int i = 0; i < s.Length; i++)
        //         {
        //             sum += s[i] - '0';
        //         }
        //
        //         number = sum;
        //     }
        //
        //     return number % 2 == 0;
        // }


        // public static bool IsVeryEvenNumber(int number)
        // {
        //     while (number > 9)
        //     {
        //         string digits = number.ToString();
        //         int sum = 0;
        //         foreach (char c in digits)
        //             sum += c - '0';
        //         number = sum;
        //     }
        //
        //     return number % 2 == 0;
        // }

        // public static bool IsVeryEvenNumber(int number)
        // {
        //     if (number < 10 && number % 2 != 0)
        //         return false;
        //
        //     var num = 0;
        //
        //     while (number >= 10)
        //     {
        //         foreach (var item in number.ToString())
        //         {
        //             num += int.Parse(item.ToString());
        //         }
        //
        //         number = num;
        //         num = 0;
        //     }
        //
        //     return number % 2 == 0 ? true : false;
        // }


        // public static bool IsVeryEvenNumber(int num)
        // {
        //     return (num == 0) ? true : (num % 9 == 0) ? false : (num % 9 % 2 == 0) ? true : false;
        // }

        // public static bool IsVeryEvenNumber(int y)
        // {
        //     int x = y.ToString().Select(i => i - '0').Select(i => Convert.ToInt32(i)).Sum();
        //     return (x < 10) ? (x % 2 == 0 ? true : false) : IsVeryEvenNumber(x);
        // }

        // public static bool IsVeryEvenNumber(int number)
        // {
        //     int sum = number.ToString().Select(c => Convert.ToInt32(c.ToString())).ToArray().Sum();
        //     if (sum > 10) return IsVeryEvenNumber(sum);
        //     return (sum % 2 == 0 & sum < 10);
        // }

        // public static bool IsVeryEvenNumber(int n)
        // {
        //     return n < 10 ? n % 2 == 0 : IsVeryEvenNumber(n.ToString().Sum(c => c - '0'));
        // }

        // public static bool IsVeryEvenNumber(int number)
        // {
        //     while (number >= 10)
        //     {
        //         number = number % 10 + number / 10;
        //     }
        //
        //     return number % 2 == 0;
        // }
    }
}