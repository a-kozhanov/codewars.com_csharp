//https://www.codewars.com/kata/regex-validate-pin-code/train/csharp
//https://www.codewars.com/kata/regex-validate-pin-code/solutions/csharp

//Regex validate PIN code

//ATM machines allow 4 or 6 digit PIN codes and PIN codes cannot contain anything but exactly 4 digits or exactly 6 digits.
//If the function is passed a valid PIN string, return true, else return false.
//eg:
//ValidatePin("1234") => true
//ValidatePin("12345") => false
//ValidatePin("a234") => false

using System;
using System.Linq;
using System.Security.Principal;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class RegexValidatePIN
    {
        public static bool ValidatePin(string pin)
        {
            if (!(pin.Length == 4 || pin.Length == 6)) return false;

            foreach (var c in pin)
                if (!char.IsDigit(c))
                    return false;

            return true;
        }

        //Best Practices
        //public static bool ValidatePin(string pin)
        //{
        //    return pin.All(n => Char.IsDigit(n)) && (pin.Length == 4 || pin.Length == 6);
        //}

        //public static bool ValidatePin(string pin)
        //{
        //    return Regex.IsMatch(pin, @"^(\d{6}|\d{4})\z");
        //}

    }
}