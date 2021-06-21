/*
https://www.codewars.com/kata/567ed73340895395c100002e/csharp

7 kyu
Regexp Basics - is it a eight bit signed number?

Implement String.eight_bit_signed_number? (Ruby), String.eightBitSignedNumber() (Python), 
eight_bit_signed_number() (JS) or StringUtils.isSignedEightBitNumber(String) (Java) which should return true/True 
if given object is a number representable by 8 bit signed integer (-128 to -1 or 0 to 127), 
false/False otherwise.

It should only accept numbers in canonical representation, so no leading +, extra 0s, spaces etc.
*/

using System;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public static class RegexpBasicsIsItEightBitSignedNumber
    {
        public static bool SignedEightBitNumber(this string s)
        {
            // return Regex.IsMatch(s, @"^(0|(\-128)|(\-?((12[0-7])|(1[0-1][0-9])|([1-9][0-9]{0,1}))))\z");
            return Regex.IsMatch(s, @"^(-?([1-9][0-9]?|1[01][0-9]|12[0-7])|-128|0)(?!\n)$");
            // return Enumerable.Range(-128, 256).Any(i => i.ToString() == s);
        }
    }
}