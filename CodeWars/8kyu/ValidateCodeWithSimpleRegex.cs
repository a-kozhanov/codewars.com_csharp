/*
https://www.codewars.com/kata/validate-code-with-simple-regex/train/csharp
https://www.codewars.com/kata/56a25ba95df27b7743000016/solutions/csharp

8 kyu
validate code with simple regex

Basic regex tasks. Write a function that takes in a numeric code of any length. 
The function should check if the code begins with 1, 2, or 3 and return true if so. Return false otherwise.

You can assume the input will always be a number.
*/


using System.Text.RegularExpressions;

namespace CodeWars
{
    public class ValidateCodeWithSimpleRegex
    {
        public static bool ValidateCode(string code)
        {
            return Regex.IsMatch(code, "^[1-3]");
        }

        //public static bool ValidateCode(string code) => Regex.IsMatch(code, "^[1-3]");

    }
}