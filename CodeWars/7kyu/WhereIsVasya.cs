/*
https://www.codewars.com/kata/554754ac9d8ac3be120000b2/csharp

7 kyu
Where is Vasya?

Vasya stands in line with number of people p (including Vasya), 
but he doesn't know exactly which position he occupies. 
He can say that there are no less than b people standing in front of him and no more than a people standing behind him. 
Find the number of different positions Vasya can occupy.

Input
As an input you have 3 numbers:

1. Total amount of people in the line;

2. Number of people standing in front of him

3. Number of people standing behind him

Examples:
Line.WhereIsHe(3, 1, 1) // => 2  The possible positions are: 2 and 3

Line.WhereIsHe(5, 2, 3) // => 3  The possible positions are: 3, 4 and 5
*/

using System;

namespace CodeWars
{
    public class WhereIsVasya
    {
        public static int WhereIsHe(int p, int bef, int aft)
        {
            return p - bef > aft ? aft + 1 : p - bef;
            // return p - bef <= aft ? p - bef : aft + 1;
            // return p - Math.Max(bef + 1, p - aft) + 1;
            // return Math.Min(p - bef, aft + 1);
            // return Math.Min(Math.Max(p - bef, 0), aft + 1);
            // return bef + aft + 1 >= p ? p - bef : aft + 1;
            // return bef + aft >= p - 1 ? p - bef : aft;
            // return Math.Min(p - bef, aft + 1);
            // return p - Math.Max(bef, p - aft - 1);
        }
    }
}