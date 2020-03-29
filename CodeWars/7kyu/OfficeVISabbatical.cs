/*
https://www.codewars.com/kata/57fe50d000d05166720000b1/train/csharp
https://www.codewars.com/kata/57fe50d000d05166720000b1/solutions/csharp

7 kyu
The Office VI - Sabbatical

Learning to code around your full time job is taking over your life. 
You realise that in order to make significant steps quickly, it would help to go to a coding bootcamp in London.

Problem is, many of them cost a fortune, and those that don't still involve a significant amount of time off work - who will pay your mortgage?!

To offset this risk, you decide that rather than leaving work totally, 
you will request a sabbatical so that you can go back to work post bootcamp and be paid while you look for your next role.

You need to approach your boss. Her decision will be based on three parameters:

val=your value to the organisation
happ=her happiness level at the time of asking and finally
The numbers of letters from 'sabbatical' that are present in string 'x'.

Note that if x contains three instances of the letter 'l', 
that still scores three points, even though there is only one in the word sabbatical.

If the sum of the three parameters (as described above) is > 22, 
return 'Sabbatical! Boom!', else return 'Back to your desk, boy.'.
*/

using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class OfficeVISabbatical
    {
        public static string Sabb(string x, int val, int happ)
        {
            // return x.ToLower().Count(c => "sabticl".IndexOf(c) >= 0) + val + happ > 22
            //     ? "Sabbatical! Boom!"
            //     : "Back to your desk, boy.";           

            // return x.Count(c => "SABTICLsabticl".IndexOf(c) >= 0) + val + happ > 22
            //     ? "Sabbatical! Boom!"
            //     : "Back to your desk, boy.";

            // return Regex.Matches(x, "(?i)[sabticl]").Count + val + happ > 22
            //     ? "Sabbatical! Boom!"
            //     : "Back to your desk, boy.";

            // return x.ToLower().Count("sabticl".Contains) + val + happ > 22
            //     ? "Sabbatical! Boom!"
            //     : "Back to your desk, boy.";

            return x.Count("SABTICLsabticl".Contains) + val + happ > 22
                ? "Sabbatical! Boom!"
                : "Back to your desk, boy.";
        }


        // public static string Sabb(string x, int val, int happ)
        //     => new Regex(@"[^sabbatical]", RegexOptions.IgnoreCase).Replace(x, "").Length + val + happ > 22
        //         ? "Sabbatical! Boom!"
        //         : "Back to your desk, boy.";


        // public static string Sabb(string x, int val, int happ)
        // {
        //     return (val + happ + (x.Select(item => item.ToString().ToLower())
        //         .Where(item => "Sabbatical".ToLower().Contains(item))
        //         .ToArray()
        //         .Length)) > 22
        //         ? "Sabbatical! Boom!"
        //         : "Back to your desk, boy.";
        // }


        // public static string Sabb(string x, int val, int happ)
        // {
        //     var letters = new HashSet<char>("sabbatical");
        //     var s = val + happ + x.Count(c => letters.Contains(char.ToLower(c)));
        //     if (s > 22)
        //     {
        //         return "Sabbatical! Boom!";
        //     }
        //
        //     return "Back to your desk, boy.";
        // }


        // public static string Sabb(string x, int val, int happ)
        // {
        //     int letters = 0;
        //     letters = x.Count(letter => "sabticl".Contains(Char.ToLower(letter)));
        //
        //     return val + happ + letters > 22 ? "Sabbatical! Boom!" : "Back to your desk, boy.";
        // }


        // public static string Sabb(string x, int val, int happ)
        // {
        //     var s = "sbaticl";
        //     var r = val + happ;
        //     foreach (var c in s)
        //         r += x.ToLower().Count(a => a == c);
        //     return r > 22 ? "Sabbatical! Boom!" : "Back to your desk, boy.";
        // }


        // public static string Sabb(string message, int value, int happiness)
        // {
        //     int count = message.Count(x => "sabbatical".Any(y => char.ToLower(x) == y));
        //     int sum = count + value + happiness;
        //
        //     return sum > 22 ? "Sabbatical! Boom!" : "Back to your desk, boy.";
        // }
    }
}