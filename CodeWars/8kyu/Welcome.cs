/*
https://www.codewars.com/kata/welcome/train/csharp
https://www.codewars.com/kata/577ff15ad648a14b780000e7/solutions/csharp

8 kyu
Welcome!

Your start-up's BA has told marketing that your website has a large audience in Scandinavia and surrounding countries. Marketing thinks it would be great to welcome visitors to the site in their own language. Luckily you already use an API that detects the user's location, so this is an easy win.

The Task
Think of a way to store the languages as a database (eg an object). The languages are listed below so you can copy and paste!
Write a 'welcome' function that takes a parameter 'language' (always a string), and returns a greeting - if you have it in your database. It should default to English if the language is not in the database, or in the event of an invalid input.
The Database
{"english", "Welcome"},
{"czech", "Vitejte"},
{"danish", "Velkomst"},
{"dutch", "Welkom"},
{"estonian", "Tere tulemast"},
{"finnish", "Tervetuloa"},
{"flemish", "Welgekomen"},
{"french", "Bienvenue"},
{"german", "Willkommen"},
{"irish", "Failte"},
{"italian", "Benvenuto"},
{"latvian", "Gaidits"},
{"lithuanian", "Laukiamas"},
{"polish", "Witamy"},
{"spanish", "Bienvenido"},
{"swedish", "Valkommen"},
{"welsh", "Croeso"}
Possible invalid inputs include:

IP_ADDRESS_INVALID - not a valid ipv4 or ipv6 ip address
IP_ADDRESS_NOT_FOUND - ip address not in the database
IP_ADDRESS_REQUIRED - no ip address was supplied

*/

using System;
using System.Collections.Generic;

namespace CodeWars
{
    public class Welcome
    {
        public static string Greet(string language)
        {
            return language switch
            {
                "czech" => "Vitejte",
                "danish" => "Velkomst",
                "dutch" => "Welkom",
                "estonian" => "Tere tulemast",
                "finnish" => "Tervetuloa",
                "flemish" => "Welgekomen",
                "french" => "Bienvenue",
                "german" => "Willkommen",
                "irish" => "Failte",
                "italian" => "Benvenuto",
                "latvian" => "Gaidits",
                "lithuanian" => "Laukiamas",
                "polish" => "Witamy",
                "spanish" => "Bienvenido",
                "swedish" => "Valkommen",
                "welsh" => "Croeso",
                _ => "Welcome"
            };

            // Console.WriteLine($"language: {language}");
            // switch (language)
            // {
            //     case "czech": return "Vitejte";
            //     case "danish": return "Velkomst";
            //     case "dutch": return "Welkom";
            //     case "estonian": return "Tere tulemast";
            //     case "finnish": return "Tervetuloa";
            //     case "flemish": return "Welgekomen";
            //     case "french": return "Bienvenue";
            //     case "german": return "Willkommen";
            //     case "irish": return "Failte";
            //     case "italian": return "Benvenuto";
            //     case "latvian": return "Gaidits";
            //     case "lithuanian": return "Laukiamas";
            //     case "polish": return "Witamy";
            //     case "spanish": return "Bienvenido";
            //     case "swedish": return "Valkommen";
            //     case "welsh": return "Croeso";
            //     default: return "Welcome";
            // }
        }


        //public static string Greet(string language)
        //{
        //    return (lang.ContainsKey(language))
        //        ? lang[language]
        //        : "Welcome";
        //}

        //private static readonly Dictionary<string, string> lang = new Dictionary<string, string>
        //{
        //    {"english", "Welcome"},
        //    {"czech", "Vitejte"},
        //    {"danish", "Velkomst"},
        //    {"dutch", "Welkom"},
        //    {"estonian", "Tere tulemast"},
        //    {"finnish", "Tervetuloa"},
        //    {"flemish", "Welgekomen"},
        //    {"french", "Bienvenue"},
        //    {"german", "Willkommen"},
        //    {"irish", "Failte"},
        //    {"italian", "Benvenuto"},
        //    {"latvian", "Gaidits"},
        //    {"lithuanian", "Laukiamas"},
        //    {"polish", "Witamy"},
        //    {"spanish", "Bienvenido"},
        //    {"swedish", "Valkommen"},
        //    {"welsh", "Croeso"}
        //};


        //public static string Greet(string language)
        //{
        //    string greetings;
        //    Dictionary<string, string> ipAdress = new Dictionary<string, string>
        //    {
        //        {"english", "Welcome"},
        //        {"czech", "Vitejte"},
        //        {"danish", "Velkomst"},
        //        {"dutch", "Welkom"},
        //        {"estonian", "Tere tulemast"},
        //        {"finnish", "Tervetuloa"},
        //        {"flemish", "Welgekomen"},
        //        {"french", "Bienvenue"},
        //        {"german", "Willkommen"},
        //        {"irish", "Failte"},
        //        {"italian", "Benvenuto"},
        //        {"latvian", "Gaidits"},
        //        {"lithuanian", "Laukiamas"},
        //        {"polish", "Witamy"},
        //        {"spanish", "Bienvenido"},
        //        {"swedish", "Valkommen"},
        //        {"welsh", "Croeso"}
        //    };
        //    try
        //    {
        //        greetings = ipAdress[language];
        //    }
        //    catch (Exception e)
        //    {
        //        greetings = "Welcome";
        //    }
        //    return greetings;


        //}


        //public static string Greet(string language)
        //{
        //    Dictionary<string, string> translate = new Dictionary<string, string>()
        //    {
        //        {"english", "Welcome"},
        //        {"czech", "Vitejte"},
        //        {"danish", "Velkomst"},
        //        {"dutch", "Welkom"},
        //        {"estonian", "Tere tulemast"},
        //        {"finnish", "Tervetuloa"},
        //        {"flemish", "Welgekomen"},
        //        {"french", "Bienvenue"},
        //        {"german", "Willkommen"},
        //        {"irish", "Failte"},
        //        {"italian", "Benvenuto"},
        //        {"latvian", "Gaidits"},
        //        {"lithuanian", "Laukiamas"},
        //        {"polish", "Witamy"},
        //        {"spanish", "Bienvenido"},
        //        {"swedish", "Valkommen"},
        //        {"welsh", "Croeso"}
        //    };
        //    return translate.ContainsKey(language) ?
        //        translate[language] : "Welcome";
        //}
    }
}