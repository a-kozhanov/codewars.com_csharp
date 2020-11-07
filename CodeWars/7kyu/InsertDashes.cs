/*
https://www.codewars.com/kata/55960bbb182094bc4800007b/csharp

7 kyu
Insert dashes

Write a function insertDash(num)/InsertDash(int num) that will insert dashes ('-') between each two odd numbers in num. 
For example: if num is 454793 the output should be 4547-9-3. Don't count zero as an odd number.

Note that the number will always be non-negative (>= 0).
*/

using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class InsertDashes
    {
        public static string InsertDash(int num)
        {
            return Regex.Replace($"{num}", "([1,3,5,7,9])(?=[1,3,5,7,9])", "$1-");

            //return Regex.Replace(num.ToString(), "[13579](?=[13579])", x => x.Value + "-");

            // return num.ToString().Aggregate("0",
            //     (a, b) => int.Parse(b.ToString()) % 2 == 1 && int.Parse(a[^1].ToString()) % 2 == 1
            //         ? a + "-" + b
            //         : a + b)[1..];
        }
    }
}