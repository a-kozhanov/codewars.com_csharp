using System;
using System.Collections.Generic;
using System.Linq;

//https://www.codewars.com/kata/i-love-you-a-little-a-lot-passionately-dot-dot-dot-not-at-all/train/csharp
//https://www.codewars.com/kata/57f24e6a18e9fad8eb000296/solutions/csharp

//I love you, a little , a lot, passionately ... not at all
//8 kyu


//Who remembers back to their time in the schoolyard, when girls would take a flower and tear its petals, saying each of the following phrases each time a petal was torn:

//I love you
//a little
//a lot
//passionately
//madly
//not at all
//When the last petal was torn there were cries of excitement, dreams, surging thoughts and emotions.

//Your goal in this kata is to determine which phrase the girls would say for a flower of a given number of petals, where nb_petals > 0.

namespace CodeWars
{
    public class KataHowMuchILoveYou
    {
        public static string HowMuchILoveYou(int nb_petals)
        {
            switch (nb_petals % 6)
            {
                case 1: return "I love you";
                case 2: return "a little";
                case 3: return "a lot";
                case 4: return "passionately";
                case 5: return "madly";
                case 0: return "not at all";
                default: return "";
            }
        }



        //public static string HowMuchILoveYou(int nb_petals)
        //{
        //    return new string[] { "I love you", "a little", "a lot", "passionately", "madly", "not at all" }[(nb_petals - 1) % 6];
        //}



        //static string[] petalText = new string[]
        //{
        //    "I love you",
        //    "a little",
        //    "a lot",
        //    "passionately",
        //    "madly",
        //    "not at all"
        //};

        //public static string HowMuchILoveYou(int nb_petals)
        //{
        //    return petalText[(nb_petals - 1) % petalText.Length];
        //}


        //public static List<string> names = new List<string> { "I love you", "a little", "a lot", "passionately", "madly", "not at all" };

        //public static string HowMuchILoveYou(int nb_petals)
        //{
        //    return names.ElementAt((nb_petals - 1) % names.Count);
        //}


        //public static string HowMuchILoveYou(int nb_petals)
        //{
        //    string[] tab = { "I love you", "a little", "a lot", "passionately", "madly", "not at all" };
        //    nb_petals -= 1;
        //    return tab[nb_petals % 6];

        //}









    }
}