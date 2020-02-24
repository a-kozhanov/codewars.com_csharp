/*
https://www.codewars.com/kata/5a58d889880385c2f40000aa/train/csharp
https://www.codewars.com/kata/5a58d889880385c2f40000aa/solutions/csharp

7 kyu
Automorphic Number (Special Numbers Series #6)

Definition
A number is called Automorphic number if and only if its square ends in the same digits as the number itself.

Task
Given a number determine if it Automorphic or not .

Warm-up (Highly recommended)
Playing With Numbers Series
Notes
The number passed to the function is positive

Single-digit numbers are considered Automorphic number.

Input >> Output Examples
autoMorphic (25) -->> return "Automorphic" 
Explanation:
25 squared is 625 , Ends with the same number's digits which are 25 .
autoMorphic (13) -->> return "Not!!"
Explanation:
13 squared is 169 , Not ending with the same number's digits which are 69 .
autoMorphic (76) -->> return "Automorphic"
Explanation:
76 squared is 5776 , Ends with the same number's digits which are 76 .
autoMorphic (225) -->> return "Not!!"
Explanation:
225 squared is 50625 , Not ending with the same number's digits which are 225 .
autoMorphic (625) -->> return "Automorphic"
Explanation:
625 squared is 390625 , Ends with the same number's digits which are 625 .
autoMorphic (1) -->> return "Automorphic"
Explanation:
1 squared is 1 , Ends with the same number's digits which are 1 .
autoMorphic (6) -->> return "Automorphic"
Explanation:
6 squared is 36 , Ends with the same number's digits which are 6
Playing with Numbers Series
Playing With Lists/Arrays Series
For More Enjoyable Katas
ALL translations are welcomed
Enjoy Learning !!
Zizou
*/

using System;

namespace CodeWars
{
    public class AutomorphicNumberSpecialNumbersSeries6
    {
        public static string Automorphic(int n)
        {
            //return (n * n).ToString().EndsWith(n.ToString()) ? "Automorphic" : "Not!!";
            return $"{n * n}".EndsWith($"{n}") ? "Automorphic" : "Not!!";
        }

        // public static string Automorphic(int n)
        // {
        //     int square = n * n;
        //     string squared = square.ToString();
        //     if (squared.EndsWith(n.ToString()))
        //     {
        //         return "Automorphic";
        //     }
        //
        //     return "Not!!";
        // }


        // public static string Automorphic(int n) => ((n * n) + "").Contains(n + "") ? "Automorphic" : "Not!!";


        // public static string Automorphic(int n)
        // {
        //     var nr = Math.Pow(n, 2).ToString();
        //
        //     return nr.EndsWith((n.ToString())) ? "Automorphic" : "Not!!";
        // }


        // public static string Automorphic(int n)
        // {
        //     return ((Math.Pow(n, 2) % ((int) Math.Pow(10, n.ToString().Length))) == n) ? "Automorphic" : "Not!!";
        // }


        // public static string Automorphic(int n)
        // {
        //     if (Math.Pow(n, 2).ToString().Contains($"{n}") || (n == 1))
        //     {
        //         return "Automorphic";
        //     }
        //     else
        //     {
        //         return "Not!!";
        //     }
        // }


        // public static string Automorphic(int n)
        // {
        //     var powNumber = Math.Pow(n, 2).ToString();
        //
        //     var number = n.ToString();
        //
        //     var result = powNumber.EndsWith(number);
        //
        //     if (result == true)
        //     {
        //         return "Automorphic";
        //     }
        //
        //     return "Not!!";
        // }


        // public static string Automorphic(int n)
        // {
        //     string digits = (n * n).ToString();
        //     string num = n.ToString();
        //     return digits.LastIndexOf(num) == digits.Length - num.Length ? "Automorphic" : "Not!!";
        // }
    }
}