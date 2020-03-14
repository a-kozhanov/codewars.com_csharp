/*
https://www.codewars.com/kata/58daa7617332e59593000006/train/csharp
https://www.codewars.com/kata/58daa7617332e59593000006/solutions/csharp

7 kyu
Most digits

Find the number with the most digits.
If two numbers in the argument array have the same number of digits, return the first one in the array.
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class MostDigits
    {
        public static int FindLongest(int[] number)
        {
            //return number.OrderByDescending(i => $"{i}".Length).First();
            return number.First(i => $"{i}".Length == $"{number.Max()}".Length);
        }

        // public static int FindLongest(int[] number)
        // {
        //     int i = number.Max();
        //     foreach (int n in number)
        //     {
        //         if (n.ToString().Length == i.ToString().Length)
        //             return n;
        //     }
        //
        //     return i;
        // }


        // public static int FindLongest(int[] number)
        //     => number.Aggregate(0, (s, n) => $"{s}".Length < $"{n}".Length ? n : s);


        // public static int FindLongest(int[] numbers)
        //     => numbers.Select((x, i) => Tuple.Create(x.ToString().Length, -i, x)).Max().Item3;


        // public static int FindLongest(int[] number)
        // {
        //     return number.GroupBy(x => x.ToString().Length).Select(x => x.First()).OrderByDescending(x => x)
        //         .FirstOrDefault();
        // }


        // public static int FindLongest(int[] number)
        // {
        //     return number.First(n => n.ToString().Length == number.Select(x => x.ToString().Length).Max());
        // }


        // public static int FindLongest(int[] number) =>
        //     number.OrderByDescending(p => Math.Floor(Math.Log10(p) + 1)).FirstOrDefault();


        // public static int FindLongest(int[] number)
        // {
        //     return number.Where(x => x.ToString().Length == number.Max().ToString().Length).FirstOrDefault();
        // }


        // public static int FindLongest(int[] number)
        // {
        //     return Array.Find(number, n => n.ToString().Length == number.Max(e => e.ToString().Length));
        // }


        // public static int FindLongest(int[] numbers)
        // {
        //     return numbers.First(i => i.ToString().Length == numbers.Max(n => n.ToString().Length));
        // }


        // public static int FindLongest(int[] number) =>
        //     number.Aggregate((p, n) => n.ToString().Length > p.ToString().Length ? n : p);
    }
}