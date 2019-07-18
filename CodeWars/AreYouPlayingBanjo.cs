//https://www.codewars.com/kata/are-you-playing-banjo/train/csharp
//https://www.codewars.com/kata/53af2b8861023f1d88000832/solutions/csharp

//Are You Playing Banjo?
//8 kyu

//Create a function which answers the question "Are you playing banjo?".
//If your name starts with the letter "R" or lower case "r", you are playing banjo!

//The function takes a name as its only argument, and returns one of the following strings:

//name + " plays banjo" 
//name + " does not play banjo"
//Names given are always valid strings.

using System;
using System.Globalization;

namespace CodeWars
{
    public static class KataAreYouPlayingBanjo
    {
        public static string AreYouPlayingBanjo(string name)
        {
            return name.ToUpper().StartsWith("R") ? $"{name} plays banjo" : $"{name} does not play banjo";
        }

        //public static string AreYouPlayingBanjo(string name)
        //{
        //    return string.Format("{0} {1} banjo", name, char.ToLower(name[0]) == 'r' ? "plays" : "does not play");
        //}


        //public static string AreYouPlayingBanjo(string name)
        //{
        //    //Implement me
        //    return name.ToLower()[0] == 'r' ? name + " plays banjo" : name + " does not play banjo";
        //}


        //public static string AreYouPlayingBanjo(string name)
        //{
        //    if (name.StartsWith("R", true, CultureInfo.InvariantCulture))
        //        return String.Format("{0} plays banjo", name);
        //    return String.Format("{0} does not play banjo", name);
        //}


        //public static string AreYouPlayingBanjo(string name) => name.ToLower()[0] == 'r' ? name + " plays banjo" : name + " does not play banjo";


        //public static string AreYouPlayingBanjo(string name)
        //{
        //    return $"{name} {(name[0] == 'R' || name[0] == 'r')? "plays banjo" : "does not play banjo"}";
        //}


        //public static string AreYouPlayingBanjo(string name)
        //{
        //    return name + " " + (name.ToUpperInvariant().StartsWith("R") ? "plays" : "does not play") + " banjo";
        //}



    }
}