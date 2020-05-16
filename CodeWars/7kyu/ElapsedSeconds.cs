/*
https://www.codewars.com/kata/517b25a48557c200b800000c/csharp

7 kyu
Elapsed Seconds

Complete the function so that it returns the number of seconds that have elapsed between the start and end times given.

Tips:
The start/end times are given as Date (JS/CoffeeScript), DateTime (C#), Time (Nim), datetime(Python) and Time (Ruby) instances.
The start time will always be before the end time.
*/

using System;

namespace CodeWars
{
    public class KataElapsedSeconds
    {
        public static int ElapsedSeconds(DateTime startDate, DateTime endDate)
        {
            //return Convert.ToInt32((endDate - startDate).TotalSeconds);
            //return (int) endDate.Subtract(startDate).TotalSeconds;
            return (int) (endDate - startDate).TotalSeconds;
        }
    }
}