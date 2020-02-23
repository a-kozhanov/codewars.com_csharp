/*
https://www.codewars.com/kata/5b180e9fedaa564a7000009a/train/csharp
https://www.codewars.com/kata/5b180e9fedaa564a7000009a/solutions/csharp

7 kyu
Fix string case

In this Kata, you will be given a string that may have mixed uppercase and lowercase letters and your task is to convert that string to either lowercase only or uppercase only based on:

make as few changes as possible.
if the string contains equal number of uppercase and lowercase letters, convert the string to lowercase.

For example:
solve("coDe") = "code". Lowercase characters > uppercase. Change only the "D" to lowercase.
solve("CODe") = "CODE". Uppercase characters > lowecase. Change only the "e" to uppercase.
solve("coDE") = "code". Upper == lowercase. Change all to lowercase.

More examples in test cases. Good luck!
*/

using System.Linq;

namespace CodeWars
{
    public class FixStringCase
    {
        public static string Solve(string s)
        {
            //return s.Count(char.IsLower) < s.Count(char.IsUpper) ? s.ToUpper() : s.ToLower();
            return s.Count(char.IsLower) < s.Length / 2 ? s.ToUpper() : s.ToLower();
        }

        // public static string Solve(string s)
        // {
        //     return s.Count(char.IsUpper) > s.Count(char.IsLower) ? s.ToUpper() : s.ToLower();
        // }

        // public static string Solve(string s)
        // {
        //     return s.Count(x => char.IsUpper(x)) > (s.Length / 2) ? s.ToUpper() : s.ToLower();
        // }

        // public static string Solve(string s)
        // {
        //     if (s.ToArray().Count(l => l >= 65 && l < 91) <= s.Length / 2)
        //     {
        //         return s.ToLower();
        //     }
        //
        //     return s.ToUpper();
        // }


        // public static string Solve(string s)
        //     => s.Count(char.IsUpper) > s.Count(char.IsLower) ? s.ToUpper() : s.ToLower();

        // public static string Solve(string s) => s.ToArray().Where(c => char.IsLower(c)).Count() >= s.Length / 2
        //     ? s.ToLower()
        //     : s.ToUpper();

        // public static string Solve(string s) => s.Count(ch => Char.IsUpper(ch)) > s.Count(ch => Char.IsLower(ch))
        //     ? s.ToUpper()
        //     : s.ToLower();

        // public static string Solve(string s) =>
        //     s.Count(char.IsUpper) > s.Length - s.Count(char.IsUpper) ? s.ToUpper() : s.ToLower();


        // public static string Solve(string s)
        // {
        //     return s.Where(o => char.IsLower(o)).Count() < s.Length / 2 ? s.ToUpper() : s.ToLower();
        // }

        // public static string Solve(string s) =>
        //     s.Count(c => char.IsUpper(c)) <= s.Length / 2 ? s.ToLower() : s.ToUpper();


        // public static string Solve(string s) =>
        //     s.Count(c => char.IsUpper(c)) > s.Length / 2 ? s.ToUpper() : s.ToLower();
    }
}