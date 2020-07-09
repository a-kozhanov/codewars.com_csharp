/*
https://www.codewars.com/kata/5d076515e102162ac0dc514e/csharp

7 kyu
Baby shark lyrics generator

Baby Shark Lyrics
Create a function, as short as possible, that returns this lyrics.
Your code should be less than 300 characters. Watch out for the three points at the end of the song.

Baby shark, doo doo doo doo doo doo
Baby shark, doo doo doo doo doo doo
Baby shark, doo doo doo doo doo doo
Baby shark!
Mommy shark, doo doo doo doo doo doo
Mommy shark, doo doo doo doo doo doo
Mommy shark, doo doo doo doo doo doo
Mommy shark!
Daddy shark, doo doo doo doo doo doo
Daddy shark, doo doo doo doo doo doo
Daddy shark, doo doo doo doo doo doo
Daddy shark!
Grandma shark, doo doo doo doo doo doo
Grandma shark, doo doo doo doo doo doo
Grandma shark, doo doo doo doo doo doo
Grandma shark!
Grandpa shark, doo doo doo doo doo doo
Grandpa shark, doo doo doo doo doo doo
Grandpa shark, doo doo doo doo doo doo
Grandpa shark!
Let's go hunt, doo doo doo doo doo doo
Let's go hunt, doo doo doo doo doo doo
Let's go hunt, doo doo doo doo doo doo
Let's go hunt!
Run away,…
Good Luck!
*/

using System;
using System.IO;
using System.IO.Compression;
using System.Text;
using static System.Linq.Enumerable;
using static System.String;

namespace CodeWars
{
    public class BabySharkLyricsGenerator
    {
        public static string BabySharkLyrics()
        {
            byte[] arr1 = {31,139,8,0,0,0,0,0,0,10,115,74,76,170,84,40,206,72,44,202,214,81,72,201,207,199,134,121,185,156,104,160,72,145,151,203,55,63,55,151,176,22,26,169,2,218,239,146,152,146,66,88,15,141,84,1,237,119,47,74,204,75,201,77,36,168,139,166,234,96,238,40,32,82,95,1,141,212,1,221,225,147,90,162,94,172,144,158,175,144,81,154,87,130,71,31,77,213,1,221,17,84,154,167,144,88,158,88,169,243,168,97,25,0,159,61,7,108,32,3,0,0};

            using var stream = new MemoryStream(arr1);
            using var zip = new GZipStream(stream, CompressionMode.Decompress);
            using var reader = new StreamReader(zip);
            return reader.ReadToEnd();
            //Console.WriteLine(reader.ReadToEnd());
            
            
            
            // var sb = new StringBuilder();
            //
            // var b = "Baby";
            // var s = " shark";
            // var o = " doo doo doo doo doo doo\n";
            // var m = "Mommy";
            // var d = "Daddy";
            // var g = "Grandma";
            // var p = "Grandpa";
            // var h = "Let's go hunt";
            // var c = ",";
            // var e = "!";
            // var n = "\n";
            //
            // //var r = $"{b+s},{o}{b+s},{o}{b+s},{o}";
            // //s = ($"{b + s},{o}{b + s},{o}{b + s},{o}");
            // sb.Append(Concat(Repeat($"{b + s},{o}", 3)));
            // var r = b + s + c + o + b + s + c + o + b + s + c + o;
            // //sb.Append($"{b + s}!\n");
            // r += b + s + e + n;
            //
            //
            // //sb.Append(Concat(Repeat($"{m + s},{o}", 3)));
            // r += m + s + c + o + m + s + c + o + m + s + c + o;
            // //sb.Append($"{m + s}!\n");
            // r += m + s + e + n;
            //
            //
            // //sb.Append(Concat(Repeat($"{d + s},{o}", 3)));
            // r += d + s + c + o + d + s + c + o + d + s + c + o;
            // //sb.Append($"{d + s}!\n");
            // r += d + s + e + n;
            //
            // //sb.Append(Concat(Repeat($"{g + s},{o}", 3)));
            // r += g + s + c + o + g + s + c + o + g + s + c + o;
            // //sb.Append($"{g + s}!\n");
            // r += g + s + e + n;
            //
            // //sb.Append(Concat(Repeat($"{p + s},{o}", 3)));
            // r += p + s + c + o + p + s + c + o + p + s + c + o;
            // //sb.Append($"{p + s}!\n");
            // r += p + s + e + n;
            //
            // //sb.Append(Concat(Repeat($"{h},{o}", 3)));
            // r += h + c + o + h + c + o + h + c + o;
            //
            // //sb.Append($"{h}!\n");
            // r += h + e + n;
            //
            // //return sb.Append("Run away,…\n").ToString();
            // r += "Run away,…\n";
            //
            // return r;
        }
    }
}