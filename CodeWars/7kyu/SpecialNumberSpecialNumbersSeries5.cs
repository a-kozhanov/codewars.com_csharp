/*
https://www.codewars.com/kata/5a55f04be6be383a50000187/train/csharp
https://www.codewars.com/kata/5a55f04be6be383a50000187/solutions/csharp

7 kyu
Special Number (Special Numbers Series #5)

Definition
A number is a Special Number if it’s digits only consist 0, 1, 2, 3, 4 or 5

Given a number determine if it special number or not .

Warm-up (Highly recommended)
Playing With Numbers Series
Notes
The number passed will be positive (N > 0) .

All single-digit numbers with in the interval [0:5] are considered as special number.

Input >> Output Examples
specialNumber(2) ==> return "Special!!"
Explanation:
It's a single-digit number within the interval [0:5] .

specialNumber(9) ==> return "NOT!!"
Explanation:
Although, it's a single-digit number but Outside the interval [0:5] .

specialNumber(23) ==> return "Special!!"
Explanation:
All the number's digits formed from the interval [0:5] digits .

specialNumber(39) ==> return "NOT!!"
Explanation:
Although, there is a digit (3) Within the interval But the second digit is not (Must be ALL The Number's Digits ) .

specialNumber(59) ==> return "NOT!!"
Explanation:
Although, there is a digit (5) Within the interval But the second digit is not (Must be ALL The Number's Digits ) .

specialNumber(513) ==> return "Special!!"
specialNumber(709) ==> return "NOT!!"
For More Enjoyable Katas
ALL translation are welcomed
Enjoy Learning !!
Zizou
*/

using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class SpecialNumberSpecialNumbersSeries5
    {
        public static string SpecialNumber(int number)
        {
            return Regex.IsMatch(number.ToString(), "[^0-5]") ? "NOT!!" : "Special!!";
        }

        // public static string SpecialNumber(int number) =>
        //     new Regex(@"^[012345]+$").IsMatch(number.ToString()) ? "Special!!" : "NOT!!";


        // public static string SpecialNumber(int number)
        // {
        //     var s = number.ToString();
        //     return number.ToString().Contains("6") ||
        //            s.Contains("7") ||
        //            s.Contains("8") ||
        //            s.Contains("9")
        //         ? "NOT!!"
        //         : "Special!!";
        // }


        // public static string SpecialNumber(int number)
        // {
        //     return Regex.Replace("" + number, "[012345]", "").Length == 0 ? "Special!!" : "NOT!!";
        // }


        // public static string SpecialNumber(int n) => (n + "").All(t => t - 48 <= 5) ? "Special!!" : "NOT!!";


        // public static string SpecialNumber(int number)
        // {
        //     return Regex.IsMatch(Convert.ToString(number), "[6-9]") ? "NOT!!" : "Special!!";
        // }


        // public static string SpecialNumber(int number) => number.ToString().Any(c => c > 53) ? "NOT!!" : "Special!!";


        // public static string SpecialNumber(int number)
        // {
        //     while (number != 0)
        //     {
        //         if (number % 10 > 5)
        //             return "NOT!!";
        //         number /= 10;
        //     }
        //
        //     return "Special!!";
        // }

        // public static string SpecialNumber(int number)
        //     => (number.ToString().Any(a => "6789".Contains(a)))
        //         ? "NOT!!"
        //         : "Special!!";
    }
}