/*
https://www.codewars.com/kata/56833b76371e86f8b6000015/train/csharp

7 kyu
Regexp basics - parsing prices

Implement String#to_cents, which should parse prices expressed as $1.23 and return number of cents, or in case of bad format return nil.
*/

using System;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public static class RegexpBasicsParsingPrices
    {
        public static int? ToCents(this string price)
        {
            var s = Regex.Replace(Regex.Match(price, @"^\$\d{1,}\.\d{2}\z").Value, @"(\.|\$)", "");
            return s.Any() ? int.Parse(s) : (int?) null;
        }
    }
}