/*
https://www.codewars.com/kata/did-she-say-hallo/train/csharp
https://www.codewars.com/kata/56a4addbfd4a55694100001f/solutions/csharp

8 kyu
Did she say hallo?

You received a whatsup message from an unknown number. 
Could it be from that girl/boy with a foreign accent you met yesterday evening?
Write a simple regex to check if the string contains the word hallo in different languages.
These are the languages of the possible people you met the night before:

hello - english
ciao - italian
salut - french
hallo - german
hola - spanish
ahoj - czech republic
czesc - polish
By the way, how cool is the czech republic hallo!!

PS. you can assume the input is a string. PPS. to keep this a beginner exercise you don't need to check if the greeting is a subset of word ('Hallowen' can pass the test)

PS. regex should be case insensitive to pass the tests
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class DidSheSayHallo
    {
        public static bool Validate_hello(string greetings)
        {
            return new[] { "hello", "ciao", "salut", "hallo", "hola", "ahoj", "czesc" }.
                Any(w => greetings.Contains(w, StringComparison.CurrentCultureIgnoreCase));
        }

        //public static Boolean Validate_hello(String Greetings)
        //{
        //    return Regex.IsMatch(Greetings, "hello|ciao|salut|hallo|hola|ahoj|czesc", RegexOptions.IgnoreCase);
        //}

        //public static bool Validate_hello(string greetings)
        //{
        //    Console.WriteLine(greetings);
        //    List<string> myList = new List<string>() { "hello", "ciao", "salut", "hallo", "hola", "ahoj", "czesc" };
        //    return myList.Any(greetings.ToLower().Contains);
        //}


        //public static bool Validate_hello(string greetings)
        //{
        //    return Regex.IsMatch(greetings,@"(?i)h([ea]llo|ola)|c(iao|zesc)|salut|ahoj");
        //}


        //public static bool Validate_hello(string greetings)
        //{
        //    return new[] { "hello", "ciao", "hola", "salut", "hallo", "ahoj", "czesc" }.Any(c => greetings.ToLower().Contains(c.ToLower()));
        //}


        //public static bool Validate_hello(string g)=>
        //    (new string[]{ "hello","ciao","salut","hallo","hola","ahoj","czesc"})
        //    .Any(t=>g.ToLower().Contains(t));


        //public static bool Validate_hello(string greetings)
        //{
        //    return new[] {"hello", "ciao", "salut", "hallo", "hola", "ahoj", "czesc"}.Any(c =>
        //        greetings.ToLower().Contains(c));
        //}

    }
}