/*
https://www.codewars.com/kata/grasshopper-bug-squashing/train/csharp
https://www.codewars.com/kata/56214b6864fe8813f1000019/solutions/csharp

8 kyu
Grasshopper - Bug Squashing

Terminal game bug squashing
You are creating a text-based terminal version of your favorite board game. 
In the board game, each turn has six steps that must happen in this order: roll the dice, move, combat, get coins, buy more health, and print status.

You are using a library that already has the functions below. 
Create a function named main that calls the functions in the proper order.

- `Combat`
- `BuyHealth`
- `GetCoins`
- `PrintStatus`
- `RollDice`
- `Move`
*/

using System;
using System.Collections.Generic;

namespace CodeWars
{
    public class GrasshopperBugSquashing
    {
        public static int Health = 100;
        public static int Position = 0;
        public static int Coins = 0;
        public static List<string> Log = new List<string>(); //Delete in kata

        public static void PlayTurn()
        {
            Log = new List<string> { "RollDice", "Move", "Combat", "GetCoins", "BuyHealth", "PrintStatus" };
        }
    }
}

//public static partial class Kata
//{
//    public static int Health = 100;
//    public static int Position = 0;
//    public static int Coins = 0;

//    public static void PlayTurn()
//    {
//        Log.AddRange(new[] {"RollDice", "Move", "Combat", "GetCoins", "BuyHealth", "PrintStatus"});
//    }
//}


//    public static partial class Kata
//    {
//        public static int Health = 100;
//        public static int Position = 0;
//        public static int Coins = 0;

//        public static void PlayTurn()
//        {
//            RolDice();
//            Move();
//            Combat();
//            GetCoins();
//            BuyHealth();
//            PrintStatus();
//        }

//        public static void RolDice()
//        {
//            Log.Add("RollDice");
//        }
//    }



