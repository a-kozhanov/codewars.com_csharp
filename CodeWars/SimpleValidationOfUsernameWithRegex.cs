/*
https://www.codewars.com/kata/simple-validation-of-a-username-with-regex/train/csharp
https://www.codewars.com/kata/56a3f08aa9a6cc9b75000023/solutions/csharp

8 kyu
Simple validation of a username with regex

Write a simple regex to validate a username. Allowed characters are:

lowercase letters,
numbers,
underscore
Length should be between 4 and 16 characters (both included).

*/

using System;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class SimpleValidationOfUsernameWithRegex
    {
        public static bool ValidateUsr(string username)
        {
            return new Regex("^[a-z0-9_]{4,16}$").Match(username).Success;
        }


        //public static bool ValidateUsr(string username)
        //{
        //    return Regex.IsMatch(username, "^[a-z0-9_]{4,16}$");
        //}


        //public static bool ValidateUsr(string username)
        //{
        //    return Regex.IsMatch(username, @"\A[a-z0-9_]{4,16}\z");
        //}


        //public static bool ValidateUsr(string username)
        //{
        //    return Regex.IsMatch(username, @"^[a-z0-9_]{4,16}$");
        //}

        //public static bool ValidateUsr(string Username) => System.Text.RegularExpressions.Regex.IsMatch(Username, "^[a-z0-9_]{4,16}$");

        //public static bool ValidateUsr(string username)
        //{
        //    return Regex.Matches(username, @"^[\da-z_]{4,16}$").Count > 0;
        //}

    }
}