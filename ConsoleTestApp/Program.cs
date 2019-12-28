using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text.RegularExpressions;
using CodeWars;

namespace ConsoleTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new int[] {-1, 4, 5, -23, 24};

            for (var i = a.Min(); i <= a.Max(); i++)
            {
                if (!a.Contains(i)) return;
            }
        }
    }
}