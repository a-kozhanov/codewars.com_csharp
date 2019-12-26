/*
https://www.codewars.com/kata/miles-per-gallon-to-kilometers-per-liter/train/csharp
https://www.codewars.com/kata/miles-per-gallon-to-kilometers-per-liter/solutions/csharp

8 kyu
Miles per gallon to kilometers per liter

Sometimes, I want to quickly be able to convert miles per imperial gallon into kilometers per liter.
Create an application that will display the number of kilometers per liter (output) based on the number of miles per imperial gallon (input).
Make sure to round off the result to two decimal points. If the answer ends with a 0, it should be rounded off without the 0. So instead of 5.50, we should get 5.5.
Some useful associations relevant to this kata: 1 Imperial Gallon = 4.54609188 litres 1 Mile = 1.609344 kilometres
*/

using System;

namespace CodeWars
{
    public class MilesPerGallonToKilometersPerLiter
    {
        public static double Converter(int mpg)
        {
            return Math.Round(mpg / 2.825, 2);
        }
    }
}


// public static double Converter(int mpg)
// {
// var kpg = mpg * 1.609344 ;
// var kpl = kpg /  4.54609188;
// return System.Math.Round(kpl,2);
// }


// public static double Converter(int mpg)
// {
// return Math.Round(mpg * 1.609344 / 4.54609188, 2);
// }


// public static double Converter(int mpg) {
// return Round(mpg * 0.35400604353, 2);
// }


// public static double Converter(int mpg)
// {
// double kpl = (1.609344 * mpg) / 4.54609188;
//     return Math.Round(kpl, 2);
// }


// public static double Converter(int mpg)
// {
// return Math.Round(mpg * 0.35400618997453, 2);
// }
