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

            var s = "this is number: 7";
            Console.WriteLine(Convert.ToInt32(string.Concat(s.Where(x => char.IsDigit(x)))));

        }
    }
}
