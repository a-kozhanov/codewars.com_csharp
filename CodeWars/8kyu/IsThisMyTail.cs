

//https://www.codewars.com/kata/is-this-my-tail/train/csharp
//https://www.codewars.com/kata/56f695399400f5d9ef000af5/solutions/csharp

//Is this my tail?

//Some new animals have arrived at the zoo. The zoo keeper is concerned that perhaps the animals do not have the right tails.
//To help her, you must correct the broken function to make sure that the second argument (tail),
//is the same as the last letter of the first argument (body) - otherwise the tail wouldn't fit!
//If the tail is right return true, else return false.
//The arguments will always be strings, and normal letters.
//For Haskell, body has the type of String and tail has the type of Char. For Go, body has type string and tail has type rune.

using System;
using System.Linq;

namespace CodeWars
{
    public class IsThisMyTail
    {
        public static bool CorrectTail(string body, string tail)
        {
            return tail == body.Substring(body.Length - tail.Length);
        }

        //public static bool CorrectTail(string body, string tail)
        //{
        //    return body.EndsWith(tail);
        //}


        //public static bool CorrectTail(string body, string tail)
        //{
        //    return body.Last() == tail.FirstOrDefault();
        //}


        //public static bool CorrectTail(string body, string tail)
        //{
        //    return body[body.Length - 1] == tail[tail.Length - 1];
        //}


        //public static bool CorrectTail(string body, string tail) => body[body.Length - 1] == Convert.ToChar(tail);


        //public static bool CorrectTail(string body, string tail)
        //{
        //    return (body[body.Length - 1].ToString() == tail);
        //}


        //public static bool CorrectTail(string body, string tail) => Convert.ToChar(tail) == body.Last();


        //public static bool CorrectTail(string body, string tail)
        //{
        //    return tail[0] == body[body.Length - 1];
        //}

        //public static bool CorrectTail(string body, string tail)
        //{
        //    return body.LastOrDefault().ToString() == tail;
        //}

        //public static bool CorrectTail(string body, string tail)
        //{
        //    return body.Last() == tail[0];
        //}

    }
}