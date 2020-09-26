/*
https://www.codewars.com/kata/59c01248bf10a47bd1000046/csharp

6 kyu
Validate my Password

I will give you a string. You respond with "VALID" if the string meets the requirements or "INVALID" if it does not.

Passwords must abide by the following requirements:
More than 3 characters but less than 20.
Must contain only alphanumeric characters.
Must contain letters and numbers.
*/

using System.Text.RegularExpressions;

namespace CodeWars
{
    public class ValidateMyPassword
    {
        public static string validator(string password)
        {
            //^(?=.*\d)(?=.*[a-zA-Z])(\w{4,20})$
            //^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(\w{4,20})$
            return Regex.IsMatch(password, @"^(?=.*\d)(?=.*[a-zA-Z])(\w{4,20})$") ? "VALID" : "INVALID";

            // return Regex.Match(password, @"^(?=.*\d)(?=.*[a-zA-Z])(\w{4,20})$").Success
            //     ? "VALID"
            //     : "INVALID";
        }
    }
}