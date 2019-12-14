/*
https://www.codewars.com/kata/crash-override/train/csharp
https://www.codewars.com/kata/578c1e2edaa01a9a02000b7f/solutions/csharp

8 kyu
Crash Override

Every budding hacker needs an alias! The Phantom Phreak, Acid Burn, Zero Cool and Crash Override are some notable examples from the film Hackers.

Your task is to create a function that, given a proper first and last name, will return the correct alias.

I have created two objects that return a one word name in response to the first letter of your first name and one for the first letter of your surname.

If the first character of either of the names given to the function is not a letter from A - Z, you should return "Your name must start with a letter from A - Z."

Sometimes people might forget to capitalize the first letter of their name so your function should accommodate for these grammatical errors.

FirstName = {{"A", "Alpha"}, {"B", "Beta"}, {"C", "Cache"}, ...}
Surname = {{"A", "Analogue"}, {"B", "Bomb"}, {"C", "Catalyst"} ...}

// These dictionaries are defined on other partial Kata class

AliasGen('Larry', 'Brentwood') == 'Logic Bomb'
AliasGen('123abc', 'Petrovic') == 'Your name must start with a letter from A - Z.'
Happy hacking!

*/

using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class CrashOverride
    {
        private static readonly Dictionary<string, string> FirstName = new Dictionary<string, string>()
        {
            {"C", "Cache"},
            {"R", "RAD"},
            {"J", "Java"},
            {"B", "Beta"},
            {"H", "Half-life"},
            {"L", "Logic"},
            {"O", "OS"},
            {"Y", "Y"},
            {"Q", "Quantum"},
            {"T", "Trojan"},
            {"S", "Strike"},
            {"M", "Malware"},
            {"E", "Energy"},
            {"F", "Function"},
            {"A", "Alpha"},
            {"K", "Keystroke"},
            {"I", "Ice"},
            {"W", "WiFi"},
            {"N", "Nagware"},
            {"Z", "Zero"},
            {"D", "Data"},
            {"G", "Glitch"},
            {"V", "Vanilla"},
            {"X", "Xerox"},
            {"P", "Phishing"},
            {"U", "Ultraviolet"}
        };

        private static readonly Dictionary<string, string> Surname = new Dictionary<string, string>()
        {
            {"C", "Cache"},
            {"R", "RAD"},
            {"J", "Java"},
            {"B", "Beta"},
            {"H", "Half-life"},
            {"L", "Logic"},
            {"O", "OS"},
            {"Y", "Y"},
            {"Q", "Quantum"},
            {"T", "T-Rex"},
            {"S", "Strike"},
            {"M", "Mike"},
            {"E", "Energy"},
            {"F", "Function"},
            {"A", "Alpha"},
            {"K", "Killer"},
            {"I", "Ice"},
            {"W", "Worm"},
            {"N", "Nagware"},
            {"Z", "Zero"},
            {"D", "Data"},
            {"G", "Glitch"},
            {"V", "Vanilla"},
            {"X", "Xerox"},
            {"P", "Payload"},
            {"U", "Ultraviolet"}
        };

        public static string AliasGen_v1(string fName, string lName)
        {
            // class is partial,
            // FirstName and Surname dictionaries are defined in other part of partial
            // you can access them directly here

            const string regex = "^[a-zA-Z]+";
            if (Regex.IsMatch(fName, regex) && Regex.IsMatch(lName, regex))
            {
                return $"{FirstName[fName[0].ToString()]} {Surname[lName[0].ToString()]}";
            }

            return "Your name must start with a letter from A - Z.";
        }

        public static string AliasGen(string fName, string lName)
        {
            return char.IsLetter(fName[0]) && char.IsLetter(lName[0])
                ? $"{FirstName[fName[0].ToString()]} {Surname[lName[0].ToString()]}"
                : "Your name must start with a letter from A - Z.";
        }

    }
}