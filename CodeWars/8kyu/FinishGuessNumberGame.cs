/*
https://www.codewars.com/kata/finish-guess-the-number-game/csharp

8 kyu
Finish Guess the Number Game

Imagine you are creating a game where the user has to guess the correct number. But there is a limit of how many guesses the user can do.

If the user tries to guess WRONG more than the limit the function should throw an error
If the user guess wrong it should lose a life and return false (if you guess correctly you shouldn't remove a life)
If the user guess right it should return true
Can you finish the game so all the rules are met?
*/

using System;

namespace CodeWars
{
    public class FinishGuessNumberGame
    {
        private int _lives;
        public int Number { get; }

        private int Lives => _lives--;

        //public Guesser(int number, int lives)
        public FinishGuessNumberGame(int number, int lives)
        {
            Number = number;
            _lives = lives;
        }

        public bool Guess(int n)
        {
            if (Lives <= 0) throw new Exception("WRONG");
            if (Number == n) return true;
            //Lives--;
            return false;
        }
    }
}



//using System;

//public class Guesser
//{
//    private int Number;
//    private int Lives;

//    public Guesser(int number, int lives)
//    {
//        Number = number;
//        Lives = lives;
//    }

//    public bool Guess(int n)
//    {
//        if (Lives < 1) throw new Exception("You gone!");

//        if (n == Number) return true;

//        --Lives;
//        return false;
//    }
//}


//using System;

//public class Guesser
//{
//    private Int32 _number;
//    private Int32 _lives;

//    public Guesser(Int32 Number, Int32 Lives)
//    {
//        _number = Number;
//        _lives = Lives;
//    }

//    public Boolean Guess(Int32 Guess)
//    {
//        if (_lives <= 0)
//        {
//            throw new Exception();
//        }
//        return (Guess == _number) || (_lives-- == _lives);
//    }
//}