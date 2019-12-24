/*
https://www.codewars.com/kata/nba-full-48-minutes-average/train/csharp
https://www.codewars.com/kata/587c2d08bb65b5e8040004fd/solutions/csharp

8 kyu
NBA full 48 minutes average

An NBA game runs 48 minutes (Four 12 minute quarters). Players do not typically play the full game, subbing in and out as necessary. 
Your job is to extrapolate a player's points per game if they played the full 48 minutes.

Write a function that takes two arguments, ppg (points per game) and mpg (minutes per game) and 
returns a straight extrapolation of ppg per 48 minutes rounded to the nearest tenth. Return 0 if 0.

Examples:
Kata.NbaExtrap(12, 20) => 28.8
Kata.NbaExtrap(10, 10) => 48
Kata.NbaExtrap(5, 17)  => 14.1
Kata.NbaExtrap(0, 0)   => 0
Notes:
All inputs will be either be an integer or float.
Follow your dreams!
*/

using System;

namespace CodeWars
{
    public class NBAFull48MinutesAverage
    {
        public static double NbaExtrap(double ppg, double mpg)
        {
            return ppg > 0 ? Math.Round(ppg * (48 / mpg), 1) : 0;
        }
    }
}


// public static double NbaExtrap(double ppg, double mpg) => mpg == 0 ? 0 : Math.Round(48.0 / mpg * ppg, 1);



// public static double NbaExtrap(double ppg, double mpg)
// {
// return mpg == 0 ? 0 : Math.Round((ppg / mpg) * 48 ,1);
// }


// public static double NbaExtrap(double p, double m) => p == 0 || m == 0 ? 0 : Math.Round(p/m*48, 1);


