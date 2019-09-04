using System;
using System.Collections.Generic;
using System.Text;
using CodeWars;

//https://www.codewars.com/kata/5a3fe3dde1ce0e8ed6000097/solutions/csharp
//https://www.codewars.com/kata/century-from-year/train/csharp

//Century From Year

//Description:
//Introduction
//The first century spans from the year 1 up to and including the year 100, The second - from the year 101 up to and including the year 200, etc.

//Task :
//Given a year, return the century it is in.

//Input , Output Examples ::
//centuryFromYear(1705)  returns(18)
//centuryFromYear(1900)  returns(19)
//centuryFromYear(1601)  returns(17)
//centuryFromYear(2000)  returns(20)
//Hope you enjoy it .. Awaiting for Best Practice Codes

//Enjoy Learning !!!

namespace CodeWars
{
    public class CenturyFromYear
    {
        public static int centuryFromYear(int year)
        {
            int result = year / 100;
            if (year % 100 > 0) result++;
            return result;
        }

        //Best Practices
        //public static int СenturyFromYear(int year) => (year - 1) / 100 + 1;


        //public static int СenturyFromYear(int year)
        //{
        //    return (year - 1) / 100 + 1;
        //}

        //public static int СenturyFromYear(int year) => year % 100 == 0 ? year / 100 : year / 100 + 1;


        //public static int СenturyFromYear(int year)
        //{
        //    return (int)Math.Ceiling(year * 0.01);
        //}



        //public static int СenturyFromYear(int year) => (year + 99) / 100;







    }
}
