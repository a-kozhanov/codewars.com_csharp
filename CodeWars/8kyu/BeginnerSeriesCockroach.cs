using System;


//https://www.codewars.com/kata/beginner-series-number-4-cockroach/train/csharp
//https://www.codewars.com/kata/55fab1ffda3e2e44f00000c6/solutions/csharp

//Beginner Series #4 Cockroach
//8 kyu


//The cockroach is one of the fastest insects. Write a function which takes its speed in km per hour and returns it in cm per second, rounded down to the integer (= floored).
//For example:
//CockroachSpeed(1.08) == 30
//Note! The input is a Real number (actual type is language dependent) and is >= 0. The result should be an Integer.


namespace CodeWars
{
    public class BeginnerSeriesCockroach
    {
        public static int CockroachSpeed(double x)
        {
            return (int)(x / 0.036);
        }


        //public static int CockroachSpeed(double x)
        //{
        //    return (int) (x *  27.778);
        //}


        //public static int CockroachSpeed(double x)
        //{
        //    return (int)Math.Floor(x * 1000 / 36);
        //}

        //public static int CockroachSpeed(double x)
        //{
        //    return Convert.ToInt32(Math.Floor(x / 10 / 3.6 * 1000));
        //}

        //public static int CockroachSpeed(double x)
        //{
        //    return (int) Math.Floor(x*10000/360);
        //}


        //public static double CockroachSpeed(double x)
        //{
        //    return Math.Floor(x*10000/360);
        //}


        //public static int CockroachSpeed(double x)
        //{
        //    return (int)(100000.0 / 3600.0 * x);
        //}


        //public static int CockroachSpeed(double x)
        //{
        //    return (int) (x * 27.777777778);
        //}






    }
}