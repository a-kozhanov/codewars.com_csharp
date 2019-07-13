
//https://www.codewars.com/kata/rock-paper-scissors/train/csharp
//https://www.codewars.com/kata/5672a98bdbdd995fad00000f/solutions/csharp

//Rock Paper Scissors!
//8 kyu


//Let's play! You have to return which player won! In case of a draw return Draw!.
//Examples:
//rps('scissors','paper') // Player 1 won!
//rps('scissors','rock') // Player 2 won!
//rps('paper','paper') // Draw!

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CodeWars
{
    //Assert.AreEqual("Player 1 won!", kata.Rps("rock", "scissors"));
    //Assert.AreEqual("Player 1 won!", kata.Rps("scissors", "paper"));
    //Assert.AreEqual("Player 1 won!", kata.Rps("paper", "rock"));

    //Assert.AreEqual("Player 2 won!", kata.Rps("scissors", "rock"));
    //Assert.AreEqual("Player 2 won!", kata.Rps("paper", "scissors"));
    //Assert.AreEqual("Player 2 won!", kata.Rps("rock", "paper"));

    public class RockPaperScissors
    {
        public string Rps(string p1, string p2)
        {
            if (p1 == "rock" && p2 == "scissors") return "Player 1 won!";
            if (p1 == "scissors" && p2 == "paper") return "Player 1 won!";
            if (p1 == "paper" && p2 == "rock") return "Player 1 won!";

            if (p1 == "scissors" && p2 == "rock") return "Player 2 won!";
            if (p1 == "paper" && p2 == "scissors") return "Player 2 won!";
            if (p1 == "rock" && p2 == "paper") return "Player 2 won!";

            if (p1 == p2) return "Draw!";
            return "";
        }


        //public string Rps(string p1, string p2)
        //{
        //    if (p1 == p2)
        //        return "Draw!";

        //    if (((p1 == "rock") && (p2 == "scissors")) ||
        //        ((p1 == "scissors") && (p2 == "paper")) ||
        //        ((p1 == "paper") && (p2 == "rock")))
        //    {
        //        return "Player 1 won!";
        //    }
        //    else
        //    {
        //        return "Player 2 won!";
        //    }
        //}


        //public string Rps(string p1, string p2) {
        //    if(p1 == p2) return "Draw!";
        //    int p = (p1 + p2) == "scissorspaper" || (p1 + p2) == "rockscissors" || (p1 + p2) == "paperrock" ? 1 : 2;
        //    return "Player " + p + " won!";
        //}


        //public string Rps(string p1, string p2)
        //{
        //    return p1 == p2
        //        ? "Draw!"
        //        : "Player " + (Regex.IsMatch(p1[0] + "" + p2[0], @"rs|sp|pr") ? "1" : "2") + " won!";
        //}


        //public class Kata
        //{
        //    private static readonly IDictionary<Tuple<string, string>, string> Games =
        //        new Dictionary<Tuple<string, string>, string> {
        //            { Tuple.Create("rock", "rock"), "Draw!" },
        //            { Tuple.Create("rock", "paper"), "Player 2 won!" },
        //            { Tuple.Create("rock", "scissors"), "Player 1 won!" },
        //            { Tuple.Create("paper", "rock"), "Player 1 won!" },
        //            { Tuple.Create("paper", "paper"), "Draw!" },
        //            { Tuple.Create("paper", "scissors"), "Player 2 won!" },
        //            { Tuple.Create("scissors", "rock"), "Player 2 won!" },
        //            { Tuple.Create("scissors", "paper"), "Player 1 won!" },
        //            { Tuple.Create("scissors", "scissors"), "Draw!" },
        //        };

        //    public string Rps(string p1, string p2)
        //    {
        //        return Games[Tuple.Create(p1, p2)];
        //    }
        //}


        //public string Rps(string p1, string p2)
        //{
        //    if (p1 == p2) return "Draw!";
        //    else switch(p1.Length)
        //    {
        //        case 8:
        //            if (p2 == "rock") return "Player 2 won!";
        //            else return "Player 1 won!";
        //        case 5:
        //            if (p2 == "rock") return "Player 1 won!";
        //            else return "Player 2 won!";
        //        default:
        //            if (p2 == "scissors") return "Player 1 won!";
        //            else return "Player 2 won!";
        //    }
        //}



        //public string Rps(string p1, string p2)
        //{
        //    return p1 == "scissors" && p2 == "paper" || p1 == "rock" && p2 == "scissors" || p1 == "paper" && p2 == "rock" ? "Player 1 won!" :
        //        p1 == p2 ? "Draw!" : "Player 2 won!";
        //}



        //public string Rps(string p1, string p2)
        //{
        //    return p1 == p2 ? "Draw!" : 
        //        (p1 == "rock" && p2 == "scissors" || p1 == "scissors" && p2 == "paper" || p1 == "paper" && p2 == "rock") 
        //            ? "Player 1 won!" : "Player 2 won!";
        //}


        //private static readonly HashSet<string> map = new HashSet<string> {"scissorspaper","paperrock","rockscissors"};

        //public string Rps(string p1, string p2) => p1 == p2 ? "Draw!" : map.Contains(p1+p2) ? "Player 1 won!" : "Player 2 won!";




    }
}