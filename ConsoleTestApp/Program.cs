using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text.RegularExpressions;
using CodeWars;

namespace ConsoleTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HexToDecimal.HexToDec("1"));
            Console.WriteLine(HexToDecimal.HexToDec("a"));
            Console.WriteLine(HexToDecimal.HexToDec("10"));
            Console.WriteLine(HexToDecimal.HexToDec("FF"));
            Console.WriteLine(HexToDecimal.HexToDec("C"));
        }
    }
}
