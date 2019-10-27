using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

//https://www.codewars.com/kata/5208f99aee097e6552000148/train/csharp
//

//Complete the solution so that the function will break up camel casing, using a space between words.

//Example
//Kata.BreakCamelCase("camelCasing") => "camel Casing"


namespace CodeWars
{
    public static class BreakCamelCase
    {
        public static string breakCamelCase(string str)
        {
            List<int> positionList = new List<int>();

            for (var i = 0; i < str.Length; i++)
            {
                if (char.IsUpper(str[i])) positionList.Add(positionList.Count == 0 ? i : i + 1);
            }

            foreach (var n in positionList) str = str.Insert(n, " ");

            return str;
            //return Regex.Replace(Regex.Replace(str, @"(\P{Ll})(\P{Ll}\p{Ll})", "$1 $2"), @"(\p{Ll})(\P{Ll})", "$1 $2");
        }
    }
}
