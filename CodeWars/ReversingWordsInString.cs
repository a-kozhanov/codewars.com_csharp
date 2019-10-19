
//https://www.codewars.com/kata/reversing-words-in-a-string/train/csharp
//https://www.codewars.com/kata/57a55c8b72292d057b000594/solutions/csharp

//8 kyu
//Reversing Words in a String

//You need to write a function that reverses the words in a given string. A word can also fit an empty string. If this is not clear enough, here are some examples:

//As the input may have trailing spaces, you will also need to ignore unneccesary whitespace.

//Kata.Reverse("Hello World"); // -> "World Hello"
//Kata.Reverse("Hi There."); // -> "There. Hi"
//Happy coding!

using System;
using System.Linq;

namespace CodeWars
{
    public class ReversingWordsInString
    {
        public static string Reverse(string text)
        {
            return string.Join(" ", text.Split().Reverse());
        }

        //public static string Reverse(string text)
        //{
        //    return String.Join(" ", text.Split(' ').Reverse());
        //}


        //public static string Reverse(string text)
        //{
        //    return string.Join(" ",text.Split(' ').Reverse().ToArray());
        //}

        //public static string Reverse(string text)
        //{
        //    return string.Join(" ", text.Split(' ').Reverse());
        //}

        //public static string Reverse(string text)
        //{
        //    return text.Split(' ').Reverse().Aggregate((first, second) => first + " " + second);
        //}

        //public static string Reverse(string text)
        //{
        //    string[] sArr = text.Split(' ');
        //    Array.Reverse(sArr);

        //    return string.Join(" ", sArr);
        //}


        //public static string Reverse(string text)
        //{
        //    var arr = text.Split(' ');
        //    var reversed = String.Join(" ", arr.Reverse());
        //    return reversed;
        //}


        //public static string Reverse(string text)
        //{
        //    var reverse = string.Join(" ", text.Split(' ').Reverse());
        //    return reverse;
        //}


        //public static string Reverse(string text)
        //{
        //    return String.Join(' ',text.Split(new char[]{' '}).Reverse());
        //}



    }
}