/*
https://www.codewars.com/kata/569218bc919ccba77000000b/csharp

7 kyu
Target Date

You have an amount of money a0 > 0 and you deposit it with a constant interest rate of p% > 0 per year on the 1st of January 2016. 
You want to have an amount a >= a0.

Task:
The function date_nb_days (or dateNbDays...) with parameters a0, a, p will return, as a string, 
the date on which you have just reached a.

Example:
date_nb_days(100, 101, 0.98) --> "2017-01-01" (366 days)
date_nb_days(100, 150, 2.00) --> "2035-12-26" (7299 days)

Notes:
The return format of the date is "YYYY-MM-DD"
The deposit is always on the "2016-01-01"
If p% is the rate for a year take the rate for a day to be p divided by 36000 ; 
banks consider that there are 360 days in a year.
You have: a0 > 0, p% > 0, a >= a0
*/

using System;

namespace CodeWars
{
    public class TargetDate
    {
        public static String DateNbDays(double a0, double a, double p)
        {
            //return (new DateTime(2016, 1, 1) + TimeSpan.FromDays(Math.Log(a / a0, 1 + p / 36000) + 1)).ToString("yyyy-MM-dd");
            //return new DateTime(2016, 01, 01).AddDays(Math.Ceiling(Math.Log(a / a0, 1 + p / 36000))).ToString("yyyy-MM-dd");
            //return new DateTime(2016, 1, 1).AddDays(Math.Ceiling(Math.Log(a / a0, 1 + p / 36000))).ToString("yyyy-MM-dd");
            //return $"{new DateTime(2016, 1, 1).AddDays(Math.Ceiling(Math.Log(a / a0, 1 + p / 36000))):yyyy-MM-dd}";
            //return new DateTime(2016, 1, 2).AddDays((int) Math.Log(a / a0, 1 + p / 36000)).ToString("yyyy-MM-dd");

            return $"{new DateTime(2016, 1, 2).AddDays((int) Math.Log(a / a0, 1 + p / 36000)):yyyy-MM-dd}";
        }
    }
}