/*
https://www.codewars.com/kata/5768a693a3205e1cc100071f/csharp

7 kyu
Initialize my name

Some people just have a first name; some people have first and last names and some people have first, middle and last names.

You task is to initialize the middle names (if there is any).

Examples
'Jack Ryan'                   => 'Jack Ryan'
'Lois Mary Lane'              => 'Lois M. Lane'
'Dimitri'                     => 'Dimitri'
'Alice Betty Catherine Davis' => 'Alice B. C. Davis'
*/

using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class InitializeMyName
    {
        public static string InitializeNames(string name)
        {
            // var parts = name.Split();
            // return string.Join(" ", parts.Select((x, i) => i != 0 && i != parts.Length - 1 ? x[0] + "." : x));

            return name.Split().Skip(1).SkipLast(1).Aggregate(name, (s, n) => s.Replace(n, n[0] + "."));
            //return new Regex(@" (\w)\w+(?= )").Replace(name, m => $" {m.Groups[1].Value}.");
            //return Regex.Replace(name, @"(?<!^)\b([A-Z])\w*\b(?!$)", "$1.");
        }
    }
}