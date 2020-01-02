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
            var arr = new int[] {6, 9, 3, 4, 3, 82, 11};
            var target = 3;

            var indexes = arr.Select((a,i)=>(a,i)).Where(x=>x.a == target).Select(x=>x.i).ToArray();

            foreach(var index in indexes) Console.WriteLine(index);
        }
    }
}