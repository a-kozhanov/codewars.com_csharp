/*
https://www.codewars.com/kata/form-the-minimum/train/csharp
https://www.codewars.com/kata/5ac6932b2f317b96980000ca/solutions/csharp

7 kyu
Form The Minimum

Task
Given a list of digits, return the smallest number that could be formed from these digits, using the digits only once (ignore duplicates).

Notes:
Only positive integers will be passed to the function (> 0 ), no negatives or zeros.
Input >> Output Examples
minValue ({1, 3, 1})  ==> return (13)
Explanation:
(13) is the minimum number could be formed from {1, 3, 1} , Without duplications

minValue({5, 7, 5, 9, 7})  ==> return (579)
Explanation:
(579) is the minimum number could be formed from {5, 7, 5, 9, 7} , Without duplications

minValue({1, 9, 3, 1, 7, 4, 6, 6, 7}) return  ==> (134679)
Explanation:
(134679) is the minimum number could be formed from {1, 9, 3, 1, 7, 4, 6, 6, 7} , Without duplications

Playing with Numbers Series
Playing With Lists/Arrays Series
Bizarre Sorting-katas
For More Enjoyable Katas
ALL translations are welcomed
Enjoy Learning !!
Zizou
*/

using System.Linq;

namespace CodeWars
{
    public class FormMinimum
    {
        public static long MinValue(int[] a)
        {
            return long.Parse(string.Concat(a.Distinct().OrderBy(n => n)));
        }

        // public static long MinValue(int[] a)
        // {
        //     var res = string.Concat(a.OrderBy(x => x).Distinct());
        //     return Convert.ToInt64(res);
        // }

        // public static long MinValue(int[] a) => a.Distinct().OrderBy(x=>x).Aggregate(0,(s,n)=> s * 10 +n);


        // public static long MinValue(int[] a) => a.OrderByDescending(d => d).Distinct().Select((d, i) => (long)d * (long)Math.Pow(10, i)).Sum();


        // public static long MinValue(int[] a) => a.OrderBy(x => x).Distinct().Aggregate(0L, (x, y) => x * 10 + y);


        // public static long MinValue(int[] array)
        // {
        //     return array.OrderBy(v => v).Distinct().Aggregate((a,b) => a * 10 + b);
        // }

        // public static long MinValue(int[] a)
        // {
        //     return long.Parse(string.Concat(a.Distinct().OrderBy(i => i).Select(i => i.ToString())));
        // }
    }
}