
//https://www.codewars.com/kata/twice-as-old/train/csharp
//https://www.codewars.com/kata/5b853229cfde412a470000d0/solutions/csharp

//Twice as old
//8 kyu

//Your function takes two arguments:
//current father's age (years)
//current age of his son (years)
//Сalculate how many years ago the father was twice as old as his son (or in how many years he will be twice as old).


using System;

namespace CodeWars
{
    public class KataTwiceAsOld
    {
        public static int TwiceAsOld(int dadYears, int sonYears)
        {
            return Math.Abs(sonYears - (dadYears - sonYears));
        }

        //public static int TwiceAsOld(int dadYears, int sonYears)
        //{
        //    return Math.Abs(dadYears - sonYears * 2);
        //}


    }
}