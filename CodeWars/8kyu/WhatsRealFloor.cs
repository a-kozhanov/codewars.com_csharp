/*
https://www.codewars.com/kata/whats-the-real-floor/train/csharp
https://www.codewars.com/kata/574b3b1599d8f897470018f6/solutions/csharp

8 kyu
What's the real floor?

Task Overview
Americans are odd people: in their buildings, the first floor is actually the ground floor and there is no 13th floor ('cause of superstition).

Write a function that given an American floor (passed as an integer) returns the real floor.
Moreover, your function should work for basement floors too: just return the same value as the passed one.

Usage Examples
GetRealFloor(1) == 0 
GetRealFloor(0) == 0 // Special case to please Europeans
GetRealFloor(5) == 4
GetRealFloor(15) == 13
GetRealFloor(-3) == -3
*/


using System;

namespace CodeWars
{
    public class WhatsRealFloor
    {
        public static int GetRealFloor(int n)
        {
            if (n <= 0) return n;
            if (n > 0 && n < 13) return n - 1;
            return n - 2;
        }


        //public static int GetRealFloor(int n)
        //{
        //    if(n > 12) return n-2;
        //    if(n > 0) return n-1;
        //    return n;
        //}

        //public static int GetRealFloor(int n) => n < 1 ? n : n > 13 ? n -2 : n- 1;


        //public static int GetRealFloor(int n)
        //{
        //    return n <= 0 ? n : (n < 13 ? n - 1 : n - 2);
        //}


        //public static Int32 GetRealFloor(Int32 n)
        //{
        //    if (n <= 0 ) return n;
        //    if(n > 13) return n - 2;
        //    return n - 1;
        //} 


        //public static int GetRealFloor(int n)
        //{
        //    if(n <1) return n;
        //    if(n >13) return n-2;
        //    return n-1;
        //}

        //public static int GetRealFloor(int n)
        //{
        //    if(n < 1)  return n;
        //    if(n < 14) return n - 1;
        //    else return n - 2;
        //}


    }
}