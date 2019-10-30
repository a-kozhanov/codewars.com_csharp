/*
https://www.codewars.com/kata/557af9418895e44de7000053
https://www.codewars.com/kata/557af9418895e44de7000053/solutions/csharp

8 kyu
repeatIt

Create a function that takes a string and an integer (n).

The function should return a string that repeats the input string n number of times.

If anything other than a string is passed in you should return "Not a string"

Example
"Hi", 2 --> "HiHi"
1234, 5 --> "Not a string"
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class RepeatIt
    {
        public static string RepeatString(object toRepeat, int n)
        {
            return toRepeat == null || toRepeat.GetType() != typeof(string)
                ? "Not a string"
                : string.Concat(Enumerable.Repeat(toRepeat.ToString(), n));
        }


        //public static string RepeatString(object toRepeat, int n)
        //{
        //    return toRepeat is string? String.Join("", Enumerable.Repeat(toRepeat.ToString(), n)): "Not a string";
        //}


        //public static string RepeatString(object toRepeat, int n)
        //{
        //    if (!(toRepeat is string str))
        //    {
        //        return "Not a string";
        //    }

        //    return string.Concat(Enumerable.Repeat(toRepeat, n));
        //}


        //public static string RepeatString(object toRepeat, int n) 
        //    => toRepeat is string ? string.Concat(Enumerable.Repeat(toRepeat, n)): "Not a string";


        //public static string RepeatString(object toRepeat, int n)
        //{
        //    if(toRepeat is string)
        //        return string.Join("", Enumerable.Repeat(toRepeat, n));
        //    else
        //        return "Not a string";
        //}


        //public static string RepeatString(object toRepeat, int n)
        //{
        //    return (toRepeat is string) ? string.Join("", Enumerable.Repeat(toRepeat, n)) : "Not a string";
        //}


        //public static string RepeatString(object toRepeat, int n)
        //{       
        //    return toRepeat is string s ? string.Concat(Enumerable.Repeat(toRepeat, n)) : "Not a string";
        //}



    }
}