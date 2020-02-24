/*
https://www.codewars.com/kata/5a87449ab1710171300000fd/train/csharp
https://www.codewars.com/kata/5a87449ab1710171300000fd/solutions/csharp

7 kyu
Tidy Number (Special Numbers Series #9)

Definition
A Tidy number is a number whose digits are in non-decreasing order.

Task
Given a number, Find if it is Tidy or not .

Warm-up (Highly recommended)
Playing With Numbers Series
Notes
Number passed is always Positive .

Return the result as a Boolean

Input >> Output Examples
tidyNumber (12) ==> return (true)
Explanation:
The number's digits { 1 , 2 } are in non-Decreasing Order (i.e) 1 <= 2 .

tidyNumber (32) ==> return (false)
Explanation:
The Number's Digits { 3, 2} are not in non-Decreasing Order (i.e) 3 > 2 .

tidyNumber (1024) ==> return (false)
Explanation:
The Number's Digits {1 , 0, 2, 4} are not in non-Decreasing Order as 0 <= 1 .

tidyNumber (13579) ==> return (true)
Explanation:
The number's digits {1 , 3, 5, 7, 9} are in non-Decreasing Order .

tidyNumber (2335) ==> return (true)
Explanation:
The number's digits {2 , 3, 3, 5} are in non-Decreasing Order , Note 3 <= 3

Playing with Numbers Series
Playing With Lists/Arrays Series
For More Enjoyable Katas
ALL translations are welcomed
Enjoy Learning !!
Zizou
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class TidyNumberSpecialNumbersSeries9
    {
        public static bool TidyNumber(int n)
        {
            // return Enumerable.Range(0, n.ToString().Length - 1).Select((x, i) => n.ToString()[x] <= n.ToString()[i + 1]).All(x => x);
            //return n.ToString() == new string(n.ToString().OrderBy(z => z).ToArray());
            //return n.ToString() == string.Concat(n.ToString().OrderBy(c => c));
            //return $"{n}" == new string($"{n}".OrderBy(c => c).ToArray());
            //return $"{n}".Equals(string.Concat($"{n}".OrderBy(c => c)));
            return $"{n}" == string.Concat($"{n}".OrderBy(c => c));
        }

        // public static bool TidyNumber(int n) => n.ToString().SequenceEqual(n.ToString().OrderBy(x => x));

        // public static bool TidyNumber(int n)
        // {
        //     return n.ToString() == String.Concat(n.ToString().OrderBy(c => c));
        // }

        // public static bool TidyNumber(int n) =>
        //     n == int.Parse(string.Concat(n.ToString().Select(x => Convert.ToInt32(x) - '0').OrderBy(x => x)));


        // public static bool TidyNumber(int n)
        // {
        //     var digitArray = n.ToString().Select(digit => int.Parse(digit.ToString())).ToArray();
        //
        //     for (int i = 0; i < digitArray.Length - 1; i++)
        //
        //         if (digitArray[i] < digitArray[i + 1])
        //         {
        //             continue;
        //         }
        //         else if (digitArray[i] > digitArray[i + 1])
        //         {
        //             return false;
        //         }
        //
        //     return true;
        // }


        // public static bool TidyNumber(int n)
        // {
        //     return n.ToString().Where((x, i) => i > 0 && x < n.ToString()[i - 1]).Count() == 0;
        // }

        // public static bool TidyNumber(int n)
        // {
        //     return n == 0 || n % 10 >= n / 10 % 10 && TidyNumber(n / 10);
        // }


        // public static bool TidyNumber(int n)
        // {
        //     return n.ToString().SequenceEqual(n.ToString().OrderBy(char.GetNumericValue));
        // }


        // public static bool TidyNumber(int n)
        // {
        //     return new string(n.ToString().OrderBy(x => char.GetNumericValue(x)).ToArray()) == n.ToString();
        // }


        // public static bool TidyNumber(int n) =>
        //     n == int.Parse(string.Concat(n.ToString().ToCharArray().OrderBy(o => o)));
    }
}