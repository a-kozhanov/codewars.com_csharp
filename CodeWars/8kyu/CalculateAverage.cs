
//https://www.codewars.com/kata/calculate-average/train/csharp
//https://www.codewars.com/kata/57a2013acf1fa5bfc4000921/solutions/csharp

//Calculate average
//8 kyu

//Write function avg which calculates average of numbers in given list.


using System;
using System.Linq;

namespace CodeWars
{
    public class CalculateAverage
    {
        public static double FindAverage(double[] array)
        {
            return (double) array?.Average();
            return array.Length == 0 ? 0 : array.Average();
        }


        //public static Double FindAverage( Double[] array )
        //{
        //    if ( array == null )
        //        throw new ArgumentNullException( nameof( array ), "Array can not be null" );

        //    return array.Any() ? array.Average() : 0;
        //}


        //public static double FindAverage(double[] array) => array.DefaultIfEmpty().Average();



    }
}