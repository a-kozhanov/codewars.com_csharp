/*
https://www.codewars.com/kata/grasshopper-terminal-game-turn-function/train/csharp
https://www.codewars.com/kata/grasshopper-terminal-game-turn-function/solutions/csharp

8 kyu
Grasshopper - Terminal Game Turn Function

Terminal game turn function
You are creating a text-based terminal version of your favorite board game. In the board game, 
each turn has six steps that must happen in this order: roll the dice, move, combat, get coins, buy more health, and print status.

You are using a library (Game.Logic in C#) that already has the functions below. 
Create a function named doTurn/DoTurn/do_turn that calls the functions in the proper order as described in the paragraph above.

- Combat
- BuyHealth
- GetCoins
- PrintStatus
- RollDice
- Move
*/

using System;
using System.Collections.Generic;
using System.Linq;
//using static Game.Logic;

namespace CodeWars
{
    public class GrasshopperTerminalGameTurnFunction
    {
        // public static Action[] DoTurn() =>
        //     new Action[] {RollDice, Move, Combat, GetCoins, BuyHealth, PrintStatus}.Select(a => a.Invoke());

        //{RollDice, Move, Combat, GetCoins, BuyHealth, PrintStatus}.ForEach(a => a.Invoke());

        public static void DoTurn()
        {
            new List<Action> {RollDice, Move, Combat, GetCoins, BuyHealth, PrintStatus}.ForEach(a => a.Invoke());
        }

        // public static void DoTurn()
        // {
        //     RollDice();
        //     Move();
        //     Combat();
        //     GetCoins();
        //     BuyHealth();
        //     PrintStatus();
        // }

        private static void Move()
        {
            Console.WriteLine("should move second");
        }

        private static void RollDice()
        {
            Console.WriteLine("should roll dice first");
        }

        private static void PrintStatus()
        {
            Console.WriteLine("should print status sixth");
        }

        private static void GetCoins()
        {
            Console.WriteLine("should get coins fourth");
        }

        private static void BuyHealth()
        {
            Console.WriteLine("should buy health fifth");
        }

        private static void Combat()
        {
            Console.WriteLine("should combat third");
        }
    }
}


// public static void DoTurn()
// {
// Game.Logic.RollDice();
// Game.Logic.Move();
// Game.Logic.Combat();
// Game.Logic.GetCoins();
// Game.Logic.BuyHealth();
// Game.Logic.PrintStatus();
// }


// public static void DoTurn()
// {
// Log = new List<string>
// {
//     "RollDice",
//     "Move",
//     "Combat",
//     "GetCoins",
//     "BuyHealth",
//     "PrintStatus",
// };
// }


// public static void DoTurn() =>
// new List<Action> {RollDice, Move, Combat, GetCoins, BuyHealth, PrintStatus}.ForEach(a => a.Invoke());

