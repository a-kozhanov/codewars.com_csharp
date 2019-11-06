using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using CodeWars;

namespace ConsoleTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Expected: "$3209.88"
            //But was:  "$3,209.88"


            NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;
            //nfi.CurrencyPositivePattern = 0;
            nfi.CurrencyDecimalSeparator = ".";
            nfi.CurrencyGroupSeparator = ".";

            double amount = 3209.88;
            //Console.WriteLine(amount.ToString("C2", new CultureInfo("en-US")));
            //Console.WriteLine(amount.ToString("C2", CultureInfo.CreateSpecificCulture("en-US")));
            //Console.WriteLine(string.Format(nfi, "{0:C}", amount));
            Console.WriteLine(string.Format(new NumberFormatInfo { CurrencyGroupSeparator = "" }, "{0:C}", amount));

        }
    }
}
