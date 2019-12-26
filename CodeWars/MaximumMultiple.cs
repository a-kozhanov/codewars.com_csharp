/*
https://www.codewars.com/kata/maximum-multiple/train/csharp


7 kyu
Maximum Multiple

Task
Given a Divisor and a Bound , Find the largest integer N , Such That ,

Conditions :
N is divisible by divisor

N is less than or equal to bound

N is greater than 0.

Notes
The parameters (divisor, bound) passed to the function are only positve values .
It's guaranteed that a divisor is Found .
Input >> Output Examples
maxMultiple (2,7) ==> return (6)
Explanation:
(6) is divisible by (2) , (6) is less than or equal to bound (7) , and (6) is > 0 .

maxMultiple (10,50)  ==> return (50)
Explanation:
(50) is divisible by (10) , (50) is less than or equal to bound (50) , and (50) is > 0 .*

maxMultiple (37,200) ==> return (185)
Explanation:
(185) is divisible by (37) , (185) is less than or equal to bound (200) , and (185) is > 0 .

Playing with Numbers Series
Playing With Lists/Arrays Series
Bizarre Sorting-katas
For More Enjoyable Katas
ALL translations are welcomed
Enjoy Learning !!
Zizou
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class MaximumMultiple
    {
        public static int MaxMultiply(int divisor, int bound)
        {
            return Enumerable.Range(0, bound + 1).Where(x => x % divisor == 0).Max();
        }

        //public static int MaxMultiply(int divisor, int bound) => bound / divisor * divisor;

        // public static int MaxMultiply(int divisor, int bound)
        // {
        //     return bound - bound % divisor;
        // }

        // public static int MaxMultiply(int divisor, int bound)
        // {
        //     return divisor*(int)(bound/divisor);
        // }
    }
}