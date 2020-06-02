/*
https://www.codewars.com/kata/5ae329c3d2ee27a1f20000f2/csharp

7 kyu
How many Katas should I have done?

As a good developer you have to practice a lot. One way to achieve this is to finish one kata every day after work.

But of course you won't have time for that every day. So maybe you skip one week and think you can do two katas every day in the following week. 
But of course you lose track of how many katas you should have finished until today.

To control yourself, write a function which gets the start date of your codewars registration and returns how many katas you should have fninished until today. We will ignore public holidays.

Example:.
var registrationDate = new DateTime(2018, 01, 01);
var solvedKatas = KataCalculator.SolvedKatasSince(registrationDate, DateTime.Today);
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class HowManyKatasShouldIhaveDone
    {
        public static int SolvedKatasSince(DateTime registrationDate, DateTime currentDate)
        {
            return Enumerable.Range(0, (int) (currentDate - registrationDate).TotalDays)
                .Select(x => (int) registrationDate.AddDays(x).DayOfWeek).Count(x => x != 6 && x != 0);
        }
    }
}