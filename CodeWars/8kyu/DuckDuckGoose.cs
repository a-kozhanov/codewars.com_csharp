/*
https://www.codewars.com/kata/duck-duck-goose/train/csharp


8 kyu
Duck Duck Goose


The objective of Duck, duck, goose is to walk in a circle, tapping on each player's head until one is chosen.
Task: Given an array of Player objects (an array of associative arrays in PHP) and an index (1-based), return the name of the chosen Player(name is a property of Player objects, e.g Player.name)

Example:
duck_duck_goose([a, b, c, d], 1) should return a.name
duck_duck_goose([a, b, c, d], 5) should return a.name
duck_duck_goose([a, b, c, d], 4) should return d.name
// PHP only
duck_duck_goose([$a, $b, $c, $d], 1); // => $a["name"]
duck_duck_goose([$a, $b, $c, $d], 5); // => $a["name"]
duck_duck_goose([$a, $b, $c, $d], 4); // => $d["name"]
*/


using System;

namespace CodeWars
{
    public class KataDuckDuckGoose
    {
        public static string DuckDuckGoose(Player[] players, int goose)
        {
            var count = 0;
            for (var i = 1; i < goose; i++)
            {
                if (count > players.Length - 1) count = 1;
                else count++;
            }
            return players[count].Name;
        }
    }

    public class Player
    {
        public string Name { get; set; }
        public Player(string name)
        {
            this.Name = name;
        }
    }


    //public static string DuckDuckGoose(Player[] players, int goose)
    //{
    //    return players[(goose - 1) % players.Length].Name;
    //}

    //public static string DuckDuckGoose(Player[] players, int goose) => players[(goose - 1) % players.Length].Name;


    //public static string DuckDuckGoose(Player[] players, int goose)
    //{
    //    while (goose > players.Length)
    //    {
    //        goose = goose - players.Length;
    //    }
    //    return players[goose - 1].Name;
    //}


    //public static string DuckDuckGoose(Player[] players, int goose)
    //{
    //    var index = goose % players.Length;
    //    return players[(index == 0 ? players.Length : index) - 1].Name;
    //}




}