using System;
using System.Collections.Generic;
using System.Text;

//https://www.codewars.com/kata/l1-set-alarm/train/csharp
//https://www.codewars.com/kata/568dcc3c7f12767a62000038/solutions/csharp

//L1: Set Alarm

//Write a function named setAlarm which receives two parameters.
//The first parameter, employed, is true whenever you are employed and the second parameter, vacation is true whenever you are on vacation.
//The function should return true if you are employed and not on vacation(because these are the circumstances under which you need to set an alarm). 
//It should return false otherwise.

//Examples:
//setAlarm(true, true) -> false setAlarm(false, true) -> false setAlarm(false, false) -> false setAlarm(true, false) -> true

//setalarm(true, true) -> false
//setalarm(false, true) -> false
//setalarm(false, false) -> false
//setalarm(true, false) -> true

namespace CodeWars
{
    public class L1SetAlarm
    {
        public static bool SetAlarm(bool employed, bool vacation)
        {
            if (vacation) return false;
            if (!employed & !vacation) return false;
            return true;
        }

        //public static bool SetAlarm(bool employed, bool vacation)
        //{
        //    return (employed && !vacation) ? true : false;
        //}


        //public static bool SetAlarm(bool employed, bool vacation)
        //{
        //    if (employed == true && vacation == true) return false;
        //    if (employed == false && vacation == true) return false;
        //    if (employed == false && vacation == false) return false;
        //    if (employed == true && vacation == false) return true;
        //    return false;
        //}


        //public static bool SetAlarm(bool employed, bool vacation)
        //{
        //    return employed == true && vacation == false ? true : false;
        //}


        //public static bool SetAlarm(bool employed, bool vacation) => employed == true && vacation == false ? true : false;


        //public static bool SetAlarm(bool employed, bool vacation)
        //{
        //    if (employed && !vacation)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}


        //public static bool SetAlarm(bool employed, bool vacation)
        //{
        //    return employed & !vacation;
        //}


        //public static bool SetAlarm(bool employed, bool vacation)
        //{
        //    if (employed == true && vacation == false)
        //    {
        //        return true;
        //    }
        //    return false;
        //}

        //public static bool SetAlarm(bool employed, bool vacation)
        //{
        //    return employed == true & vacation == false ? true : false;
        //}



    }
}
