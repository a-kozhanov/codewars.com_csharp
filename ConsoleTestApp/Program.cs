using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text.RegularExpressions;
using CodeWars;
using Microsoft.VisualBasic;

namespace ConsoleTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //HowManyUrinalsFree.GetFreeUrinals("10001");
            var input = "10001";

            if (input.Contains("11"))
            {
                Console.WriteLine("-1");
                //return -1
            }

            for (int i = 0; i < 100; i++)
            {
                var d = Convert.ToString(i, 2);
                var l = d.Length + 1;
                Console.WriteLine($"{i} = \t{d} / {i % l}");
            }
        }
    }
}