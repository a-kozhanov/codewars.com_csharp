/*
https://www.codewars.com/kata/592a6ad46d6c5a62b600003f/csharp

7 kyu
GA-DE-RY-PO-LU-KI cypher

Introduction
The GADERYPOLUKI is a simple substitution cypher used in scouting to encrypt messages. 
The encryption is based on short, easy to remember key. 
The key is written as paired letters, which are in the cipher simple replacement.

The most frequently used key is "GA-DE-RY-PO-LU-KI".

 G => A
 g => a
 a => g
 A => G
 D => E
  etc.
The letters, which are not on the list of substitutes, stays in the encrypted text without changes.

Task
Your task is to help scouts to encrypt and decrypt thier messages. Write the Encode and Decode functions.

Input/Output
The input string consists of lowercase and uperrcase characters and white . The substitution has to be case-sensitive.

Example
 Encode("ABCD")          // => GBCE 
 Encode("Ala has a cat") // => Gug hgs g cgt 
 Encode("gaderypoluki"); // => agedyropulik
 Decode("Gug hgs g cgt") // => Ala has a cat 
 Decode("agedyropulik")  // => gaderypoluki
 Decode("GBCE")          // => ABCD
GADERYPOLUKI collection
GADERYPOLUKI cypher vol 1
GADERYPOLUKI cypher vol 2
GADERYPOLUKI cypher vol 3 - Missing Key
GADERYPOLUKI cypher vol 4 - Missing key madness
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class GADERYPOLUKICypher
    {
        private static Dictionary<char, char> encoder = new Dictionary<char, char>
        {
            {'G', 'A'}, {'A', 'G'}, {'g', 'a'}, {'a', 'g'}, {'D', 'E'}, {'E', 'D'}, {'d', 'e'}, {'e', 'd'},
            {'R', 'Y'}, {'Y', 'R'}, {'r', 'y'}, {'y', 'r'}, {'P', 'O'}, {'O', 'P'}, {'p', 'o'}, {'o', 'p'},
            {'L', 'U'}, {'U', 'L'}, {'l', 'u'}, {'u', 'l'}, {'K', 'I'}, {'I', 'K'}, {'k', 'i'}, {'i', 'k'}
        };

        // public static string Encode(string s) => new string(s.Select(c => encoder.ContainsKey(c) ? encoder[c] : c).ToArray());
        public static string Encode(string s) => string.Concat(s.Select(c => encoder.ContainsKey(c) ? encoder[c] : c));

        public static string Decode(string s) => Encode(s);


        // public static string Encode(string str) => Decode(str);
        //
        // public static string Decode(string str)
        // {
        //     const string s = "GDRPLKgdrplkAEYOUIaeyoui";
        //     const string t = "AEYOUIaeyouiGDRPLKgdrplk";
        //     return string.Concat(str.Select(c => s.IndexOf(c) < 0 ? c : t[s.IndexOf(c)]));
        // }
    }
}