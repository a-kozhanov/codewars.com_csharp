/*
https://www.codewars.com/kata/537baa6f8f4b300b5900106c/csharp

7 kyu
Area of a Circle

Complete the function circleArea so that it will return the area of a circle with the given radius. 
Round the returned number to two decimal places (except for Haskell).
If the radius is not positive or not a number, return false.

Example:
Kata.CalculateAreaOfCircle("-123"); //throws ArgumentException
Kata.CalculateAreaOfCircle("0"); //throws ArgumentException
Kata.CalculateAreaOfCircle("43.2673"); //return 5881.25
Kata.CalculateAreaOfCircle("68"); //return 14526.72
Kata.CalculateAreaOfCircle("number"); //throws ArgumentException
*/

using System;
using System.Globalization;

namespace CodeWars
{
    public class AreaOfCircle
    {
        public static double CalculateAreaOfCircle(string radius)
        {
            return double.TryParse(radius, NumberStyles.Float, CultureInfo.InvariantCulture, out var r) && r > 0
                ? Math.Round(r * r * Math.PI, 2)
                : throw new ArgumentException();


            // if (double.TryParse(radius, NumberStyles.Float, null, out var r) && r > 0)
            //     return Math.Round(r * r * Math.PI, 2);
            // throw new ArgumentException();


            // if (!double.TryParse(radius, NumberStyles.Float, null, out var r) || r <= 0)
            //     throw new ArgumentException();
            // return Math.Round(r * r * Math.PI, 2);

            // if (radius.Contains(",") || !double.TryParse(radius, out var r) || r <= 0) throw new ArgumentException();
            // return Math.Round(Math.PI * r * r, 2);

            // if (double.TryParse(radius, NumberStyles.Float, CultureInfo.InvariantCulture, out var r) && r > 0)
            //     return Math.Round(r * r * Math.PI, 2);
            //
            // throw new ArgumentException();


            //return Math.Round(result * result * 3.141592, 2);

            // if (!double.TryParse(radius.Replace(',', '#'), out double r) || r <= 0)
            //     throw new ArgumentException();
            //
            // return Math.Round(r * r * Math.PI, 2);


            // if (radius.Contains(",") || !double.TryParse(radius, out var r) || r <= 0) throw new ArgumentException();
            // return Math.Round(Math.PI * r * r, 2);

            // if (double.TryParse(radius, NumberStyles.Float, CultureInfo.CurrentCulture, out var r) && r > 0)
            //     return Math.Round(Math.PI * (r * r), 2);
            //
            // throw new ArgumentException();


            // if (double.TryParse(radius, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out var r) && r > 0)
            //     return Math.Round(Math.PI * (r * r), 2);
            //
            // throw new ArgumentException();


            // CultureInfo usCulture = new CultureInfo("en-US");
            // NumberFormatInfo dbNumberFormat = usCulture.NumberFormat;
            // double number = double.TryParse(radius, dbNumberFormat);
            //
            // if (number is null) throw new ArgumentException();


            // try
            // {
            //     // double number = Convert.ToDouble(radius, CultureInfo.CurrentCulture);
            //     if (radius.Contains(",")) throw new ArgumentException();
            //     double number = Convert.ToDouble(radius);
            //     if (number < 1) throw new ArgumentException();
            //     return Math.Round(Math.PI * Math.Pow(number, 2), 2);
            // }
            // catch (Exception)
            // {
            //     throw new ArgumentException();
            // }


            // Console.WriteLine(radius);
            //
            // if (double.TryParse(radius, out double d))
            // {
            //     if (d < 1) throw new ArgumentException();
            //     return Math.Round(Math.PI * Math.Pow(d, 2), 2);
            // }
            //
            // throw new ArgumentException();
        }
    }
}