/*
https://www.codewars.com/kata/grasshopper-if-slash-else-syntax-debug/train/csharp
https://www.codewars.com/kata/57089707fe2d01529f00024a/solutions/csharp

8 kyu
Grasshopper - If/else syntax debug

If/else syntax debug
While making a game, your partner, Greg, decided to create a function to check if the user is still alive called checkAlive/CheckAlive. 
Unfortunately, Greg made some errors while creating the function.

checkAlive/CheckAlive should return true if the player's health is greater than 0 or false if it is 0 or below.
*/

namespace CodeWars
{
    public class GrasshopperIfElseSyntaxDebug
    {
        public int Health { get; set; } = 100;
        public bool CheckAlive() => Health > 0;
    }

}