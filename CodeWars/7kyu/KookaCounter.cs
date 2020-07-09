/*
https://www.codewars.com/kata/58e8cad9fd89ea0c6c000258/csharp

7 kyu
Kooka-Counter

A family of kookaburras are in my backyard.
I can't see them all, but I can hear them!
How many kookaburras are there?

Hint
The trick to counting kookaburras is to listen carefully
The males go HaHaHa...
The females go hahaha...
And they always alternate male/female

^ Kata Note : No validation is necessary; only valid input will be passed :-)
*/

using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class KataKookaCounter
    {
        public static int KookaCounter(string laughing)
        {
            //return laughing.Any() ? Regex.Matches(laughing.Replace("a", ""), "Hh|hH").Count + 1 : 0;
            return Regex.Matches(laughing, "(Ha)+|(ha)+").Count;
        }
    }
}