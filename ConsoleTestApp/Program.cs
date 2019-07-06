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
            Console.WriteLine(string.Join(", ", ReverseListOrder.ReverseList(new List<int> { 1, 2, 3, 4 })));
        }
    }
}
