/*
https://www.codewars.com/kata/551e51155ed5ab41450006e1/csharp

7 kyu
Sum Times Tables

Write a function sumTimesTables which sums the result of the sums of the elements specified in tables multiplied by all the numbers in between min and max including themselves.

For example, for sumTimesTables([2,5],1,3) the result should be the same as

2*1 + 2*2 + 2*3 +
5*1 + 5*2 + 5*3
i.e. the table of two from 1 to 3 plus the table of five from 1 to 3

All the numbers are integers but you must take in account:

tables could be empty.
min could be negative.
max could be really big.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace CodeWars
{
    public class SumTimesTables
    {
        public static long SumTimesTable(List<int> tables, long min, long max)
        {
            return (min + max) * (max - min + 1) / 2 * tables.Sum();
            // return tables.Sum(x => (long) x) * ((min + max) * (max - min + 1) / 2);
            // return (long) (tables.Sum() * (new BigInteger(min) + max) * (max - min + 1) / 2);
            // return tables.Select(v => (long) v).Sum(v => v * ((max + 1) * (max) / 2 - (min) * (min - 1) / 2));

            // long result = 0;
            // foreach (var t in tables)
            // {
            //     for (var i = min; i <= max; i++)
            //     {
            //         result += t * i;
            //     }
            // }
            //
            // return result;
        }
    }
}