using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.RegularExpressions;
using CodeWars;
using Microsoft.VisualBasic;

namespace ConsoleTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //kwfrmhr -> qljr
            //
            //kwfrmhr
            // Expected: "qljr"
            // But was:  "qqqr"

            var s = "kwfrmhr";
            var r = (char)((s[0] + s[1]) / 2);

            Console.WriteLine($"s[0]: {s[0]} - {(int)s[0]}");
            Console.WriteLine($"s[1]: {s[1]} - {(int)s[1]}");
            Console.WriteLine($"SUM / 2: {r} - {(int)r}");

            var r1 = Regex.Replace(s, "..", r.ToString());

            Console.WriteLine($"{(char)((s[0] + s[1]) / 2)}");
            Console.WriteLine(Regex.Replace(s, "..", $"{(char)((s.FirstOrDefault() + s.Skip(1).FirstOrDefault()) / 2)}"));


            // Console.WriteLine(
            //     Regex.Replace(s, "..", match => ((char)((match.ToString().FirstOrDefault() + match.ToString().Skip(1).FirstOrDefault()) / 2)).ToString())
            //     );


            // Console.WriteLine(
            //     Regex.Replace(s, "..", m => ((char)((m.Value[0] + m.Value[1]) / 2)).ToString())
            // );

            Console.WriteLine(
                Regex.Replace(s, "..", m => $"{(char)((m.Value[0] + m.Value[1]) / 2)}")
            );

        }
    }
}