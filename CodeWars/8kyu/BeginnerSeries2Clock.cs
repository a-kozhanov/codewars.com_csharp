

//https://www.codewars.com/kata/beginner-series-number-2-clock/train/csharp
//https://www.codewars.com/kata/55f9bca8ecaa9eac7100004a/solutions/csharp

//8 kyu
//Beginner Series #2 Clock

//Clock shows 'h' hours, 'm' minutes and 's' seconds after midnight.
//Your task is to make 'Past' function which returns time converted to miliseconds.

//#####Example:
//Past(0, 1, 1) == 61000
//Note! h, m and s will be only Natural numbers! Waiting for translations and Feedback! Thanks!

using System;

namespace CodeWars
{
    public class BeginnerSeries2Clock
    {
        public static int Past(int h, int m, int s)
        {
            return (h * 60 * 60 + m * 60 + s) * 1000;
        }


        //public static int Past(int h, int m, int s)
        //{
        //    return (int)(new TimeSpan(h, m, s)).TotalMilliseconds;
        //}

        //public static int Past(int h, int m, int s)
        //{
        //    m += h * 60;
        //    s += m * 60;
        //    s *= 1000;
        //    return s;     
        //}


        //public static int Past(int h, int m, int s)
        //{
        //    //#Happy Coding! ^_^
        //    h = 1000 * 60 * 60 * h;
        //    m= 1000 * 60* m;
        //    s= 1000 * s;

        //    return h + m + s;
        //}


        //public static int Past(int h, int m, int s) => 1000 * (s + m * 60 + h * 3600); 


        //public static int Past(int h, int m, int s)
        //{
        //    return (s + m*60 + h*60*60) * 1000;
        //}



        //public static int Past(int h, int m, int s)
        //{
        //    //#Happy Coding! ^_^
        //    int msHours = 3600000;
        //    int msMins = 60000;
        //    int msSecs = 1000;

        //    return (h * msHours) + (m * msMins) + (s * msSecs);
        //}




    }
}