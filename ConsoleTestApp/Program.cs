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
            var n = 7;
            BigInteger sum = 1;

            for (var i = 1; i <= n; i++)
            {
                sum = sum * (n + i) / i;
            }

            Console.WriteLine(sum);
        }
    }
}