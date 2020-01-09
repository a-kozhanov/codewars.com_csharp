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
            long n = 2220315241;
            var result = new List<long> {n};
            for (var i = 0; i < n.ToString().Length; i++)
            {
                var rotateDigit = n.ToString()[i];
                var removeDigit = n.ToString().Remove(i, 1);
                n = long.Parse(removeDigit + rotateDigit);
                result.Add(n);
            }

            Console.WriteLine(string.Join(", ", result));
            Console.WriteLine(result.Max());
        }
    }
}
// Expected: 2220315241
// But was:  2203152412

// testing(RotateForMax.MaxRot(38458215), 85821534);
// testing(RotateForMax.MaxRot(195881031), 988103115);
// testing(RotateForMax.MaxRot(896219342), 962193428);
// testing(RotateForMax.MaxRot(69418307), 94183076);