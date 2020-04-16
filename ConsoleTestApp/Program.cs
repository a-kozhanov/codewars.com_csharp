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
            // var arr = new List<int> {1, -1, 2, -2, 3};
            var arr = new List<int> {-3, 1, 2, 3, -1, -4, -2};

            foreach (var arrayNumber in arr)
            {
                if (!arr.Contains(arrayNumber * (-1)))
                {
                    Console.WriteLine(arrayNumber);
                }
            }
        }
    }
}