
//https://www.codewars.com/kata/transportation-on-vacation/train/csharp
//https://www.codewars.com/kata/568d0dd208ee69389d000016/solutions/csharp

//Transportation on vacation
//8 kyu

//After a hard quarter in the office you decide to get some rest on a vacation.
//So you will book a flight for you and your girlfriend and try to leave all the mess behind you.
//You will need a rental car in order for you to get around in your vacation.
//The manager of the car rental makes you some good offers.
//Every day you rent the car costs $40. If you rent the car for 7 or more days,
//you get $50 off your total. Alternatively, if you rent the car for 3 or more days, you get $20 off your total.
//Write a code that gives out the total amount for different days(d).


using System;

namespace CodeWars
{
    public class TransportationVacation
    {
        public static int RentalCarCost(int d)
        {
            if (d >= 7) return d * 40 - 50;
            if (d >= 3) return d * 40 - 20;
            return d * 40;
        }


        //public static int RentalCarCost(int d)
        //{
        //    return d * 40 - (d > 6 ? 50 : d > 2 ? 20 : 0);
        //}



        //public static int RentalCarCost(int d)
        //{
        //    int totalAmount = d * 40;
        //    if (d > 6)
        //    {
        //        totalAmount = totalAmount - 50;
        //    }
        //    else if (d > 2)
        //    {
        //        totalAmount = totalAmount - 20;
        //    }
        //    return totalAmount;
        //}


        //public static int RentalCarCost(int d)
        //{
        //    return d >= 7 ? d * 40 - 50 : d >= 3 ? d * 40 - 20 : d * 40;
        //}


        //public static Int32 RentalCarCost(Int32 Input)
        //{
        //    return Input * 40 - ((Input > 6) ? 50 : ((Input > 2) ? 20 : 0));
        //}


        //public static int RentalCarCost(int d)
        //{
        //    return d * 40 - (d > 2 ? (d > 6 ? 50 : 20) : 0);
        //}

        //public static int RentalCarCost(int d)
        //{
        //    Console.WriteLine(d);
        //    return d * 40 - (d >= 7 ? 50 : d >= 3 ? 20 : 0);
        //}

        //public static int RentalCarCost(int d)
        //{
        //    return d < 3 ? d * 40 : (d >= 7 ? d * 40 - 50 : d * 40 - 20);
        //}


    }
}