/*
https://www.codewars.com/kata/56eb0be52caf798c630013c0/csharp

7 kyu
Unlucky Days

Friday 13th or Black Friday is considered as unlucky day. Calculate how many unlucky days are in the given year.

Find the number of Friday 13th in the given year.

Input: Year as an integer.
Output: Number of Black Fridays in the year as an integer.

Examples:
unluckyDays(2015) == 3
unluckyDays(1986) == 1
Note: In Ruby years will start from 1593.
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class KataUnluckyDays
    {
        public static int UnluckyDays(int year)
        {
            // int friday = 0;
            // for (int i = 1; i <= 12; i++)
            // {
            //     if (new DateTime(year, i, 13).DayOfWeek == DayOfWeek.Friday) friday++;
            // }
            // return friday;

            //return Enumerable.Range(1, 12).Sum(m => new DateTime(year, m, 13).DayOfWeek == DayOfWeek.Friday ? 1 : 0);
            return Enumerable.Range(1, 12).Count(m => new DateTime(year, m, 13).DayOfWeek == DayOfWeek.Friday);
            //return Enumerable.Range(1, 12).Count(m => new DateTime(year, m, 13).DayOfWeek == (DayOfWeek) 5);
            //return Enumerable.Range(1, 12).Count(m => (int) new DateTime(year, m, 13).DayOfWeek == 5);
            //return Enumerable.Range(1, 12).Count(m => new DateTime(year, m, 8).DayOfWeek == 0);
        }
    }
}