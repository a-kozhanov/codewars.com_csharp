/*
https://www.codewars.com/kata/58a66c208b88b2de660000c3/csharp

7 kyu
Simple Fun #136: Missing Values

Task
You are given an array of positive ints where every element appears three times, 
except one that appears only once (let's call it x) and one that appears only twice (let's call it y).

Your task is to find x * x * y.

Example
For arr=[1, 1, 1, 2, 2, 3], the result should be 18

3 x 3 x 2 = 18

For arr=[6, 5, 4, 100, 6, 5, 4, 100, 6, 5, 4, 200], the result should be 4000000

200 x 200 x 100 = 4000000

Input/Output
[input] integer array arr

an array contains positive integers.

[output] an integer

The value of x * x * y
*/

using System;
using System.Linq;
using System.Numerics;

namespace CodeWars
{
    public class SimpleFun136MissingValues
    {
        public int MissingValues(int[] arr)
        {
            // var x = arr.Count(i => i == 1);
            // var y = arr.Count(i => i == 2);
            //var x = arr.FirstOrDefault(i => arr.Count(v => v == i) == 1);
            //var y = arr.FirstOrDefault(i => arr.Count(v => v == i) == 2);
            //return x * x * y;


            // return (int) (Math.Pow(arr.FirstOrDefault(i => arr.Count(v => v == i) == 1), 2) *
            //               arr.FirstOrDefault(i => arr.Count(v => v == i) == 2));


            //return arr.FirstOrDefault(i => arr.Count(v => v == i) == 1) *
            //return arr.Where(i => arr.Count(v => v == i) < 3).Aggregate((a, b) => a * b);


            // var tmp = arr.GroupBy(c => c).OrderBy(c => c.Count()).ToArray();
            // return tmp.ElementAt(0).Key * tmp.ElementAt(0).Key * tmp.ElementAt(1).Key;


            // return arr.Where(x => arr.Count(y => y == x) == 1).First() *
            //        arr.Where(x => arr.Count(y => y == x) == 1).First() *
            //        arr.Where(x => arr.Count(y => y == x) == 2).First();


            // return arr
            //     .GroupBy(i => i)
            //     .Where(g => g.Count() < 3)
            //     .Select(g => (int) Math.Pow(g.Key, 3 - g.Count()))
            //     .Aggregate((acc, cur) => acc * cur);


            // var res = arr.OrderBy(x => arr.Count(el => el == x)).ToArray();
            // return res[0] * res[0] * res[1];


            // return arr.GroupBy(x => x)
            //     .OrderBy(x => x.Count())
            //     .Select(x => x.Key)
            //     .Take(2)
            //     .Aggregate((x, y) => x * x * y);


            // return (int) (arr.Distinct().Aggregate(new BigInteger(1), (a, b) => a *= b * b * b) /
            //               arr.Aggregate(new BigInteger(1), (a, b) => a *= b));


            // return arr.GroupBy(x => x).Where(g => g.Count() <= 2)
            //     .Select(x => (int) Math.Pow(x.ElementAt(0), 3 - x.Count())).Aggregate((x, y) => (x * y));


            //return arr.GroupBy(x => x, (k, v) => new {k = k, c = v.Count()}).Where(x => x.c < 3).Select(x => x.c < 2 ? x.k * x.k : x.k).Aggregate((x, y) => x * y);


            // return (int) (arr.Distinct().Aggregate(new int[] {1},(a, b) => a * (b * b * b)) /
            //               arr.Aggregate(new BigInteger(1), (a, b) => a * b));

            // return arr.GroupBy(x => x)
            //     .OrderBy(x => x.Count())
            //     .Select(x => x.Key)
            //     .Take(2)
            //     .Aggregate((x, y) => x * x * y);


            // arr.GroupBy(x => x, (c, g) => (c, g.Count())).Where(x => x.Item2 < 3)
            //     .Aggregate((x, y) => x.Item2 * x.Item2 * y.Item2);


            // return arr.GroupBy(i => i).Where(g => g.Count() < 3)
            //     .Select(x => (int) Math.Pow(x.ElementAt(0), 3 - x.Count())).Aggregate((x, y) => x * y);


            // return (int) (Math.Pow(arr.First(i => arr.Count(v => v == i) == 1), 2) *
            //               arr.First(i => arr.Count(v => v == i) == 2));

            return arr.GroupBy(i => i).Where(g => g.Count() < 3)
                .Select(x => (int) Math.Pow(x.Key, 3 - x.Count()))
                .Aggregate((x, y) => x * y);
        }
    }
}