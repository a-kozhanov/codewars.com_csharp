/*
https://www.codewars.com/kata/57f759bb664021a30300007d/train/csharp

7 kyu
Switcheroo

Given a string made up of letters a, b, and/or c, 
switch the position of letters a and b (change a to b and vice versa). 
Leave any incidence of c untouched.

Example:
'acb' --> 'bca'
'aabacbaa' --> 'bbabcabb'
*/

using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class KataSwitcheroo
    {
        public static string Switcheroo(string x)
        {
            //return string.Concat(x.Select(c => c == 'a' ? 'b' : c == 'b' ? 'a' : 'c'));
            //return Regex.Replace(x, "[ab]", m => m.Value == "a" ? "b" : "a");
            return x.Replace('a', 'x').Replace('b', 'a').Replace('x', 'b');
        }
    }
}