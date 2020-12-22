/*
https://www.codewars.com/kata/57ed30dde7728215300005fa/csharp

7 kyu
Bumps in the Road

Your car is old, it breaks easily. 
The shock absorbers are gone and you think it can handle about 15 more bumps before it dies totally.

Unfortunately for you, your drive is very bumpy! 
Given a string showing either flat road ("_") or bumps ("n"), work out if you make it home safely. 15 bumps or under, 
return "Woohoo!", over 15 bumps return "Car Dead".
*/

using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class BumpsInRoad
    {
        public static string Bump(string input)
        {
            //return input.Length - input.Replace("n", "").Length > 15 ? "Car Dead" : "Woohoo!";
            //return input.Where(c => c == 'n').Count() > 15 ? "Car Dead" : "Woohoo!";
            //return Regex.Matches(input, "n").Count > 15 ? "Car Dead" : "Woohoo!";
            //return input.Replace("_", "").Length > 15 ? "Car Dead" : "Woohoo!";
            //return input.Count(c => c == 'n') <= 15 ? "Woohoo!" : "Car Dead";
            //return input.Split('n').Length - 1 > 15 ? "Car Dead" : "Woohoo!";
            //return input.Count(x => x == 'n') > 15 ? "Car Dead" : "Woohoo!";
            //return input.Count(char.IsLetter) > 15 ? "Car Dead" : "Woohoo!";
            return input.Trim('_').Length > 15 ? "Car Dead" : "Woohoo!";
        }
    }
}