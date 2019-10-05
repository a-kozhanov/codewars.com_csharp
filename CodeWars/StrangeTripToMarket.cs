

//https://www.codewars.com/kata/a-strange-trip-to-the-market/train/csharp
//https://www.codewars.com/kata/55ccdf1512938ce3ac000056/solutions/csharp

//A Strange Trip to the Market
//8 kyu


//You're on your way to the market when you hear beautiful music coming from a nearby street performer.
//The notes come together like you wouln't believe as the musician puts together patterns of tunes.
//As you wonder what kind of algorithm you could use to shift octaves by 8 pitches or something silly like that,
//it dawns on you that you have been watching the musician for some 10 odd minutes. You ask,
//"How much do people normally tip for something like this?" The artist looks up. "Its always gonna be about tree fiddy."

//It was then that you realize the musician was a 400 foot tall beast from the paleolithic era.
//The Loch Ness Monster almost tricked you!

//There are only 2 guaranteed ways to tell if you are speaking to The Loch Ness Monster: A.)
//It is a 400 foot tall beast from the paleolithic era B.) It will ask you for tree fiddy

//Since Nessie is a master of disguise, the only way accurately tell is to look for the phrase "tree fiddy".
//Since you are tired of being grifted by this monster, the time has come to code a solution for finding The Loch Ness Monster.
//Note: It can also be written as 3.50 or three fifty.


using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class StrangeTripToMarket
    {
        public static bool IsLockNessMonster(string sentence)
        {
            return sentence.Contains("tree fiddy", StringComparison.OrdinalIgnoreCase) ||
                   sentence.Contains("three fifty") ||
                   sentence.Contains("3.50");
        }

        //public static bool IsLockNessMonster(string sentence) 
        //{
        //    return sentence.ToUpper().Contains("TREE FIDDY") || sentence.Contains("3.50");
        //}


        //public static bool IsLockNessMonster(string sentence) 
        //    => Regex.IsMatch(sentence, @"tree fiddy|3\.50", RegexOptions.IgnoreCase);

        //public static bool IsLockNessMonster(string sentence)
        //{
        //    return !(sentence.Contains("Ness") || sentence.Contains("beast"));
        //}


        //public static bool IsLockNessMonster(string sentence) 
        //{
        //    return sentence.ToLower().Replace("3.50", "tree fiddy").Contains("tree fiddy");
        //}


        //public static bool IsLockNessMonster(string sentence) => new[] { "tree fiddy", "3.50" }.Any(sentence.ToLower().Contains);


        //public static bool IsLockNessMonster(string sentence) 
        //{
        //    return (sentence.ToLower().Contains("tree fiddy") || sentence.Contains("3.50") || sentence.Contains("three fifty")) ? true:false;
        //}


        //public static bool IsLockNessMonster(string sentence) 
        //    => new Regex(@"(3\.50|tree fiddy|three fifty)", RegexOptions.IgnoreCase).Match(sentence).Success; 


        //public static bool IsLockNessMonster(string sentence) 
        //{
        //    return sentence.ToUpper().Contains("TREE FIDDY") || sentence.ToUpper().Contains("3.50");
        //}



    }
}