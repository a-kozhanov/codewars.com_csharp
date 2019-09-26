using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

//https://www.codewars.com/kata/stringy-strings/train/csharp
//https://www.codewars.com/kata/563b74ddd19a3ad462000054/solutions/csharp

//Stringy Strings

//write me a function stringy that takes a size and returns a string of alternating '1s' and '0s'.
//the string should start with a 1.
//a string with size 6 should return :'101010'.
//with size 4 should return : '1010'.
//with size 12 should return : '101010101010'.
//The size will always be positive and will only use whole numbers.

namespace CodeWars
{
    public class StringyStrings
    {
        public static string Stringy(int size)
        {
            return string.Concat(Enumerable.Repeat("10", size)).Substring(0, size);
        }


        //public static string Stringy(int size)
        //{
        //    var result = new StringBuilder();
        //    for (var i = 1; i <= size; i++)
        //    {
        //        result.Append(i % 2);
        //    }
        //    return result.ToString();
        //}


        //public static string Stringy(int size)
        //{
        //    return string.Join("", Enumerable.Range(0, size).Select(x => (x + 1) % 2));
        //}


        //public static string Stringy(int size)
        //{
        //    return Regex.Replace(new string('1', size), "11", "10");
        //}

        //public static string Stringy(int size)
        //{
        //    var aux = string.Empty;
        //    for (int i = 0; i < size; i++)
        //        if (i % 2 == 0)
        //            aux += "1";
        //        else
        //            aux += "0";
        //    return aux;
        //}

        //public static string Stringy(int size)
        //{
        //    return new string(string.Concat(Enumerable.Repeat("10", (size + 1) / 2)).Take(size).ToArray());
        //}

        //public static string Stringy(int size)
        //{
        //    return string.Concat(Enumerable.Range(0, size).Select(x => x % 2 == 0 ? "1" : "0"));
        //}

        //public static string Stringy(int size)
        //{
        //    var bin = "";
        //    for (var i = 0; i < size; i++)
        //    {
        //        bin += i % 2 == 0 ? "1" : "0";
        //    }
        //    return bin;
        //}


        //public static string Stringy(int size)
        //{
        //    return string.Concat(Enumerable.Range(1, size).Select(x => x & 1));
        //}



    }
}

