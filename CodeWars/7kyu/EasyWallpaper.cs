/*
https://www.codewars.com/kata/567501aec64b81e252000003/csharp

7 kyu
Easy wallpaper

John wants to decorate a room with wallpaper. He wants a fool-proof method for getting it right.

John knows that the rectangular room has a length of l meters, a width of w meters, a height of h meters.
The standard width of the rolls he wants to buy is 52 centimeters. The length of a roll is 10 meters. He bears in mind however, 
that it’s best to have an extra length of wallpaper handy in case of mistakes or miscalculations so he wants to buy a length 15% greater than the one he needs.

Last time he did these calculations he got a headache, so could you help John?

Task
Your function wallpaper(l, w, h) should return as a plain English word in lower case the number of rolls he must buy.

Example:
wallpaper(4.0, 3.5, 3.0) should return "ten"
wallpaper(0.0, 3.5, 3.0) should return "zero"

Notes:
all rolls (even with incomplete width) are put edge to edge
0 <= l, w, h (floating numbers); it can happens that w * h * l is zero
the integer r (number of rolls) will always be less or equal to 20
FORTH: the number of rolls will be a positive or null integer (not a plain English word; this number can be greater than 20)

In Javascript English numbers are preloaded and can be accessed as:

numbers = ["zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve","thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen", "twenty"]
For other languages it is not preloaded but you can use the above one if you need it.
*/

using System;
using System.Collections.Generic;

namespace CodeWars
{
    public class EasyWallpaper
    {
        public static string WallPaper(double l, double w, double h)
        {
            return l == 0 || w == 0 || h == 0
                ? "zero"
                : new[]
                {
                    "zero", "one", "two", "three", "four", "five", "six", "seven",
                    "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen",
                    "fifteen", "sixteen", "seventeen", "eighteen", "nineteen", "twenty"
                }[(int) Math.Ceiling((l + w) * 2.3 * h / 5.2)];


            // string[] numbers =
            // {
            //     "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven",
            //     "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen", "twenty"
            // };
            // return l == 0 || w == 0 || h == 0 ? numbers[0] : numbers[(int) Math.Ceiling((l + w) * 2.3 * h / 5.2)];
            // return l == 0 || w == 0 || h == 0 ? numbers[0] : numbers[(int) Math.Ceiling((l + w) * 2 * h / 5.2 * 1.15)];

            // var numbers = new Dictionary<int, string>()
            // {
            //     {0, "zero"}, {1, "one"}, {2, "two"}, {3, "three"}, {4, "four"}, {5, "five"},
            //     {6, "six"}, {7, "seven"}, {8, "eight"}, {9, "nine"}, {10, "ten"}, {11, "eleven"},
            //     {12, "twelve"}, {13, "thirteen"}, {14, "fourteen"}, {15, "fifteen"}, {16, "sixteen"},
            //     {17, "seventeen"}, {18, "eighteen"}, {19, "nineteen"}, {20, "twenty"}
            // };
            //
            // return l == 0 || w == 0 || h == 0 ? numbers[0] : numbers[(int) Math.Ceiling((l + w) * 2.3 * h / 5.2)];
        }
    }
}