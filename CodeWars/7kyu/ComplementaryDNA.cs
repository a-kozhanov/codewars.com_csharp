/*
https://www.codewars.com/kata/554e4a2f232cdd87d9000038/train/csharp
https://www.codewars.com/kata/554e4a2f232cdd87d9000038/solutions/csharp

7 kyu
Complementary DNA

Deoxyribonucleic acid (DNA) is a chemical found in the nucleus of cells and carries the "instructions" for the development and functioning of living organisms.

If you want to know more http://en.wikipedia.org/wiki/DNA

In DNA strings, symbols "A" and "T" are complements of each other, as "C" and "G". 
You have function with one side of the DNA (string, except for Haskell); you need to get the other complementary side. 
DNA strand is never empty or there is no DNA at all (again, except for Haskell).

More similar exercise are found here http://rosalind.info/problems/list-view/ (source)

MakeComplement("ATTGC") => "TAACG"
MakeComplement("GTAT") => "CATA"
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class ComplementaryDNA
    {
        public static string MakeComplement(string dna)
        {
            //var dnaPairs = new Dictionary<string, string> { { "A", "T" }, { "T", "A" }, { "G", "C" }, { "C", "G" } };
            //return Regex.Replace(dna, ".", m => dnaPairs.ContainsKey(m.Value) ? dnaPairs[m.Value] : m.Value);
            //return Regex.Replace(dna, ".", m => dnaPairs[m.Value]);

            //return Regex.Replace(dna, ".", m => $"{"TAGC"["ATCG".IndexOf(m.Value[0])]}");

            return string.Concat(dna.Select(c => "AGCT"["TCGA".IndexOf(c)]));
        }

        // public static string MakeComplement(string dna)
        // {
        //     return dna.Replace('T', '?').Replace('A', 'T').Replace('?', 'A').Replace('G', '?').Replace('C', 'G').Replace('?', 'C');
        // }


        // public static string MakeComplement(string dna)
        // {
        //     //return String.Join("", from ch in dna select "AGCT"["TCGA".IndexOf(ch)]);
        //     return string.Concat(dna.Select(c => "AGCT"["TCGA".IndexOf(c)]));
        // }

        // public static string MakeComplement(string dna)
        // {
        //     //Your code
        //     string result = "";
        //
        //     for (int i = 0; i < dna.Length; i++)
        //     {
        //         if (dna[i] == 'A') result += 'T';
        //         if (dna[i] == 'T') result += 'A';
        //         if (dna[i] == 'C') result += 'G';
        //         if (dna[i] == 'G') result += 'C';
        //     }
        //
        //     return result;
        // }


        // public static string MakeComplement(string dna)
        // {
        //     Dictionary<string, string> codeDict = new Dictionary<string, string>();
        //     codeDict.Add("A", "T");
        //     codeDict.Add("T", "A");
        //     codeDict.Add("C", "G");
        //     codeDict.Add("G", "C");
        //
        //     return string.Join("", dna.ToCharArray().Select(x => codeDict[x.ToString()]));
        // }


        // public static string MakeComplement(string dna)
        // {
        //     return string.Concat(dna.Select(pChar =>
        //     {
        //         if (pChar == 'A') return 'T';
        //         if (pChar == 'T') return 'A';
        //         if (pChar == 'C') return 'G';
        //         return 'C';
        //     }));
        // }


        // public static string MakeComplement(string dna)
        // {
        //     return string.Concat(dna.Select(c => c == 'A' ? 'T' : c == 'T' ? 'A' : c == 'C' ? 'G' : c == 'G' ? 'C' : c));
        // }


        // public static string MakeComplement(string dna)
        // {
        //     return string.Concat(dna.Select((x, y) => x == 'A' ? 'T' : x == 'T' ? 'A' : x == 'C' ? 'G' : x == 'G' ? 'C' : 'U'));
        // }
    }
}

// public class DnaStrand
// {
//     public static string MakeComplement(string dna)
//     {
//         return string.Concat(dna.Select(GetComplement));
//     }
//
//     public static char GetComplement(char symbol)
//     {
//         switch (symbol)
//         {
//             case 'A':
//                 return 'T';
//             case 'T':
//                 return 'A';
//             case 'C':
//                 return 'G';
//             case 'G':
//                 return 'C';
//             default:
//                 throw new ArgumentException();
//         }
//     }
// }