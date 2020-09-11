/*
https://www.codewars.com/kata/59df2f8f08c6cec835000012/csharp

6 kyu
Meeting

John has invited some friends. His list is:

s = "Fred:Corwill;Wilfred:Corwill;Barney:Tornbull;Betty:Tornbull;Bjon:Tornbull;Raphael:Corwill;Alfred:Corwill";
Could you make a program that

makes this string uppercase
gives it sorted in alphabetical order by last name.
When the last names are the same, sort them by first name. Last name and first name of a guest come in the result between parentheses separated by a comma.

So the result of function meeting(s) will be:

"(CORWILL, ALFRED)(CORWILL, FRED)(CORWILL, RAPHAEL)(CORWILL, WILFRED)(TORNBULL, BARNEY)(TORNBULL, BETTY)(TORNBULL, BJON)"
It can happen that in two distinct families with the same family name two people have the same first name too.

Notes
You can see another examples in the "Sample tests".
*/

using System;
using System.Linq;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic;

namespace CodeWars
{
    public class KataMeeting
    {
        public static string Meeting(string s)
        {
            //return string.Concat(s.ToUpper().Split(';').Select(x => x.Split(':')).Select(x => (x[1], x[0])).OrderBy(x => x).Select(x => $"({x.Item1}, {x.Item2})"));
            //return s.ToUpper().Split(";").Select(p => $"({string.Join(", ", p.Split(':').Reverse())})").OrderBy(p => p).Aggregate((acc, x) => $"{acc}{x}");
            //return s.ToUpper().Split(";").Select(x => x.Split(":")).Select(x => $"({x[1]}, {x[0]})").OrderBy(x => x).Aggregate((acc, x) => $"{acc}{x}");
            //return string.Concat(s.ToUpper().Split(';').Select(x => new Regex(@"^(.*):(.*)$").Replace(x, @"($2, $1)")).OrderBy(x => x));

            return string.Concat(s.ToUpper().Split(";").Select(x => $"({string.Join(", ", x.Split(':').Reverse())})")
                .OrderBy(f => f));
        }
    }
}