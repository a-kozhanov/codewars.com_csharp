/*
https://www.codewars.com/kata/59a1ec603203e862bb00004f/csharp

7 kyu
Concatenated Sum

The number 198 has the property that 198 = 11 + 99 + 88, i.e., 
if each of its digits is concatenated twice and then summed, 
the result will be the original number. 
It turns out that 198 is the only number with this property. 
However, the property can be generalized so that each digit is concatenated n times and then summed.

eg:-

original number =2997 , n=3
2997 = 222+999+999+777 and here each digit is concatenated three times.

original number=-2997 , n=3

-2997 = -222-999-999-777 and here each digit is concatenated three times.

Write afunction named check_concatenated_sum that tests if a number has this generalized property.
*/


using System;
using System.Linq;

namespace CodeWars
{
    public class ConcatenatedSum
    {
        public static bool CheckConcatenatedSum(int number, int n)
        {
            // return n != 0 && (number < 0 ? CheckConcatenatedSum(-number, n) :
            //     number.ToString().ToCharArray().Select(d => int.Parse(new string(d, n)))
            //         .Aggregate(0, (s, e) => s + e) == number);

            //return number == Math.Abs(number).ToString().Aggregate(0, (prev, curr) => prev + Int32.Parse(new String(curr, n)) * Math.Sign(number));

            // var x = Math.Abs(number);
            // return x.ToString().Sum(c => long.Parse(new string(c, n))) == x;

            // return (number != 0 || n != 0)
            //        && Math.Abs(number).ToString().Sum(c => c - '0') * ((long) Math.Pow(10, n) / 9) ==
            //        Math.Abs(number);

            //return Math.Abs(number) == Math.Abs(number).ToString().Sum(x => long.Parse(string.Concat(Enumerable.Repeat(x, n))));

            //return Math.Abs(number).ToString().Sum(x => (number > 0 ? 1L : -1L) * int.Parse(new string(x, n))) == number;

            //return Math.Abs(number).ToString().Sum(x => Math.Sign(number) * long.Parse(new string(x, n))) == number;

            return $"{Math.Abs(number)}".Sum(c => Math.Sign(number) * long.Parse(new string(c, n))) == number;
        }
    }
}