/*
https://www.codewars.com/kata/tip-calculator/train/csharp
https://www.codewars.com/kata/56598d8076ee7a0759000087/solutions/csharp

8 kyu
Tip Calculator

Complete the function, which calculates how much you need to tip based on the total amount of the bill and the service.

You need to consider the following ratings:

Terrible: tip 0%
Poor: tip 5%
Good: tip 10%
Great: tip 15%
Excellent: tip 20%
The rating is case insensitive (so "great" = "GREAT"). If an unrecognised rating is received, then you need to return:

"Rating not recognised" in Javascript, Python and Ruby...
...or null in Java
...or -1 in C#
Because you're a nice person, you always round up the tip, regardless of the service.
*/

using System;
using System.Collections.Generic;

namespace CodeWars
{
    public class TipCalculator
    {
        public static int CalculateTip(double amount, string rating)
        {
            switch (rating.ToLower())
            {
                case "terrible": return 0;
                case "poor": return (int)Math.Ceiling(amount * 0.05);
                case "good": return (int)Math.Ceiling(amount * 0.1);
                case "great": return (int)Math.Ceiling(amount * 0.15);
                case "excellent": return (int)Math.Ceiling(amount * 0.2);
                default: return -1;
            }
        }


        //private static Dictionary<string, double> tip = new Dictionary<string, double>() {
        //    {"terrible" , 0} ,
        //    {"poor", 0.05} ,
        //    {"good", 0.1},
        //    {"great", 0.15},
        //    {"excellent", 0.2}
        //};

        //public static int CalculateTip(double amount, string rating)
        //    => tip.ContainsKey(rating.ToLower()) ? (int)Math.Ceiling(tip[rating.ToLower()] * amount) : -1;



        //public static int CalculateTip(double amount, string rating)
        //{
        //    Dictionary<string, double> tips = new Dictionary<string, double>()
        //    {
        //        {"terrible", 0},
        //        {"poor", 0.05},
        //        {"good", 0.1},
        //        {"great", 0.15},
        //        {"excellent", 0.2}
        //    };
        //    double tip = 0;
        //    if (tips.TryGetValue(rating.ToLower(), out tip))
        //        return (int)Math.Ceiling(amount * tip);
        //    else
        //        return -1;
        //}



        //private static Dictionary<string, double> tip = new Dictionary<string, double>() {
        //    {"terrible",  0.00},
        //    {"poor",      0.05},
        //    {"good",      0.10},
        //    {"great",     0.15},
        //    {"excellent", 0.20}
        //};

        //public static int CalculateTip(double amount, string rating) =>
        //    tip.ContainsKey(rating.ToLower()) ? (int)Math.Ceiling(amount * tip[rating.ToLower()]) : -1;


    }
}