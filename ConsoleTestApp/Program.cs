using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Numerics;
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
            var start = 1;
            var end = 90;
            var count = 0;

            for (var i = start; i <= end; i++)
            {
                if (!i.ToString().Contains("5")) count++;
            }

            Console.WriteLine(count);
        }
    }
}