

//https://www.codewars.com/kata/holiday-viii-duty-free/train/csharp
//https://www.codewars.com/kata/57e92e91b63b6cbac20001e5/solutions/csharp

//Holiday VIII - Duty Free
//8 kyu

//The purpose of this kata is to work out just how many bottles of duty free whiskey you would have to buy such that the saving over the normal high street price would effectively cover the cost of your holiday.
//You will be given the high street price (normPrice), the duty free discount (discount) and the cost of the holiday.
//For example, if a bottle cost £10 normally and the discount in duty free was 10%, you would save £1 per bottle. If your holiday cost £500, the answer you should return would be 500.
//All inputs will be integers. Please return an integer. Round down.

using System;

namespace CodeWars
{
    public class HolidayVIIIDutyFree
    {
        public static int DutyFree(int normPrice, int Discount, int hol)
        {
            return (int)(hol / (normPrice * ((double)Discount / 100)));
        }

        //public static int DutyFree(int normPrice, int Discount, int hol)
        //{
        //    return (int)(hol / (normPrice * (Discount / 100f)));
        //}


        //public static int DutyFree(int normPrice, int Discount, int hol)
        //    => hol * 100 / normPrice / Discount ;


        //public static int DutyFree(int normPrice, int Discount, int hol)
        //{
        //    return (hol*10/((normPrice * Discount)/10));
        //}


        //public static int DutyFree(int normal, int discount, int hol)
        //{
        //    return (int)System.Math.Floor(hol / (normal * discount / 100.0));
        //}


        //public static int DutyFree(double normPrice, double Discount, double hol)
        //{
        //    return (int)(hol / (normPrice * Discount / 100.0)); 
        //}

        //public static int DutyFree(int normPrice, int Discount, int hol)
        //{
        //    return (int)(hol / ((float)normPrice * Discount/100));
        //}


    }
}