using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
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
            Dictionary<string, string> dna1 = new Dictionary<string, string>();//{{'A': 'T'}, {'T': 'A'}, {'G': 'C'}, {'C': 'G'}};
            dna1.Add("A", "T");
            dna1.Add("T", "A");
            dna1.Add("G", "C");
            dna1.Add("C", "G");

            //var dna = "TAACG";
            var dna = "GTAT";
            //"TAGC"["ATCG".IndexOf(c)];

            //var D = {'A': 'T', 'T': 'A', 'G': 'C', 'C': 'G'};
            //var r = Regex.Replace(dna, ".", m => dna1.ContainsKey(m.Value) ? dna1[m.Value] : m.Value);
            //var r = Regex.Replace(dna, ".", m => "TAGC"["ATCG".IndexOf(m.Value[0])]);

            //var r1 = dna.Replace(dna, "TAGC"["ATCG".IndexOf()]);
            //var r = Regex.Replace(dna, ".", m => $"{ "TAGC"["ATCG".IndexOf(m.Value[0])] }");
            var r = Regex.Replace(dna, ".", m => $"{ "TAGC"["ATCG".IndexOf(m.Value[0])] }");

            Console.WriteLine(r);

            //Assert.AreEqual("TAACG", ComplementaryDNA.MakeComplement("ATTGC")); "TAGC"["ATCG".IndexOf(c)];
            //Assert.AreEqual("CATA", ComplementaryDNA.MakeComplement("GTAT"));

        }
    }
}


