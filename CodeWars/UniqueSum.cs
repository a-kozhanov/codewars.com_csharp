/*
https://www.codewars.com/kata/56b1eb19247c01493a000065/csharp

7 kyu
Unique Sum

Given a list of integers values, your job is to return the sum of the values; however, 
if the same integer value appears multiple times in the list, you can only count it once in your sum.

For example:
Kata.UniqueSum(new List<int> {1, 2, 3}) => 6
Kata.UniqueSum(new List<int> {1, 3, 8, 1, 8}) => 12
Kata.UniqueSum(new List<int> {-1, -1, 5, 2, -7}) => -1
Kata.UniqueSum(new List<int>()) => null

Good Luck!
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class KataUniqueSum
    {
        public static int? UniqueSum(List<int> lst)
        {
            //return lst.Count != 0 ? lst.Distinct().Sum() : (int?) null;
            //return lst.Count == 0 ? new int?() : lst.Distinct().Sum();
            //return !lst.Any() ? (int?) null : lst.Distinct().Sum();
            //return lst.Any() ? new HashSet<int>(lst).Sum() : (int?) null;
            //return lst.Any() ? (int?) lst.Distinct().Sum() : null;
            //return lst.Any() ? lst.Distinct().Sum() : (int?) null;
            //return lst?.Count == 0 ? null : lst?.Distinct().Sum();
            return lst.Any() ? lst.Distinct().Sum() : new int?();
        }
    }
}