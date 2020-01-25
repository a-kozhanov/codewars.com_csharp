/*
https://www.codewars.com/kata/56e9e4f516bcaa8d4f001763/train/csharp
https://www.codewars.com/kata/56e9e4f516bcaa8d4f001763/solutions/csharp

7 kyu
Sum of numbers from 0 to N

Description:
We want to generate a function that computes the series starting from 0 and ending until the given number.

Example:
Input:
> 6
Output:
0+1+2+3+4+5+6 = 21

Input:
> -15
Output:
-15<0

Input:
> 0
Output:
0=0

*/

using System.Linq;

namespace CodeWars
{
    public class SumOfNumbersFrom0ToN
    {
        public static string ShowSequence(int n)
        {
            //return n < 0 ? $"{n}<0" : n == 0 ? "0=0" : string.Join("+", Enumerable.Range(0, n + 1)) + " = " + (1 + n) * n / 2;
            //return n < 0 ? $"{n}<0" : n == 0 ? "0=0" : string.Join("+", Enumerable.Range(0, n + 1)) + $"{(1 + n) * n / 2}";
            return n < 0 ? $"{n}<0" :
                n == 0 ? "0=0" : $"{string.Join("+", Enumerable.Range(0, n + 1))} = {(1 + n) * n / 2}";
        }

        // public static string ShowSequence(int n)
        // {
        //     if (n < 0) return $"{n}<0";
        //     if (n == 0) return "0=0";
        //
        //     IEnumerable<int> sequence = Enumerable.Range(0, n + 1);
        //
        //     return $"{String.Join("+", sequence)} = {sequence.Sum()}";
        // }


        // public static string ShowSequence(int n)
        // {
        //     if (n < 0)
        //         return n + "<0";
        //     if (n == 0)
        //         return "0=0";
        //     int sum = 0;
        //     StringBuilder sequence = new StringBuilder("0");
        //     for (int i = 1; i <= n; i++)
        //     {
        //         sequence.Append("+" + i);
        //         sum += i;
        //     }
        //
        //     sequence.Append(" = " + sum);
        //     return sequence.ToString();
        // }


        // public static string ShowSequence(int n)
        // {
        //     if (n == 0)
        //     {
        //         return "0=0";
        //     }
        //
        //     if (n < 0)
        //     {
        //         return $"{n}<0";
        //     }
        //
        //     var lhs = string.Join("+", Enumerable.Range(0, n + 1).Select(i => i.ToString()));
        //     var rhs = n * (n + 1) / 2;
        //     return $"{lhs} = {rhs}";
        // }


        // public static string ShowSequence(int n)
        // {
        //     return n == 0 ? "0=0" :
        //         n < 0 ? $"{n}<0" : string.Join("+", Enumerable.Range(0, n + 1)) + " = " + (n * (n + 1) / 2);
        // }


        // public static string ShowSequence(int n)
        // {
        //     return n < 0
        //         ? $"{n}<0"
        //         : n == 0
        //             ? "0=0"
        //             : $"{string.Join("+", Enumerable.Range(0, n + 1))} = {Enumerable.Range(0, n + 1).Sum()}";
        // }


        // public static string ShowSequence(int n)
        // {
        //     if (n == 0) return $"{n}=0";
        //     if (n < 0) return $"{n}<0";
        //
        //     var array = Enumerable.Range(0, n + 1);
        //     return String.Join("+", array) + " = " + array.Sum();
        // }


        // public static string ShowSequence(int n)
        // {
        //     return n == 0 ? "0=0" :
        //         n < 0 ? n + "<0" : string.Join("+", Enumerable.Range(0, n + 1)) + " = " + (1 + n) * n / 2;
        // }


        // public static string ShowSequence(int n)
        // {
        //     if (n == 0)
        //         return "0=0";
        //     if (n < 0)
        //         return n + "<0";
        //
        //     var numbers = Enumerable.Range(0, n + 1);
        //     return String.Join("+", numbers) + $" = {numbers.Sum()}";
        // }
    }
}