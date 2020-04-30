/*
https://www.codewars.com/kata/57c1ab3949324c321600013f/train/csharp

7 kyu
ToLeetSpeak

Your task is to write a function toLeetSpeak that converts a regular english sentence to Leetspeak.

More about LeetSpeak You can read at wiki -> https://en.wikipedia.org/wiki/Leet

Consider only uppercase letters (no lowercase letters, no numbers) and spaces.

For example:
toLeetSpeak("LEET") returns "1337"

In this kata we use a simple LeetSpeak dialect. Use this alphabet:
{
  A : '@',
  B : '8',
  C : '(',
  D : 'D',
  E : '3',
  F : 'F',
  G : '6',
  H : '#',
  I : '!',
  J : 'J',
  K : 'K',
  L : '1',
  M : 'M',
  N : 'N',
  O : '0',
  P : 'P',
  Q : 'Q',
  R : 'R',
  S : '$',
  T : '7',
  U : 'U',
  V : 'V',
  W : 'W',
  X : 'X',
  Y : 'Y',
  Z : '2'
}
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class KataToLeetSpeak
    {
        public static string ToLeetSpeak(string str)
        {
            // var alphabet = "ABCEFGHILOSTZ";
            // var dialect = "@8(3F6#!10$72";
            // return string.Concat(str.Select(x => alphabet.Contains(x) ? dialect[alphabet.IndexOf(x)] : x));

            // var alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ ";
            // var dialect = "@8(D3F6#!JK1MN0PQR$7UVWXY2 ";
            // return string.Concat(str.Select(x => alphabet.Contains(x) ? dialect[alphabet.IndexOf(x)] : x));

            //return string.Concat(str.Select(c => "@8(D3F6#!JK1MN0PQR$7UVWXY2 "["ABCDEFGHIJKLMNOPQRSTUVWXYZ ".IndexOf(c)]));

            return string.Concat(str.Select(x => x != ' ' ? "@8(D3F6#!JK1MN0PQR$7UVWXY2"[x - 'A'] : x));
        }
    }
}