
/*
https://www.codewars.com/kata/parse-float/train/csharp
https://www.codewars.com/kata/57a386117cb1f31890000039/solutions/csharp

8 kyu
Parse float

Write function parseFloat (for Javascript parseF) which takes a string and returns a number or Nothing (for Python None, for Javascript null) if conversion is not possible.

*/


using System;

namespace CodeWars
{
    public class ParseFloat
    {
        public static double? ParseF(object s = null)
        {
            return double.TryParse(s?.ToString(), out var result) ? result : (double?)null;
        }


        //public static double? ParseF(object s = null)
        //{
        //    double i;
        //    if (double.TryParse(s as string, out i))
        //        return i;
        //    return null;
        //}



        //public static double? ParseF(object s = null)
        //{
        //    if (s == null)
        //    {
        //        return null;
        //    }

        //    var number = double.TryParse(s.ToString(), out var result);

        //    if (number == false)
        //    {
        //        return null;
        //    }

        //    return result;
        //}


        //public static double? ParseF(object s = null)
        //{
        //    float f;
        //    if (s != null && float.TryParse(s.ToString(), out f))
        //    {
        //        return f;
        //    }

        //    return null;
        //}


        //public static double? ParseF(object s = null)
        //{
        //    double result;
        //    if (double.TryParse(s as string, out result)) {
        //        return result;
        //    }

        //    return null;
        //}


        //public static double? ParseF(object s = null)
        //{
        //    double f;
        //    return double.TryParse(s as string, out f) ? (double?)f : null;
        //}


        //public static double? ParseF(object s = null)
        //{
        //    if(s == null || s.GetType() == typeof(Boolean))
        //        return null;
        //    try
        //    {
        //        return Convert.ToDouble(s);
        //    }
        //    catch
        //    {
        //        return null;
        //    }
        //}


        //public static double? ParseF(object s = null)
        //{  
        //    try
        //    {
        //        if (s.GetType() != typeof(bool))
        //            return Convert.ToDouble(s);
        //    }
        //    catch
        //    {}
        //    return null;
        //}


        //public static double? ParseF(object s = null)
        //    => Double.TryParse(s?.ToString(), out double d)
        //        ? (double?)d
        //        : null;


        //public static double? ParseF(object s = null)
        //{
        //    if(float.TryParse(s as string, out var res))
        //        return res;
        //    else return null;
        //}



    }
}