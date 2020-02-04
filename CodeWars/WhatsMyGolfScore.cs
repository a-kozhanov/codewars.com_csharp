/*
https://www.codewars.com/kata/59f7a0a77eb74bf96b00006a
https://www.codewars.com/kata/59f7a0a77eb74bf96b00006a/solutions/csharp

7 kyu
What's my golf score?

I have the par value for each hole on a golf course and my stroke score on each hole. 
I have them stored as strings, because I wrote them down on a sheet of paper. Right now, 
I'm using those strings to calculate my golf score by hand: 
take the difference between my actual score and the par of the hole, and add up the results for all 18 holes.

For example:

If I took 7 shots on a hole where the par was 5, my score would be: 7 - 5 = 2
If I got a hole-in-one where the par was 4, my score would be: 1 - 4 = -3.
Doing all this math by hand is really hard! Can you help make my life easier?

Task Overview
Complete the function which accepts two strings and calculates the golf score of a game. 
Both strings will be of length 18, and each character in the string will be a number between 1 and 9 inclusive.
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class WhatsMyGolfScore
    {
        public static int GolfScoreCalculator(string par, string score)
        {
            //return Enumerable.Range(0, par.Length).Sum(i => score[i] - par[i]);
            return score.Zip(par, (x, y) => x - y).Sum();
        }

        // public static int GolfScoreCalculator(string par, string score)
        // {
        //     if (string.IsNullOrEmpty(par) || string.IsNullOrEmpty(score)) throw new ArgumentNullException();
        //     if (par.Length != score.Length || !(par.Any(char.IsDigit) && score.Any(char.IsDigit))) throw new ArgumentException();
        //     return score.Sum(x => x - '0') - par.Sum(x => x - '0');
        // }


        // public static int GolfScoreCalculator(string par, string score)
        // {
        //     return score.Select(x => Convert.ToInt32(x)).Sum() - par.Select(x => Convert.ToInt32(x)).Sum();
        // }

        // public static int GolfScoreCalculator(string par, string score)
        // {
        //     if (string.IsNullOrEmpty(par) || string.IsNullOrEmpty(score)) throw new ArgumentNullException();
        //     if (par.Length != score.Length) throw new ArgumentException();
        //     if (!(par.Any(char.IsDigit) && score.Any(char.IsDigit))) throw new ArgumentException();
        //     return score.Sum(x => x - '0') - par.Sum(x => x - '0');
        // }


        // public static int GolfScoreCalculator(string par, string score)
        // {
        //     int sum=0;
        //     for (int i=0; i<par.Length; i++)
        //     {
        //         sum+=int.Parse(score[i].ToString())-int.Parse(par[i].ToString());
        //     }
        //     return sum;
        // }
    }
}