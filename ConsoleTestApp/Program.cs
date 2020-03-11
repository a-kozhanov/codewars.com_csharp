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
            var n = 15;

            List<int> result = new List<int>();
            //for (int i = 2; i <= Math.Sqrt(n); i++)
            for (var i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) Console.WriteLine(i);
                if (n % i == 0)
                {
                    // result.Add(i);
                    // result.Add(n / i);

                    result.Add(i);
                    if (i != n / i)
                        result.Add(n / i);
                }
            }

            result.ToArray();
        }
    }
}