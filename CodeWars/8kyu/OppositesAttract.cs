

//https://www.codewars.com/kata/opposites-attract/train/csharp
//https://www.codewars.com/kata/555086d53eac039a2a000083/solutions/csharp

//Opposites Attract
//8 kyu

//Timmy & Sarah think they are in love, but around where they live, they will only know once they pick a flower each.
//If one of the flowers has an even number of petals and the other has an odd number of petals it means they are in love.
//Write a function that will take the number of petals of each flower and return true if they are in love and false if they aren't.

using System;

namespace CodeWars
{
    public class OppositesAttract
    {
        public static bool lovefunc(int flower1, int flower2)
        {
            return (flower1 + flower2) % 2 == 1;
        }

        //public static bool lovefunc(int flower1, int flower2)
        //{
        //    return flower1 % 2 != flower2 % 2;
        //}


        //public static bool lovefunc(int flower1, int flower2)
        //{
        //    return Convert.ToBoolean((flower1 ^ flower2) & 1);
        //}

        //public static bool lovefunc(int flower1, int flower2)
        //{
        //    if ((flower1 % 2 == 0) ^ (flower2 % 2 == 0))
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}


        //public static bool lovefunc(int flower1, int flower2)
        //{
        //    return ((flower1 ^ flower2) & 1) == 1;
        //}


        //public static bool lovefunc(int flower1, int flower2)
        //{
        //    return flower1 % 2 == 1 ^ flower2 % 2 == 1;
        //}






    }
}