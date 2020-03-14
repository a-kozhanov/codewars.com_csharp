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
            var number = new int[] {8, 900, 500};
            var n = number.Select((x, i) => new { Value = x, Index = i, len = x.ToString().Length });

            var tt = n.Where(x => n.Max(m => m.len) == x.len).Select(x=>x.Value).First();

            Console.WriteLine(tt);
        }
    }
}