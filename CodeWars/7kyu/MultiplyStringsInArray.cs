/*
https://www.codewars.com/kata/59b2963132779166d2001018/csharp

7 kyu
Multiply the strings in the array

You received an array with two strings. Create a function that will return their product as a string. E.g.

Kata.ArrMultiply(new string[] {"9", "6"}) => "54"
*/

using System.Linq;

namespace CodeWars
{
    public class MultiplyStringsInArray
    {
        public static string ArrMultiply(string[] arr)
        {
            //return $"{int.Parse(arr[0]) * int.Parse(arr[1])}";

            return arr.Aggregate((a, b) => $"{int.Parse(a) * int.Parse(b)}");
        }
    }
}