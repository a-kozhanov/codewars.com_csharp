/*
https://www.codewars.com/kata/57f7b8271e3d9283300000b4/csharp

7 kyu
Even or Odd - Which is Greater?

Given a string of digits confirm whether the sum of all the individual even digits are greater than the sum of all the indiviudal odd digits. 
Always a string of numbers will be given.

If the sum of even numbers is greater than the odd numbers return: "Even is greater than Odd"
If the sum of odd numbers is greater than the sum of even numbers return: "Odd is greater than Even"
If the total of both even and odd numbers are identical return: "Even and Odd are the same"
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class EvenOrOddWhichIsGreater
    {
        public static string EvenOrOdd(string str)
        {
            return new[] {"Odd is greater than Even", "Even and Odd are the same", "Even is greater than Odd"}[
                str.Select(c => int.Parse(c.ToString())).Sum(i => i % 2 == 0 ? i : -i).CompareTo(0) + 1];

            //var r = str.Select(x => int.Parse(x.ToString())).Sum(x => x % 2 == 0 ? x : -x).CompareTo(0) + 1;
            //return new[] {"Odd is greater than Even", "Even and Odd are the same", "Even is greater than Odd"}[r];


            // var r = str.GroupBy(x => int.Parse(x.ToString()) % 2)
            //     .Select(t => (t.Key, t.Sum(b => int.Parse(b.ToString())))).ToArray();
            //
            // return r.Sum(x => x.Key == 0 ? x.Item2 : 0) < r.Sum(x => x.Key == 1 ? x.Item2 : 0)
            //     ? "Odd is greater than Even"
            //     : r.Sum(x => x.Key == 0 ? x.Item2 : 0) > r.Sum(x => x.Key == 1 ? x.Item2 : 0)
            //         ? "Even is greater than Odd"
            //         : "Even and Odd are the same";


            // int[] evenOdd = str.Aggregate(new int[] {0, 0}, (arr, ch) =>
            // {
            //     int d = (int) Char.GetNumericValue(ch);
            //     arr[d & 1] += d;
            //     return arr;
            // });
            // return new string[] {"Odd is greater than Even", "Even and Odd are the same", "Even is greater than Odd"}[
            //     evenOdd[0].CompareTo(evenOdd[1]) + 1];


            // var r = str.GroupBy(x => int.Parse(x.ToString()) % 2).Select(t => (t.Sum(b => int.Parse(b.ToString())))).ToArray();
            // return r[0] < r[1]
            //     ? "Odd is greater than Even"
            //     : r[0] > r[1]
            //         ? "Even is greater than Odd"
            //         : "Even and Odd are the same";


            // var r = str.GroupBy(x => int.Parse(x.ToString()) % 2).ToArray();
            // return r.Sum(x => x.Key == 0 ? x.Key : 0) < r.Sum(x => x.Item1 == 1 ? x.Item2 : 0)
            //     ? "Odd is greater than Even"
            //     : r.Sum(x => x.Item1 == 0 ? x.Item2 : 0) > r.Sum(x => x.Item1 == 1 ? x.Item2 : 0)
            //         ? "Even is greater than Odd"
            //         : "Even and Odd are the same";


            // var r = str.Select(x => (int.Parse(x.ToString()) % 2, int.Parse(x.ToString()))).ToArray();
            // return r.Sum(x => x.Item1 == 0 ? x.Item2 : 0) < r.Sum(x => x.Item1 == 1 ? x.Item2 : 0)
            //     ?
            //     "Odd is greater than Even"
            //     :
            //     r.Sum(x => x.Item1 == 0 ? x.Item2 : 0) > r.Sum(x => x.Item1 == 1 ? x.Item2 : 0)
            //         ? "Even is greater than Odd"
            //         :
            //         "Even and Odd are the same";
        }
    }
}