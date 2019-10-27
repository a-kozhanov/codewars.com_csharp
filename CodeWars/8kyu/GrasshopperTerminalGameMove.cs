using System;

//https://www.codewars.com/kata/grasshopper-terminal-game-move-function/train/csharp
//

//Grasshopper - Terminal game move function

//Terminal game move function
//In this game, the hero moves from left to right.The player rolls the dice and moves the number of spaces indicated by the dice two times.
//Create a function for the terminal game that takes the current position of the hero and the roll (1-6) and return the new position.
//Example:
//move(3, 6) should equal 15


namespace CodeWars
{
    public class GrasshopperTerminalGameMove
    {
        public static int Move(int position, int roll)
        {
            return position + roll * 2;
        }

        //public static int Move(int position, int roll) => position + roll * 2;

        //public static int Move(int position, int roll)
        //{
        //    return (roll + roll) + position;
        //}

        //public static int Move(int position, int roll)
        //{
        //    return (roll + roll) + position;
        //}
    }
}