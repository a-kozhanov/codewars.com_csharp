/*
https://www.codewars.com/kata/57b68bc7b69bfc8209000307/csharp

7 kyu
Average Scores

Create a function that returns the average of an array of numbers ("scores"), rounded to the nearest whole number. 
You are not allowed to use any loops (including for, for/in, while, and do/while loops).
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class AverageScores
    {
        public static double Average(int[] scores)
        {
            //return (int) Math.Round((double) scores.Sum() / scores.Length);
            return (int) Math.Round(scores.Average());
            //return Convert.ToInt32(scores.Average());
        }
    }
}