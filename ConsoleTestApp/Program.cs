using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using CodeWars;
using Microsoft.VisualBasic;

namespace ConsoleTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = "ZpglnRxqenU";
            var r = string.Join("-", Enumerable.Range(0, s.Length).Select(x => string.Concat(Enumerable.Repeat(s.ToLower()[x], x + 1))));

            Console.WriteLine(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(r));

            //CultureInfo.CurrentCulture.TextInfo.ToTitleCase(s);

        }
    }
}