/*
https://www.codewars.com/kata/55ee3ebff71e82a30000006a/csharp

7 kyu
Excel sheet column numbers

Write a function

titleToNumber(title) or title_to_number(title) or titleToNb title ...

(depending on the language)

that given a column title as it appears in an Excel sheet, returns its corresponding column number. All column titles will be uppercase.

Examples:
titleTonumber('A') === 1
titleTonumber('Z') === 26
titleTonumber('AA') === 27
Note for Clojure:
Don't use Java Math/pow (even with bigint) because there is a loss of precision 
when the length of "title" is growing. 
Write your own function "exp [x n]".
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class ExcelSheetColumnNumbers
    {
        public static long TitleToNumber(string title)
        {
            return title.Aggregate<char, long>(0, (l, c) => l * 26 + c - 64);
            //return title.Aggregate<char, long>(0, (l, c) => l * 26 + c - 'A' + 1);
            //return (long) title.Reverse().Select((c, i) => (c - 64) * Math.Pow(26, i)).Sum();
            //return title.Aggregate((long) 0, (column, letter) => 26 * column + letter - 'A' + 1);
            //return (long) title.ToUpper().Reverse().Select((c, i) => (c - 'A' + 1) * Math.Pow(26, i)).Sum();
            //return title.Select((x, i) => (long) (((int) x - 64) * Math.Pow(26, title.Length - 1 - i))).ToArray().Sum();
        }
    }
}