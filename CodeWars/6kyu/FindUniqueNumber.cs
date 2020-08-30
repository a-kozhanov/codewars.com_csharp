/*
https://www.codewars.com/kata/585d7d5adb20cf33cb000235/csharp

6 kyu
Find the unique number

There is an array with some numbers. All numbers are equal except for one. Try to find it!

findUniq([ 1, 1, 1, 2, 1, 1 ]) === 2
findUniq([ 0, 0, 0.55, 0, 0 ]) === 0.55
It’s guaranteed that array contains at least 3 numbers.

The tests contain some very huge arrays, so think about performance.

This is the first kata in series:

Find the unique number (this kata)
Find the unique string
Find The Unique
*/

using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class FindUniqueNumber
    {
        public static int GetUnique(IEnumerable<int> numbers)
        {
            //return (int)numbers.Where(n => numbers.Count(x => x == n) == 1).ToArray().GetValue(0);
            //return numbers.GroupBy(x => x).Where(x => x.Count() == 1).SelectMany(x => x).First();
            //return numbers.GroupBy(item => item).OrderBy(item => item.Count()).First().Key;
            //return numbers.ToList().Find(x => numbers.ToList().Count(y => y == x) == 1);
            //return numbers.OrderBy(x => numbers.Where(y => y == x).Count()).First();
            //return numbers.Distinct().First(x => numbers.Count(y => y == x) == 1);
            //return numbers.FirstOrDefault(x => numbers.Count(y => y == x) == 1);
            //return numbers.GroupBy(x => x).First(y => y.Count() == 1).First();
            //return numbers.OrderBy(x => numbers.Count(y => y == x)).First();
            //return numbers.GroupBy(x => x).Single(x => x.Count() == 1).Key;
            //return numbers.GroupBy(x => x).First(x => x.Count() == 1).Key;
            //return numbers.Single(x => numbers.Count(y => y == x) == 1);
            return numbers.First(x => numbers.Count(i => i == x) == 1);
        }
    }
}