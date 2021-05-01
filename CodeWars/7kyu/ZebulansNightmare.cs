/*
https://www.codewars.com/kata/570fd7ad34e6130455001835/csharp

7 kyu
Zebulan's Nightmare

Zebulan has worked hard to write all his python code in strict compliance to PEP8 rules. 
In this kata, you are a mischievous hacker that has set out to sabotage all his good code.

Your job is to take PEP8 compatible function names and convert them to camelCase. For example:

zebulansNightmare('camel_case') == 'camelCase'
zebulansNightmare('zebulans_nightmare') == 'zebulansNightmare'
zebulansNightmare('get_string') == 'getString'
zebulansNightmare('convert_to_uppercase') == 'convertToUppercase'
zebulansNightmare('main') == 'main'
*/

using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class KataZebulansNightmare
    {
        public static string ZebulansNightmare(string functionName)
        {
            return Regex.Replace(functionName, "_.", m => $"{char.ToUpper(m.Value[1])}");
            // return Regex.Replace(functionName, "_.", m => "" + char.ToUpper(m.Value[1]));
            // return Regex.Replace(functionName, @"_\w", m => (m.Value[1] + "").ToUpper());_(\\w)
            // return Regex.Replace(functionName, "_(\\w)", m => m.ToString().ToUpper()[1..]);
            // return Regex.Replace(functionName, "_(\\w)", m => m.ToString().ToUpper().Substring(1));
            // return Regex.Replace(functionName, @"_[a-z]", m => m.ToString().TrimStart('_').ToUpper());
            // return string.Concat(functionName.Split('_').Select((x, i) => i > 0 ? char.ToUpper(x[0]) + x[1..] : x));
            // return string.Concat(functionName.Split('_').Select((x, i) => i == 0 ? x : char.ToUpper(x[0]) + x.Substring(1)));
            // return string.Concat(functionName.ToLower().Split('_').Select((s, i) => i == 0 ? s : char.ToUpper(s[0]) + s.Substring(1)));
        }
    }
}