using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text.RegularExpressions;
using CodeWars;

namespace ConsoleTestApp
{
    class Program
    {

        static void Main(string[] args)
        {
            int[,] field1 = new int[10, 10]
            {
                {1, 0, 0, 0, 0, 1, 1, 0, 0, 0},
                {1, 0, 1, 0, 0, 0, 0, 0, 1, 0},
                {1, 0, 1, 0, 1, 1, 1, 0, 1, 0},
                {1, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 1, 0},
                {0, 0, 0, 0, 1, 1, 1, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 1, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 1, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 1}
            };


            int[,] field2 = new int[10, 10]
            {
                {1, 0, 0, 0, 0, 1, 1, 0, 0, 0},
                {1, 0, 1, 0, 0, 0, 0, 0, 1, 0},
                {1, 0, 1, 0, 1, 1, 1, 0, 1, 0},
                {1, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 1, 0},
                {0, 0, 0, 0, 1, 1, 1, 0, 0, 0},
                {0, 0, 0, 1, 0, 0, 0, 0, 1, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 1, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
            };

            int[,] field3 = new int[10, 10]
            {
                { 1, 0, 0, 0, 0, 1, 1, 0, 0, 0 },
                { 1, 0, 1, 0, 0, 0, 0, 0, 1, 0 },
                { 1, 0, 1, 0, 1, 1, 1, 0, 1, 0 },
                { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 1, 0 },
                { 0, 0, 0, 0, 1, 1, 1, 0, 0, 0 },
                { 0, 0, 0, 1, 0, 0, 0, 0, 1, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 1, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }
            };



            int[,] field = new int[10, 10]
            {
                { 0, 1, 0, 0, 0, 1, 1, 0, 0, 0 },
                { 1, 1, 0, 0, 0, 0, 0, 0, 1, 0 },
                { 0, 0, 0, 0, 1, 1, 1, 0, 1, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 1, 0 },
                { 0, 0, 0, 0, 1, 1, 1, 0, 0, 0 },
                { 1, 0, 0, 1, 0, 0, 0, 0, 1, 0 },
                { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0 }
            };



            ValidateBattlefield(field);
        }

        public static bool ValidateBattlefield(int[,] field)
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

                    //for (var y1 = 0; y1 < maxY; y1++)
                    //{
                    //    for (var x1 = 0; x1 < maxX; x1++)
                    //    {
                    //        if (field[y1, x1] == -1)
                    //        {
                    //            field[y1, x1] = sizeUnknownShip;
                    //        }
                    //    }
                    //}


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
