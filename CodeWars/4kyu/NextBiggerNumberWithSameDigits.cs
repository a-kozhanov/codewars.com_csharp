/*
https://www.codewars.com/kata/55983863da40caa2c900004e/csharp

4 kyu
Next bigger number with the same digits

Create a function that takes a positive integer and returns the next bigger number that can be formed by rearranging its digits. 

For example:
12 ==> 21
513 ==> 531
2017 ==> 2071
nextBigger(num: 12)   // returns 21
nextBigger(num: 513)  // returns 531
nextBigger(num: 2017) // returns 2071
If the digits can't be rearranged to form a bigger number, return -1 (or nil in Swift):

9 ==> -1
111 ==> -1
531 ==> -1
nextBigger(num: 9)   // returns nil
nextBigger(num: 111) // returns nil
nextBigger(num: 531) // returns nil
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class NextBiggerNumberWithSameDigits
    {
        // static IEnumerable<string> AddAllFrom(List<char> chars, int n)
        // {
        //     if (n == 0)
        //         yield return "";
        //     foreach (var c in chars.ToList())
        //     {
        //         chars.Remove(c);
        //         foreach (var s in AddAllFrom(chars, n - 1))
        //             yield return c + s;
        //         chars.Add(c);
        //     }
        // }

        // public static long NextBiggerNumber(long n)
        // {
        //     Console.WriteLine(n);
        //     var chars = new List<char>(n.ToString().ToCharArray());
        //     return AddAllFrom(chars, chars.Count).Select(int.Parse).OrderBy(x => x).FirstOrDefault(x => x > n);
        // }

        public static long NextBiggerNumber(long n)
        {
            static string Nums(long num) => string.Concat(num.ToString().OrderByDescending(i => i));
            var num = Nums(n);
            if (num == n.ToString()) return -1;
            do
            {
                n++;
            } while (Nums(n) != num);

            return n;
        }
    }
}