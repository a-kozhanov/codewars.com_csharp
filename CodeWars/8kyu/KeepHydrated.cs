
//https://www.codewars.com/kata/keep-hydrated-1/train/csharp
//https://www.codewars.com/kata/582cb0224e56e068d800003c/solutions/csharp

//Keep Hydrated!
//8 kyu

//Nathan loves cycling.
//Because Nathan knows it is important to stay hydrated, he drinks 0.5 litres of water per hour of cycling.
//You get given the time in hours and you need to return the number of litres Nathan will drink, rounded to the smallest value.

//For example:
//time = 3 ----> litres = 1
//time = 6.7---> litres = 3
//time = 11.8--> litres = 5


using System;

namespace CodeWarsTests
{
    public class KeepHydrated
    {
        public static int Litres(double time)
        {
            return (int)time / 2;
        }


        //public static int Litres(double time) => (int)(time*0.5);

        //public static int Litres(double time)
        //{
        //    return Convert.ToInt32(Math.Floor(time * 0.5));
        //}

        //public static int Litres(double time)
        //{
        //    return (int) (time*0.5);
        //}

        //public static int Litres(double time)
        //{
        //    return (int)Math.Floor(time * 0.5); // Using cast and Math fucntions, wow.                    ILLUMINATI  R Z BEST
        //}

        //public static int Litres(double time)
        //{
        //    return (int)(time * .5);
        //}


    }
}