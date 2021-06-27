/*
https://www.codewars.com/kata/588e0f11b7b4a5b373000041/csharp

7 kyu
Temperature analysis I

You were given a string of integer temperature values. 
Create a function lowest_temp(t) and return the lowest value or None/null/Nothing if the string is empty.
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class TemperatureAnalysisI
    {
        public static int? LowestTemperature(string t)
        {
            // return string.IsNullOrEmpty(t) ? (int?) null : Array.ConvertAll(t.Split(), Convert.ToInt32).Min();
            // return t.Length > 0 ? t.Split().Select(int.Parse).Min() : new int?();
            // return t != "" ? t.Split().Min(int.Parse) : (int?) null;
            return t.Any() ? t.Split().Min(int.Parse) : (int?) null;
        }
    }
}