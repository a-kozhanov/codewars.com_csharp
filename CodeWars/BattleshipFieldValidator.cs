/*
https://www.codewars.com/kata/battleship-field-validator/csharp
https://www.codewars.com/kata/battleship-field-validator/solutions/csharp

3 kyu
Battleship field validator

Write a method that takes a field for well-known board game "Battleship" as an argument and returns true if it has a valid disposition of ships, 
false otherwise. Argument is guaranteed to be 10*10 two-dimension array. Elements in the array are numbers, 0 if the cell is free and 1 if occupied by ship.

Battleship (also Battleships or Sea Battle) is a guessing game for two players. 
Each player has a 10x10 grid containing several "ships" and objective is to destroy enemy's forces by targetting individual cells on his field. 
The ship occupies one or more cells in the grid. Size and number of ships may differ from version to version. 
In this kata we will use Soviet/Russian version of the game.

Before the game begins, players set up the board and place the ships accordingly to the following rules:
There must be single battleship (size of 4 cells), 2 cruisers (size 3), 3 destroyers (size 2) and 4 submarines (size 1). 
Any additional ships are not allowed, as well as missing ships.
Each ship must be a straight line, except for submarines, which are just single cell.

The ship cannot overlap or be in contact with any other ship, neither by edge nor by corner.

This is all you need to solve this kata. If you're interested in more information about the game, visit this link.
*/

using System;
using System.Collections.Generic;

namespace CodeWars
{
    public class BattleshipFieldValidator
    {
        public static bool ValidateBattlefield(int[,] field) //Release version function ValidateBattlefield
        {
            var result = true;
            var battleships = 0;
            var cruisers = 0;
            var destroyers = 0;
            var submarines = 0;
            var maxX = field.GetLength(1);
            var maxY = field.GetLength(0);

            for (var y = 0; y < maxY; y++)
            {
                for (var x = 0; x < maxX; x++)
                {
                    var sizeUnknownShip = 0;

                    if (x + 1 < maxX && y + 1 < maxY)
                    {
                        if (field[y, x] != 0 && field[y + 1, x + 1] != 0) result = false;
                    }

                    if (x - 1 >= 0 && y - 1 >= 0)
                    {
                        if (field[y, x] != 0 && field[y + 1, x - 1] != 0) result = false;
                    }

                    if (field[y, x] == 1)
                    {
                        if (x + 1 < maxX && field[y, x + 1] == 1)
                        {
                            for (var xp = 0; xp < maxX - x; xp++)
                            {
                                if (x + xp < maxX && field[y, x + xp] == 1)
                                {
                                    field[y, x + xp] = 2;
                                    sizeUnknownShip++;
                                }
                                else
                                    break;
                            }
                        }

                        if (y + 1 < maxY && field[y + 1, x] == 1)
                        {
                            for (var yp = 0; yp < maxY - y; yp++)
                            {
                                if (y + yp < maxY && field[y + yp, x] == 1)
                                {
                                    field[y + yp, x] = 2;
                                    sizeUnknownShip++;
                                }
                                else
                                    break;
                            }
                        }

                        if (field[y, x] == 1)
                        {
                            field[y, x] = 2;
                            sizeUnknownShip++;
                        }
                    }

                    switch (sizeUnknownShip)
                    {
                        case 0: break;
                        case 1: submarines++; break;
                        case 2: destroyers++; break;
                        case 3: cruisers++; break;
                        case 4: battleships++; break;
                        default: result = false; break;
                    }
                }
            }

            if (submarines != 4) result = false;
            if (destroyers != 3) result = false;
            if (cruisers != 2) result = false;
            if (battleships != 1) result = false;

            return result;
        }



        public static bool ValidateBattlefield2(int[,] field) //Debug version function ValidateBattlefield
        {
            var result = true;      //return result bool
            var battleships = 0;    //1 battleship (size of 4 cells)
            var cruisers = 0;       //2 cruisers (size 3)
            var destroyers = 0;     //3 destroyers (size 2)
            var submarines = 0;     //4 submarines (size 1)
            var maxX = field.GetLength(1);
            var maxY = field.GetLength(0);

            for (var y = 0; y < maxY; y++)
            {

                for (var x = 0; x < maxX; x++)
                {
                    var sizeUnknownShip = 0;

                    if (x + 1 < maxX && y + 1 < maxY)
                    {
                        var p0 = field[y, x];
                        var p1 = field[y + 1, x + 1];

                        if (field[y, x] != 0 && field[y + 1, x + 1] != 0) //Ship contacted in corner
                        {
                            result = false;
                            //Console.WriteLine($"Ship contacted in corner");
                        }
                    }

                    if (x - 1 >= 0 && y - 1 >= 0)
                    {
                        var p0 = field[y, x];
                        var p1 = field[y - 1, x - 1];

                        if (field[y, x] != 0 && field[y + 1, x - 1] != 0) //Ship contacted in corner
                        {
                            result = false;
                            //Console.WriteLine($"Ship contacted in corner");
                        }
                    }

                    if (field[y, x] == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;

                        if (x + 1 < maxX && field[y, x + 1] == 1)
                        {
                            for (var xp = 0; xp < maxX - x; xp++)
                            {
                                if (x + xp < maxX && field[y, x + xp] == 1)
                                {
                                    field[y, x + xp] = 2;
                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                    sizeUnknownShip++;
                                }
                                else
                                {
                                    break;
                                }

                            }
                        }


                        if (y + 1 < maxY && field[y + 1, x] == 1)
                        {
                            for (var yp = 0; yp < maxY - y; yp++)
                            {
                                if (y + yp < maxY && field[y + yp, x] == 1)
                                {
                                    field[y + yp, x] = 2;
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    sizeUnknownShip++;
                                }
                                else
                                {
                                    break;
                                }

                            }
                        }


                        if (field[y, x] == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            field[y, x] = 2;
                            sizeUnknownShip++;
                        }

                    }
                    else
                    {
                        if (field[y, x] == 0) Console.ForegroundColor = ConsoleColor.Blue;
                    }


                    if (x == maxX - 1)
                    {
                        Console.Write($"{field[y, x]}");
                        Console.WriteLine(" },");
                    }
                    else
                    {
                        if (x == 0) Console.Write("{ ");
                        Console.Write($"{field[y, x]}, ");
                    }

                    Console.ResetColor();

                    switch (sizeUnknownShip)
                    {
                        case 0: break;
                        case 1:
                            submarines++;
                            break;
                        case 2:
                            destroyers++;
                            break;
                        case 3:
                            cruisers++;
                            break;
                        case 4:
                            battleships++;
                            break;
                        default:
                            Console.WriteLine($"sizeUnknownShip: {sizeUnknownShip}");
                            result = false;
                            break;
                    }

                }

                Console.ResetColor();
            }

            Console.WriteLine();

            if (submarines != 4)
            {
                result = false;
                Console.WriteLine("submarines != 4");
            }
            if (destroyers != 3)
            {
                result = false;
                Console.WriteLine("destroyers != 3");
            }
            if (cruisers != 2)
            {
                result = false;
                Console.WriteLine("cruisers != 2");
            }
            if (battleships != 1)
            {
                result = false;
                Console.WriteLine("battleships != 1");
            }

            Console.WriteLine();
            Console.WriteLine($"maxX: {maxX}");
            Console.WriteLine($"maxY: {maxY}");
            Console.WriteLine($"submarines: {submarines}");
            Console.WriteLine($"destroyers: {destroyers}");
            Console.WriteLine($"cruisers: {cruisers}");
            Console.WriteLine($"battleships: {battleships}");
            Console.WriteLine($"result: {result}");
            Console.WriteLine();

            return result;
        }

    }
}

//Best Practices

//namespace Solution
//{
//    using System;
//    using System.Collections.Generic;
//    using System.Linq;

//    public class BattleShip
//    {
//        public string Type { get; set; }
//        public int Length { get; set; }
//        public int Count { get; set; }
//    }

//    public static class BattleshipField
//    {
//        private static readonly List<BattleShip> Ships = new List<BattleShip>
//        {
//            new BattleShip { Type = "Battleship", Length = 4, Count = 1 },
//            new BattleShip { Type = "Cruiser", Length = 3, Count = 2 },
//            new BattleShip { Type = "Torpedo boat", Length = 2, Count = 3 },
//            new BattleShip { Type = "Submarine", Length = 1, Count = 4 }
//        };

//        public static bool ValidateBattlefield(int[,] battlefield)
//        {
//            // Test number of cells.
//            if (battlefield.Cast<int>().Sum() != Ships.Sum(s => s.Count * s.Length))
//            {
//                return Fail("Wrong number of cells!");
//            }

//            var height = battlefield.GetLength(0);
//            var width = battlefield.GetLength(1);
//            var lengths = new List<int> { 0, 0, 0, 0 };

//            for (var i = 0; i < battlefield.Length; i++)
//            {
//                var y = i % width;
//                var x = (int)Math.Floor((double)i / width);

//                var cell = battlefield[x, y];

//                if (cell == 0)
//                {
//                    // The current cell is 0. Continue with the next cell.
//                    continue;
//                }

//                // The current cell is 1. Validation, go!

//                // Test diagonals
//                if (y < height - 1)
//                {
//                    if (x < width - 1 && battlefield[x + 1, y + 1] == 1)
//                    {
//                        return Fail("Can't have a neighbour to the bottom right");
//                    }

//                    if (x > 0 && battlefield[x - 1, y + 1] == 1)
//                    {
//                        return Fail("Can't have a neighbour to the bottom left!");
//                    }
//                }

//                // Count the ship's length.
//                var hasLeft = x > 0 && battlefield[x - 1, y] == 1;
//                var hasRight = x < width - 1 && battlefield[x + 1, y] == 1;
//                var hasTop = y > 0 && battlefield[x, y - 1] == 1;
//                var hasBottom = y < height - 1 && battlefield[x, y + 1] == 1;

//                if (!new[] { hasLeft, hasRight, hasTop, hasBottom }.Any(b => b))
//                {
//                    lengths[0]++;
//                }
//                else if (!hasLeft && hasRight)
//                {
//                    var length = battlefield.CountShipLength(x, y, true);
//                    lengths[length - 1]++;
//                }
//                else if (!hasTop && hasBottom)
//                {
//                    var length = battlefield.CountShipLength(x, y, false);
//                    lengths[length - 1]++;
//                }
//            }

//            // Validate found ships
//            Console.WriteLine("  Validation succesfull. Counting ships...\n" +
//                              $"  Battleships:   {lengths[3]}\n" +
//                              $"  Cruisers:      {lengths[2]}\n" +
//                              $"  Torpedo boats: {lengths[1]}\n" +
//                              $"  Submarines:    {lengths[0]}");

//            for (var i = 0; i < Ships.Count; i++)
//            {
//                if (lengths[i] != 4 - i)
//                {
//                    return Fail($"Incorrect number of {Ships[i].Type.ToLowerInvariant()}s: {lengths[0]}");
//                }
//            }

//            // All validation passed
//            Console.WriteLine("  Success! This barttlefield is valid!");

//            return true;
//        }

//        /// <summary>
//        /// Fails the test and log a error message.
//        /// </summary>
//        /// <param name="message">The error message.</param>
//        /// <returns></returns>
//        private static bool Fail(string message)
//        {
//            Console.WriteLine($"  Error: {message}");
//            return false;
//        }

//        /// <summary>
//        /// Counts the ship's length for a x / y position on the current battlefield.
//        /// </summary>
//        /// <param name="x">The current x coordinate.</param>
//        /// <param name="y">The current y coordinate.</param>
//        /// <param name="battlefield">The battlefield.</param>
//        /// <param name="isHorizontal">if set to <c>true</c> count the ship in horizontal orientation. Otherwise, count the vertical orientation.</param>
//        /// <returns></returns>
//        private static int CountShipLength(this int[,] battlefield, int x, int y, bool isHorizontal)
//        {
//            var height = battlefield.GetLength(0);
//            var width = battlefield.GetLength(1);
//            var cell = battlefield[x, y];

//            if (cell == 0 || // cell isn't 1, so return 0.
//                isHorizontal && x == width - 1 || // We're at the right edge of the field, don't count further.
//                !isHorizontal && y == height - 1) // We're at the bottom edge of the field, don't count further.
//            {
//                return cell;
//            }

//            // Count the current cell plus a possible neighbour, recursively.
//            return cell +
//                   battlefield.CountShipLength(
//                       isHorizontal ? x + 1 : x,
//                       !isHorizontal ? y + 1 : y,
//                       isHorizontal);
//        }
//    }
//}





//using System.Collections.Generic;
//public class BattleshipField
//{
//    public static bool ValidateBattlefield(int[,] field)
//    {
//        var ships = new List<int>();    
//        for (var x = 0; x < 10; x++)
//        for (var y = 0; y < 10; y++)
//            if (field[x, y] == 1)
//            {
//                var length = 1;
//                while (x + length < 10 && field[x + length, y] == 1)
//                    field[x + length++, y] = 0;
//                while (y + length < 10 && field[x, y + length] == 1)
//                    field[x, y + length++] = 0;          
//                ships.Add(length);          
//            }    
//        ships.Sort();
//        return string.Join("", ships) == "1111222334";
//    }
//}








//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace Solution
//{
//    public class BattleshipSet
//    {
//        public int Cell1 { get; set; }
//        public int Cell2 { get; set; }
//        public int Cell3 { get; set; }
//        public int Cell4 { get; set; }

//        public bool Validate()
//        {
//            return Cell1 == 4 && Cell2 == 3 && Cell3 == 2 && Cell4 == 1;
//        }
//    }

//    public class BattleshipField
//    {
//        private const int N = 10;

//        public static bool ValidateBattlefield(int[,] fld)
//        {
//            var ships = new BattleshipSet();
//            var visitedPts = new HashSet<Tuple<int, int>>();

//            for (int i = 0; i < N; i++)
//            {
//                for (int j = 0; j < N; j++)
//                {
//                    if (!VisitPoint(i, j, fld, ships, visitedPts)) return false;
//                }
//            }

//            return ships.Validate();
//        }

//        private static bool VisitPoint(int i, int j, int[,] fld, BattleshipSet ships, HashSet<Tuple<int, int>> visitedPts)
//        {
//            if (fld[i, j] == 0) return true;
//            var pt = Tuple.Create(i, j);
//            if (visitedPts.Contains(pt)) return true;

//            var shipPts = new HashSet<Tuple<int, int>>() { pt };
//            int horCnt = 1;
//            for (int pi = i; ++pi < N && fld[pi, j] == 1; )
//            {
//                horCnt++;
//                shipPts.Add(Tuple.Create(pi, j));
//            }
//            for (int pi = i; --pi >= 0 && fld[pi, j] == 1; )
//            {
//                horCnt++;
//                shipPts.Add(Tuple.Create(pi, j));
//            }
//            int vertCnt = 1;
//            for (int pj = j; ++pj < N && fld[i, pj] == 1; )
//            {
//                vertCnt++;
//                shipPts.Add(Tuple.Create(i, pj));
//            }
//            for (int pj = j; --pj >= 0 && fld[i, pj] == 1; )
//            {
//                vertCnt++;
//                shipPts.Add(Tuple.Create(i, pj));
//            }

//            if (horCnt > 1 && vertCnt > 1) return false;

//            switch (Math.Max(horCnt, vertCnt))
//            {
//                case 1: ships.Cell1++; break;
//                case 2: ships.Cell2++; break;
//                case 3: ships.Cell3++; break;
//                case 4: ships.Cell4++; break;
//                default: return false;
//            }

//            foreach (var p in shipPts) visitedPts.Add(p);
//            return GetNeighbours(shipPts).All(p => fld[p.Item1, p.Item2] == 0);
//        }

//        private static IEnumerable<Tuple<int, int>> GetNeighbours(ICollection<Tuple<int, int>> shipPts)
//        {
//            foreach (var pt in shipPts)
//            {
//                for (int i = pt.Item1 - 1; i <= pt.Item1 + 1; i++)
//                {
//                    if (i < 0 || i >= N) continue;
//                    for (int j = pt.Item2 - 1; j <= pt.Item2 + 1; j++)
//                    {
//                        if (j < 0 || j >= N) continue;
//                        var ptij = Tuple.Create(i, j);
//                        if (!shipPts.Contains(ptij))
//                            yield return ptij;
//                    }
//                }
//            }
//        }
//    }
//}






