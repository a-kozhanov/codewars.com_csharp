/*
https://www.codewars.com/kata/55bf01e5a717a0d57e0000ec/csharp

6 kyu
Persistent Bugger.

Write a function, persistence, that takes in a positive parameter num and returns its multiplicative persistence, 
which is the number of times you must multiply the digits in num until you reach a single digit.

For example:

 persistence(39) == 3 // because 3*9 = 27, 2*7 = 14, 1*4=4
                      // and 4 has only one digit

 persistence(999) == 4 // because 9*9*9 = 729, 7*2*9 = 126,
                       // 1*2*6 = 12, and finally 1*2 = 2

 persistence(4) == 0 // because 4 is already a one-digit number
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class PersistentBugger
    {
        public static long Persistence(long n)
        {
            //return n < 10 ? 0 : 1 + Persistence(n.ToString().Select(c => c - 48).Aggregate(1, (a, b) => a * b));
            //return n < 10 ? 0 : 1 + Persistence($"{n}".Select(c => c - 48).Aggregate((x, y) => x * y));
            //return n < 10 ? 0 : 1 + Persistence($"{n}".Aggregate(1, (a, b) => a * (b - '0')));
            return n < 10 ? 0 : 1 + Persistence($"{n}".Aggregate(1, (a, b) => a * (b - 48)));
        }
    }
}