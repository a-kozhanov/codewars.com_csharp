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
            var s = "1234567898765";

            // int seqLen = 5;
            // var result = 0;
            //
            // for (var i = 0; i <= str.Length - seqLen; i++)
            // {
            //     var seq = int.Parse(str.Substring(i, 5));
            //     if (result < seq) result = seq;
            // }

            //var result =  s.Select((x, i) => i).Select(i => i <= s.Length - 5 ? int.Parse(s.Substring(i, 5)) : 0).Max();
            //var result = Enumerable.Range(0, s.Length - 4).Max(i => s.Substring(i, 5));
            var result = int.Parse(Enumerable.Range(0, s.Length - 4).Max(i => s.Substring(i, 5)));

            Console.WriteLine(result);
        }
    }
}