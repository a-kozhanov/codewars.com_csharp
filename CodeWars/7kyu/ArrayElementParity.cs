/*
https://www.codewars.com/kata/5a092d9e46d843b9db000064/train/csharp

7 kyu
Array element parity

In this Kata, you will be given an array of integers whose elements have both a negative and a positive value, 
except for one integer that is either only negative or only positive. Your task will be to find that integer.

For example,

solve[1,-1,2,-2,3] = 3  --> 3 only has a positive ocurrence.
solve([-3,1,2,3,-1,-4,-2]) = -4  --> -4 only has a negative occurence
solve([1,-1,2,-2,3,3]) = 3  --> the integer that is only positive or only negative my appear more than once.

Good luck!
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class ArrayElementParity
    {
        public static int Solve(List<int> arr)
        {
            //return arr.Distinct().Aggregate(0, (s, n) => s + n);
            //return arr.First(x => !arr.Any(y => y == -x));
            //return arr.First(x => !arr.Contains(x * -1));
            //return arr.First(x => arr.All(y => y != -x));
            //return arr.First(x => !arr.Contains(-x));
            //return new HashSet<int>(arr).Sum();
            return arr.Distinct().Sum();
        }
    }
}