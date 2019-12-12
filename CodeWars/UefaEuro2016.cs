/*
https://www.codewars.com/kata/uefa-euro-2016/train/csharp
https://www.codewars.com/kata/57613fb1033d766171000d60/solutions/csharp

8 kyu
UEFA EURO 2016

Finish the uefaEuro2016() function so it return string just like in the examples below:

uefaEuro2016(['Germany', 'Ukraine'],[2, 0]) // "At match Germany - Ukraine, Germany won!"
uefaEuro2016(['Belgium', 'Italy'],[0, 2]) // "At match Belgium - Italy, Italy won!"
uefaEuro2016(['Portugal', 'Iceland'],[1, 1]) // "At match Portugal - Iceland, teams played draw."
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class KataUefaEuro2016
    {
        public static string UefaEuro2016(string[] t, int[] s)
        {
            return $"At match {t[0]} - {t[1]}, {(s[0] == s[1] ? "teams played draw." : t[s[0] > s[1] ? 0 : 1] + " won!")}";
        }


        //public static string UefaEuro2016(string[] teams, int[] scores)
        //{
        //    if (scores[0] == scores[1])
        //        return $"At match {teams[0]} - {teams[1]}, teams played draw.";

        //    var winningIndex = scores.ToList().IndexOf(scores.Max());
        //    return $"At match {teams[0]} - {teams[1]}, {teams[winningIndex]} won!";
        //}


        //public static string UefaEuro2016(string[] teams, int[] scores)
        //{
        //    if (scores[0] != scores[1])
        //        return $"At match {teams[0]} - {teams[1]}, {(scores[0] > scores[1] ? teams[0] : teams[1])} won!";
        //    return $"At match {teams[0]} - {teams[1]}, teams played draw.";
        //}


        //public static string UefaEuro2016(string[] t, int[] s)
        //    => $"At match {t[0]} - {t[1]}, " + (s[0] != s[1] ?
        //           $"{t[s[0] > s[1] ? 0 : 1]} won!" : "teams played draw.");

        //public static string UefaEuro2016(string[] teams, int[] scores)
        //{
        //    return String.Format("At match {0} - {1}, ", teams[0], teams[1]) + ((scores[0] == scores[1]) ? "teams played draw." : String.Format("{0} won!", scores[0] > scores[1] ? teams[0] : teams[1]));
        //}


        //public static string UefaEuro2016(string[] teams, int[] scores)
        //    => $"At match { string.Join(" - ", teams)}, { scores[0] == scores[1] ? "teams played draw.": teams[scores[0]>scores[1]? 0 : 1] + " won!"}";


    }
}