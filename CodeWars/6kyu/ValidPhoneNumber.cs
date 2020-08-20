/*
https://www.codewars.com/kata/525f47c79f2f25a4db000025/csharp

6 kyu
Valid Phone Number

Write a function that accepts a string, and returns true if it is in the form of a phone number.
Assume that any integer from 0-9 in any of the spots will produce a valid phone number.

Only worry about the following format:
(123) 456-7890 (don't forget the space after the close parentheses)

Examples:
validPhoneNumber("(123) 456-7890")  =>  returns true
validPhoneNumber("(1111)555 2345")  => returns false
validPhoneNumber("(098) 123 4567")  => returns false
*/

using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class KataValidPhoneNumber
    {
        public static bool ValidPhoneNumber(string phoneNumber)
        {
            //return "(000) 000-0000" == string.Concat(phoneNumber.Select(x => char.IsDigit(x) ? '0' : x));
            //return Regex.Match(phoneNumber, @"^\((\d{3})\)\s\d{3}[-]\d{4}$").Success;
            //return Regex.Replace(phoneNumber, @"\d", "#").Equals(@"(###) ###-####");
            //return new Regex(@"^\(\d{3}\) \d{3}-\d{4}$").IsMatch(phoneNumber);
            //return Regex.IsMatch(phoneNumber, @"^\(\d{3}\) \d{3}-\d{4}\z");
            return Regex.IsMatch(phoneNumber, @"^\(\d{3}\) \d{3}-\d{4}$");
        }
    }
}