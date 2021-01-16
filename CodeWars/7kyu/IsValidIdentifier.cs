/*
https://www.codewars.com/kata/563a8656d52a79f06c00001f/csharp

7 kyu
Is valid identifier?

Given a string, determine if it's a valid identifier.

Here is the syntax for valid identifiers:
Each identifier must have at least one character.
The first character must be picked from: alpha, underscore, or dollar sign. The first character cannot be a digit.
The rest of the characters (besides the first) can be from: alpha, digit, underscore, or dollar sign. In other words, it can be any valid identifier character.
Examples of valid identifiers:
i
wo_rd
b2h
Examples of invalid identifiers:
1i
wo rd
!b2h
*/

using System.Text.RegularExpressions;

namespace CodeWars
{
    public class IsValidIdentifier
    {
        public static bool IsValid(string idn)
        {
            return Regex.IsMatch(idn, "(?i)^[$_a-z]+[$\\w]*$");
            // return Regex.IsMatch(idn, "^[$_a-zA-Z]+[$\\w]*$");
            // return new Regex(@"^[a-z_\$][a-zA-Z0-9_\$]*$").Match(idn).Success;
            // return new Regex("^([a-zA-Z_$]+[0-9]*)+$").IsMatch(idn);
            // return Regex.Match(idn, @"^[a-zA-Z_$][\w]*$").Success;
            // return new Regex(@"^[a-z_$][a-z\d_$]*$", RegexOptions.IgnoreCase).IsMatch(idn);
            // return Regex.IsMatch(idn, "^[a-zA-Z_$]{1}[a-zA-Z_$\\d]*$");
            // return Regex.IsMatch(idn, @"^[A-Za-z_$]{1}[A-Za-z\d_$]+$");
            // return Regex.IsMatch(idn, @"^[_$a-zA-Z][0-9a-zA-Z_$]{0,}$");
        }
    }
}