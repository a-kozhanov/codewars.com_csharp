

//https://www.codewars.com/kata/alternating-case-<-equals->-alternating-case/train/csharp
//https://www.codewars.com/kata/56efc695740d30f963000557/solutions/csharp

//altERnaTIng cAsE <=> ALTerNAtiNG CaSe
//8 kyu

//altERnaTIng cAsE <=> ALTerNAtiNG CaSe
//Define String.prototype.toAlternatingCase (or a similar function/method such as to_alternating_case/toAlternatingCase/ToAlternatingCase in your selected language;
//see the initial solution for details) such that each lowercase letter becomes uppercase and each uppercase letter becomes lowercase.

//For example:
//"hello world".ToAlternatingCase() == "HELLO WORLD"
//"HELLO WORLD".ToAlternatingCase() == "hello world"
//"hello WORLD".ToAlternatingCase() == "HELLO world"
//"HeLLo WoRLD".ToAlternatingCase() == "hEllO wOrld"
//"12345".ToAlternatingCase() == "12345" // Non-alphabetical characters are unaffected
//"1a2b3c4d5e".ToAlternatingCase() == "1A2B3C4D5E"
//"String.ToAlternatingCase".ToAlternatingCase() == "sTRING.tOaLTERNATINGcASE"
//As usual, your function/method should be pure, i.e. it should not mutate the original string.

using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public static class AlternatingCase
    {
        public static string ToAlternatingCase(this string s)
        {
            return new String(s.Select(c => (char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c))).ToArray());
        }


        //public static string ToAlternatingCase (this string s)
        //{
        //    return string.Concat(s.Select(c => char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c)));
        //}

        //public static string ToAlternatingCase (this string Input)
        //{
        //    return String.Join("", Input.ToCharArray().Select(character => Char.IsLower(character) ? Char.ToUpper(character) : Char.ToLower(character)));
        //}


        //public static string ToAlternatingCase (this string s)
        //{
        //    return string.Concat(s.Select(x => char.IsLower(x) ? char.ToUpper(x) : char.ToLower(x)));    
        //}


        //public static string ToAlternatingCase (this string s)
        //{
        //    return string.Concat(s.Select(c => (char)(c^c/65*(1-(c-1)%32/26)*32)));
        //}


        //public static string ToAlternatingCase (this string s) =>
        //    string.Concat(s.Select(c => char.IsLetter(c) ? (char)(c ^ 32) : c));


        //public static string ToAlternatingCase (this string s)
        //{
        //    return Regex.Replace(s,"[a-zA-Z]", x => Char.IsUpper(x.Value[0]) ? Char.ToLower(x.Value[0]).ToString() : Char.ToUpper(x.Value[0]).ToString());
        //}


        //public static string ToAlternatingCase (this string s)
        //{
        //    string Alternate(char c) => 
        //        char.IsLower(c) 
        //            ? char.ToUpper(c).ToString() 
        //            : char.ToLower(c).ToString();

        //    return string.Concat(s.Select(Alternate));
        //}


        //public static string ToAlternatingCase (this string s)
        //{
        //    Func<char, String> selector=
        //        c => (char.IsUpper(c)?char.ToLower(c):char.ToUpper(c)).ToString();
        //    return s.Select(selector).Aggregate(String.Concat);
        //}




    }
}