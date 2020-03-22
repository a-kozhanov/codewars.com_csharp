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
            //Assert.AreEqual("Sabbatical! Boom!", OfficeVISabbatical.Sabb("Can I have a sabbatical?", 5, 5));
            
            string x = "Can I have a sabbatical?";
            int val = 5;
            int happ = 5;

            var r = Regex.Matches(x, "(?i)[sabticl]").Count() + val + happ > 22
                ? "Sabbatical! Boom!"
                : "Back to your desk, boy.";
            
            Console.WriteLine(r);
        }
    }
}