
//https://www.codewars.com/kata/highest-scoring-word/train/csharp
//https://www.codewars.com/kata/57eb8fcdf670e99d9b000272/solutions/csharp

//Highest Scoring Word

//Given a string of words, you need to find the highest scoring word.
//Each letter of a word scores points according to its position in the alphabet: a = 1, b = 2, c = 3 etc.
//You need to return the highest scoring word as a string.
//If two words score the same, return the word that appears earliest in the original string.
//All letters will be lowercase and all inputs will be valid.

using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class HighestScoringWord
    {
        public static string High(string s)
        {
            var words = s.Split();
            var scoring = words.Select(w => w.Sum(c => c - 96)).ToList();
            return words[scoring.IndexOf(scoring.Max())];
        }

        //public static string High(string s)
        //{
        //    return s.Split(' ').OrderBy(a => a.Select(b => b - 96).Sum()).Last();
        //}

        //public class Kata
        //{
        //    public static string High(string s) => s.Split(' ').OrderBy(w => w.Sum(c => c - 'a' + 1)).Last();
        //}

        //public static string High(string s)
        //{
        //    return s
        //        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        //        .Select(
        //            (word, position) =>
        //            (
        //                Word: word,
        //                Score: word.Sum(c => c - 'a'),
        //                Position: position
        //            ))
        //        .OrderByDescending(t => t.Score)
        //        .ThenBy(t => t.Position)
        //        .First().Word;    
        //}


        //public static string High(string input) =>
        //    input.Split((char[])null, StringSplitOptions.RemoveEmptyEntries)
        //        .Select((s, i) => Tuple.Create(s.Sum(c => c - 'a' + 1), -i, s)).Max().Item3;


        //public static string High(string s) => s.Split(' ').OrderBy(s1 => s1.Sum(c => (int)c - 96)).Last();

        //public static string High(string s)
        //{
        //    return s.Split(' ').OrderByDescending(x => x.Sum(z => z - 'a' + 1)).First();
        //}

        //public static string High(string s)
        //{
        //    var words = s.Split(' ');
        //    var totalScores = words.Select(word => word.Sum(character => char.ToUpper(character) - 64)).ToList();

        //    return words[totalScores.FindIndex(i => i == totalScores.Max())];
        //}

        //public static string High(string s)
        //{
        //    var a = s.Split();
        //    var score = a.Select(x => x.ToUpper().Sum(y => y - 64));
        //    var index = score.Select((x, i) => x == score.Max() ? i : -1).Max();
        //    return a[index];
        //}


        //public static int WordScore(string s)
        //{
        //    return s.Aggregate(0, (score, c) => score + (int)(c - 'a' + 1));
        //}

        //public static string High(string s)
        //{
        //    return s.Split(' ').OrderByDescending(w => WordScore(w)).First();
        //}



        //public static string High(string s)
        //{
        //    return s.Split(' ').Select(x => x.ToLower()).OrderByDescending(x => x.Select(w => (int)w -  96).Sum()).FirstOrDefault();
        //}


        //public static string High(string s)
        //{
        //    return s.Split(' ', '\t').OrderByDescending(x => x.ToCharArray().Sum(x1 => ((int)x1 - 96))).First();
        //}





    }
}