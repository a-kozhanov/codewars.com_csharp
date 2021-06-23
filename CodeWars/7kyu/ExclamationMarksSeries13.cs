/*
https://www.codewars.com/kata/57fb142297e0860073000064/csharp

7 kyu
Exclamation marks series #13: Count the number of exclamation marks and question marks, return the product

Description:
Count the number of exclamation marks and question marks, return the product.

Examples
Product("") == 0
product("!") == 0
Product("!ab? ?") == 2
Product("!!") == 0
Product("!??") == 2
Product("!???") == 3
Product("!!!??") == 6
Product("!!!???") == 9
Product("!???!!") == 9
Product("!????!!!?") == 20
*/

using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class ExclamationMarksSeries13
    {
        public static int Product(string str)
        {
            // return (str.Length - str.Replace("!", "").Length) * (str.Length - str.Replace("?", "").Length);
            return str.Count(c => c == '!') * str.Count(c => c == '?');
            // return Regex.Matches(str,"!").Count * Regex.Matches(str,@"\?").Count;
        }
    }
}