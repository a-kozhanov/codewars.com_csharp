using System;
using System.Collections.Generic;
using System.Text;

//https://www.codewars.com/kata/remove-first-and-last-character/train/csharp
//https://www.codewars.com/kata/56bc28ad5bdaeb48760009b0/solutions/csharp

//Remove First and Last Character
//It's pretty straightforward. Your goal is to create a function that removes the first and last characters of a string.
//You're given one parameter, the original string. You don't have to worry with strings with less than two characters.

namespace CodeWars
{
    public class RemoveFirstLastCharacter
    {
        public static string Remove_char(string s)
        {
            //return s.Remove(s.Length - 1, 1).Remove(0, 1);
            return s[1..^1];
        }

        //Best Practices
        //public static string Remove_char(string s)
        //{
        //    return s.Substring(1, (s.Length - 2));
        //}
    }
}