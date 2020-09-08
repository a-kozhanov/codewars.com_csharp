/*
https://www.codewars.com/kata/5842df8ccbd22792a4000245/csharp

6 kyu
Write Number in Expanded Form

You will be given a number and you will need to return it as a string in Expanded Form. For example:

Kata.ExpandedForm(12); # Should return "10 + 2"
Kata.ExpandedForm(42); # Should return "40 + 2"
Kata.ExpandedForm(70304); # Should return "70000 + 300 + 4"
NOTE: All numbers will be whole numbers greater than 0.

If you liked this kata, check out part 2!!
*/

using System.Linq;
using Microsoft.VisualBasic;

namespace CodeWars
{
    public class WriteNumberInExpandedForm
    {
        public static string ExpandedForm(long num)
        {
            return string.Join(" + ",
                $"{num}".Select((c, i) => c + new string('0', $"{num}".Length - i - 1)).Where(x => x[0] != '0'));

            //return string.Join(" + ", $"{num}".Select((c, i) => $"{c}".PadRight($"{num}".Length - i - 1, '0')).Where(x => x[0] != '0'));
        }
    }
}