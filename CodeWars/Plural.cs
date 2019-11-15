/*
https://www.codewars.com/kata/plural/train/csharp
https://www.codewars.com/kata/52ceafd1f235ce81aa00073a/solutions/csharp

8 kyu
Plural

We need a simple function that determines if a plural is needed or not. 
It should take a number, and return true if a plural should be used with that number or false if not. 
This would be useful when printing out a string such as 5 minutes, 14 apples, or 1 sun.

You only need to worry about english grammar rules for this kata, where anything that isn't singular (one of something), it is plural (not one of something).

All values will be positive integers or floats, or zero.
*/

using System;

namespace CodeWars
{
    public class KataPlural
    {
        public static bool Plural(double n)
        {
            return n != 1;
        }

        //public static bool Plural(double n) => (n != 1);

        //public static bool Plural(double n)
        //{
        //    return n != 1 ? true : false;
        //}

        //public static bool Plural(double n)
        //{
        //    return Math.Abs(n - 1) > double.Epsilon;
        //}

        //public static bool Plural(double n)
        //{
        //    return n == 1.0 ? false : true;
        //}

        //public static bool Plural(double n) => Math.Abs(n - 1) > double.Epsilon;

    }
}