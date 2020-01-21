/*
https://www.codewars.com/kata/5a4d303f880385399b000001/train/csharp
https://www.codewars.com/kata/5a4d303f880385399b000001/solutions/csharp

7 kyu
STRONGN Strong Number (Special Numbers Series #2)

Definition
Strong number is the number that the sum of the factorial of its digits is equal to number itself.

For example: 145, since
1! + 4! + 5! = 1 + 24 + 120 = 145
So, 145 is a Strong number.

Task
Given a number, Find if it is Strong or not.

Warm-up (Highly recommended)
Playing With Numbers Series
Notes
Number passed is always Positive.
Return the result as String
Input >> Output Examples
strong_num(1) ==> return "STRONG!!!!"
Explanation:
Since , the sum of its digits' factorial of (1) is equal to number itself (1) , Then its a Strong .

strong_num(123) ==> return "Not Strong !!"
Explanation:
Since the sum of its digits' factorial of 1! + 2! + 3! = 9 is not equal to number itself (123) , Then it's Not Strong .

strong_num(2)  ==>  return "STRONG!!!!"
Explanation:
Since the sum of its digits' factorial of 2! = 2 is equal to number itself (2) , Then its a Strong .

strong_num(150) ==> return "Not Strong !!"
Explanation:
Since the sum of its digits' factorial of 1! + 5! + 0! = 122 is not equal to number itself (150), Then it's Not Strong .

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
    public class STRONGNStrongNumberSpecialNumbersSeries2
    {
        public static string StrongNumber(int number)
        {
            return number == number.ToString().Sum(n => Factorial(int.Parse(n.ToString())))
                ? "STRONG!!!!"
                : "Not Strong !!";
        }

        private static int Factorial(int n) => n == 0 ? 1 : n * Factorial(n - 1);
    }


    // class Kata
    // {
    //     public static string StrongNumber(int n) => 
    //         (""+n).Select(e=> F((int)char.GetNumericValue(e))).Sum() == n ? "STRONG!!!!" : "Not Strong !!"  ;
    //
    //     public static int F(int n) => n <= 2 ? n : F(n-1) * n;
    // }


    // class Kata
    // {
    //     public static string StrongNumber(int number)
    //     {
    //         return number == number.ToString().Sum(n => Fuct(Convert.ToInt32(n.ToString()))) ? "STRONG!!!!" : "Not Strong !!";
    //     }
    //
    //     public static int Fuct(int n) => n == 0 ? 1 : n * Fuct(n-1);
    // }


    // class Kata
    // {
    //     public static string StrongNumber(int number)
    //     {
    //         string line = number.ToString();
    //         int sum = 0;
    //         for (int i = 0; i < line.Length; i++)
    //         {
    //             int index = 1;
    //             int dob = 1;
    //             while (index<=Int32.Parse(line[i].ToString()))
    //             {
    //                 dob *= index;
    //                 index++;
    //             }
    //             sum += dob;
    //         }
    //
    //         if (sum == number)
    //         {
    //             return "STRONG!!!!";
    //         }
    //         else return "Not Strong !!";
    //     }
    // }


    // public static string StrongNumber(int number)
    // {
    // if(number==1 || number==2 || number==145)
    // return "STRONG!!!!";
    // return "Not Strong !!";
    // }
}