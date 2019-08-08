using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


//https://www.codewars.com/kata/street-fighter-2-character-selection/csharp
//https://www.codewars.com/kata/5853213063adbd1b9b0000be/solutions/csharp

//** Short Intro**

//Some of you might remember spending afternoons playing Street Fighter 2 in some Arcade back in the 90s or emulating it nowadays with the numerous emulators for retro consoles.

//Can you solve this kata? Suuure-You-Can!

//UPDATE: a new kata's harder version is available here.

//** The Kata**

//You'll have to simulate the video game's character selection screen behaviour, more specifically the selection grid.Such screen looks like this:

//[screen]: https://images.duckduckgo.com/iu/?u=http%3A%2F%2Fwww.fightersgeneration.com%2Fnp5%2Fgm%2Fsf2ce-s2.jpg&f=1
//"Character Selection Screen for Street Fighter 2"


//Selection Grid Layout in text:

//| Ryu  | E.Honda | Blanka  | Guile   | Balrog | Vega    |
//| Ken  | Chun Li | Zangief | Dhalsim | Sagat  | M.Bison |

//** Input**
//the list of game characters in a 2x6 grid;
//the initial position of the selection cursor (top-left is (0,0));
//a list of moves of the selection cursor (which are up, down, left, right);

//** Output **
//the list of characters who have been hovered by the selection cursor after all the moves (ordered and with repetition, all the ones after a move, wether successful or not, see tests);

//** Rules **
//Selection cursor is circular horizontally but not vertically!
//As you might remember from the game, the selection cursor rotates horizontally but not vertically; that means that if I'm in the leftmost and I try to go left again I'll get to the rightmost(examples: from Ryu to Vega, from Ken to M.Bison) and vice versa from rightmost to leftmost.
//Instead, if I try to go further up from the upmost or further down from the downmost, I'll just stay where I am located (examples: you can't go lower than lowest row: Ken, Chun Li, Zangief, Dhalsim, Sagat and M.Bison in the above image; you can't go upper than highest row: Ryu, E.Honda, Blanka, Guile, Balrog and Vega in the above image).

//* *Test * *
//For this easy version the fighters grid layout and the initial position will always be the same in all tests, only the list of moves change.

//* *Notice * *: changing some of the input data might not help you.

//**Examples * *

//1.

//fighters = [
//    ["Ryu", "E.Honda", "Blanka", "Guile", "Balrog", "Vega"],
//    ["Ken", "Chun Li", "Zangief", "Dhalsim", "Sagat", "M.Bison"]
//]
//initial_position = (0,0)
//moves = ['up', 'left', 'right', 'left', 'left']
//then I should get:

//['Ryu', 'Vega', 'Ryu', 'Vega', 'Balrog']
//as the characters I've been hovering with the selection cursor during my moves. Notice: Ryu is the first just because it "fails" the first up See test cases for more examples.

//2.

//fighters = [
//    ["Ryu", "E.Honda", "Blanka", "Guile", "Balrog", "Vega"],
//    ["Ken", "Chun Li", "Zangief", "Dhalsim", "Sagat", "M.Bison"]
//]
//initial_position = (0,0)
//moves = ['right', 'down', 'left', 'left', 'left', 'left', 'right']
//Result:

//['E.Honda', 'Chun Li', 'Ken', 'M.Bison', 'Sagat', 'Dhalsim', 'Sagat']


namespace CodeWars
{
    public class StreetFighter2
    {
        public string[] StreetFighterSelection(string[][] fighters, int[] position, string[] moves)
        {
            //fighters = new string[][]
            //{
            //    new string[] { "Ryu", "E.Honda", "Blanka", "Guile", "Balrog", "Vega" },
            //    new string[] { "Ken", "Chun Li", "Zangief", "Dhalsim", "Sagat", "M.Bison" },
            //};

            //var moves = new string[] { "up", "left", "right", "left", "left" };
            //var expected = new string[] { "Ryu", "Vega", "Ryu", "Vega", "Balrog" };

            //"up", "left", "right", "left", "left"
            //fighters, new int[] { 0, 0 }, moves
            //2x6 grid
            List<(int, int)> positionMove = new List<(int, int)>();

            foreach (var m in moves)
            {
                switch (m)
                {
                    case "up":
                        {
                            if (position[0] == 1) position[0] = 0;
                            Console.WriteLine("up \t{0}:{1}", position[0], position[1]);
                            break;
                        }
                    case "down":
                        {
                            if (position[0] == 0) position[0] = 1;
                            Console.WriteLine("down \t{0}:{1}", position[0], position[1]);
                            break;
                        }
                    //case "right":
                    case "left":
                        {
                            if (position[1] >= 1 && position[1] <= 5) position[1]--;
                            else if (position[1] == 0) position[1] = 5;

                            Console.WriteLine("right \t{0}:{1}", position[0], position[1]);
                            break;
                        }
                    //case "left":
                    case "right":
                        {
                            if (position[1] >= 0 && position[1] <= 4) position[1]++;
                            else if (position[1] == 5) position[1] = 0;

                            Console.WriteLine("left \t{0}:{1}", position[0], position[1]);
                            break;
                        }

                }

                //Console.WriteLine("Add positionMove \t{0}:{1}", position[0], position[1]);
                positionMove.Add((position[0], position[1]));
            }

            //Console.WriteLine();
            var result = new string[moves.Length];

            for (int i = 0; i < positionMove.Count; i++)
            {
                result[i] = fighters[positionMove[i].Item1][positionMove[i].Item2];
                //Console.WriteLine("positionMove \t{0}:{1}", positionMove[i].Item1, positionMove[i].Item2);
            }


            //Console.WriteLine();
            //foreach (var p in positionMove)
            //{
            //    Console.WriteLine("positionMove \t{0}:{1}", p.Item1, p.Item2);
            //    //result.("88jkhk");
            //}

            //Console.WriteLine();
            //foreach (var s in result)
            //{
            //    Console.WriteLine(s);
            //}

            //var moves = new string[] { "up", "left", "right", "left", "left" };
            //var expected = new string[] { "Ryu", "Vega", "Ryu", "Vega", "Balrog" };
            //| Ryu | E.Honda | Blanka | Guile | Balrog | Vega |
            //| Ken | Chun Li | Zangief | Dhalsim | Sagat | M.Bison |

            return result;
        }

        //Best Practices
        //public string[] StreetFighterSelection(string[][] fighters, int[] position, string[] moves)
        //{
        //    var results = new List<string>();
        //    var row = 0;
        //    var col = 0;

        //    foreach (var s in moves)
        //    {
        //        switch (s)
        //        {
        //            case "up":
        //                row -= 1;
        //                break;
        //            case "down":
        //                row += 1;
        //                break;
        //            case "left":
        //                col -= 1;
        //                break;
        //            case "right":
        //                col += 1;
        //                break;
        //        }
        //        if (row < 0) row = 0;
        //        if (row == fighters.Length) row--;
        //        if (col == fighters[0].Length) col = 0;
        //        if (col == -1) col = fighters[0].Length - 1;

        //        results.Add(fighters[row][col]);
        //    }

        //    return results.ToArray();
        //}
    }
}
