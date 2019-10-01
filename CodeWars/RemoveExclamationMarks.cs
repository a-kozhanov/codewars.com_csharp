

//https://www.codewars.com/kata/remove-exclamation-marks/train/csharp
//https://www.codewars.com/kata/57a0885cbb9944e24c00008e/solutions/csharp

//Remove exclamation marks
//8 kyu

//Write function RemoveExclamationMarks which removes all exclamation marks from a given string.

using System;

namespace CodeWars
{
    public static class KataRemoveExclamationMarks
    {
        public static string RemoveExclamationMarks(string s)
        {
            return s.Replace("!", "");
        }


        //public static string RemoveExclamationMarks(string s)
        //{
        //    return string.IsNullOrEmpty(s) ? s : s.Replace("!", "");
        //}



    }
}