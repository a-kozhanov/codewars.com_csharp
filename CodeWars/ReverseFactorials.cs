/*
https://www.codewars.com/kata/58067088c27998b119000451/train/csharp
https://www.codewars.com/kata/58067088c27998b119000451/solutions/csharp

7 kyu
Reverse Factorials

I'm sure you're familiar with factorials – that is, the product of an integer and all the integers below it.

For example, 5! = 120, as 5 * 4 * 3 * 2 * 1 = 120

Your challenge is to create a function that takes any number and returns the number that it is a factorial of. So, if your function receives 120, it should return "5!" (as a string).

Of course, not every number is a factorial of another. In this case, your function would return "None" (as a string).

Examples
120 will return "5!"
24 will return "4!"
150 will return "None"
*/

namespace CodeWars
{
    public class ReverseFactorials
    {
        public static string ReverseFactorial(long num)
        {
            long fact = 1;
            for (var i = 1; i < 100; i++)
            {
                if ((fact *= i) == num) return $"{i}!";
            }

            return "None";
        }


        // public static string ReverseFactorial(long num)
        // {
        //     string result;
        //     for (var i = 1;; i++)
        //     {
        //         if (Factorial(i) == num)
        //         {
        //             result = $"{i}!";
        //             break;
        //         }
        //
        //         if (Factorial(i) > num)
        //         {
        //             result = "None";
        //             break;
        //         }
        //     }
        //
        //     return result;
        // }
        //
        // private static long Factorial(long n) => n == 0 ? 1 : n * Factorial(n - 1);


        // public static string ReverseFactorial(long num)
        // {
        //     var fact = 1L;
        //     var i = 1;
        //     while (fact < num)
        //     {
        //         fact *= ++i;
        //     }
        //
        //     return (fact == num) ? $"{i}!" : "None";
        // }

        // public static string ReverseFactorial(long num)
        // {
        //     long res = 1;
        //     for (var i = 1; i < 100; i++)
        //     {
        //         res *= i;
        //         if (res == num) return $"{i}!";
        //     }
        //
        //     return "None";
        // }

        // public static string ReverseFactorial(long num)
        // {
        //     for (int i = 1;; i++)
        //     {
        //         if (i == num)
        //         {
        //             return $"{i}!";
        //         }
        //
        //         if (num % i != 0)
        //         {
        //             return "None";
        //         }
        //
        //         num /= i;
        //     }
        // }


        // public static string ReverseFactorial(long num)
        // {
        //     var multiplier = 1;
        //     double Prod = num;
        //     while (Prod > 1)
        //     {
        //         multiplier++;
        //         Prod /= multiplier;
        //     }
        //
        //     return Prod == 1 ? $"{multiplier}!" : "None";
        // }


        // public static string ReverseFactorial(long num)
        // {
        //     long m = 1;
        //     bool b = false;
        //     long i = 1;
        //     while (m <= num)
        //     {
        //         m = m * i;
        //         if (m == num)
        //         {
        //             b = true;
        //         }
        //
        //         i++;
        //     }
        //
        //     if (b)
        //     {
        //         return String.Concat(i - 2, "!");
        //     }
        //     else
        //     {
        //         return "None";
        //     }
        // }


        // private static readonly Dictionary<long, string> factorials = new Dictionary<long, string>
        // {
        //     {1, "1!"},
        //     {2, "2!"},
        //     {6, "3!"},
        //     {24, "4!"},
        //     {120, "5!"},
        //     {720, "6!"},
        //     {5040, "7!"},
        //     {40320, "8!"},
        //     {362880, "9!"},
        //     {3628800, "10!"},
        //     {39916800, "11!"},
        //     {479001600, "12!"},
        //     {6227020800, "13!"},
        //     {87178291200, "14!"},
        //     {1307674368000, "15!"},
        //     {20922789888000, "16!"},
        //     {355687428096000, "17!"},
        //     {6402373705728000, "18!"},
        //     {121645100408832000, "19!"},
        //     {2432902008176640000, "20!"}
        // };
        //
        // public static string ReverseFactorial(long num) => factorials.ContainsKey(num) ? factorials[num] : "None";


        // public static string ReverseFactorial(long num)
        // {
        //     long number = num;
        //     int divisor = 2;
        //     while (number % divisor == 0)
        //     {
        //         number /= divisor;
        //         divisor++;
        //     }
        //
        //     if (number == 1)
        //         return (divisor - 1) + "!".ToString();
        //     else
        //         return "None";
        // }


        // public static string ReverseFactorial(long num)
        // {
        //     long[] fact =
        //     {
        //         0, 1, 2, 6, 24, 120, 720, 5040, 40320, 362880, 3628800, 39916800, 479001600, 6227020800, 87178291200,
        //         1307674368000, 20922789888000, 355687428096000, 6402373705728000, 121645100408832000,
        //         2432902008176640000
        //     };
        //
        //     return fact.Contains(num) ? Array.IndexOf(fact, num).ToString() + "!" : "None";
        // }
    }
}