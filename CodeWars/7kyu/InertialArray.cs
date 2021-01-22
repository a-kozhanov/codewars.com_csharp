/*
https://www.codewars.com/kata/59a151c53f64cdd94c00008f/csharp

7 kyu
Inertial Array

An array is defined to be inertialif the following conditions hold:

a. it contains at least one odd value  
b. the maximum value in the array is even 
c. every odd value is greater than every even value that is not the maximum value.
eg:-

So [11, 4, 20, 9, 2, 8] is inertial because 
a. it contains at least one odd value [11,9] 
b. the maximum value in the array is 20 which is even 
c. the two odd values (11 and 9) are greater than all the even values that are not equal to 20 (the maximum), i.e., [4, 2, 8]
Write a function called is_inertial that accepts an integer array and returns true if the array is inertial; otherwise it returns false.
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class InertialArray
    {
        public static Boolean IsInertial(Int32[] arr)
        {
            return arr.Max() % 2 == 0 && arr.Any(x => x % 2 != 0) && !arr.Where(i => i % 2 != 0)
                .Any(x => arr.Where(i => i % 2 == 0).Any(i => i != arr.Max() && i > x));
        }
    }
}