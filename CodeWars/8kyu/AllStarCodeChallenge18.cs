

//https://www.codewars.com/kata/all-star-code-challenge-number-18/train/csharp
//https://www.codewars.com/kata/5865918c6b569962950002a1/solutions/csharp

//All Star Code Challenge #18
//8 kyu


//This Kata is intended as a small challenge for my students
//All Star Code Challenge #18
//Create a function called that accepts 2 string arguments and returns an integer of the count of occurrences the 2nd argument is found in the first one.
//If no occurrences can be found, a count of 0 should be returned.
//strCount('Hello', 'o') // => 1
//strCount('Hello', 'l') // => 2
//strCount('', 'z')      // => 0
//Notes:
//The first argument can be an empty string
//The second string argument will always be of length 1

using System;
using System.Linq;
using System.Text.RegularExpressions;


namespace CodeWars
{
    public class AllStarCodeChallenge18
    {
        public static int StrCount(string str, string letter)
        {
            return str.Count(c => c == letter[0]);
        }


        //public static int StrCount(string str, string letter) => str.Count(x => x.ToString() == letter);


        //public static int StrCount(string str, string letter)
        //{
        //    int count = 0;
        //    foreach(char c in str)
        //    {
        //        if(c.ToString() == letter) count++;
        //    }
        //    return count;

        //}


        //public static int StrCount(string str, string letter)
        //{    
        //    return str.Count(c => c == Convert.ToChar(letter) );
        //}


        //public static int StrCount(string str, string letter)
        //{
        //    return Regex.Matches(str,letter).Count;
        //}


        //public static int StrCount(string str, string letter)
        //{
        //    return str.Split(letter).Length - 1;
        //}


        //public static int StrCount(string str, string letter) => str.Where(o => o == char.Parse(letter)).Count();


        //public static int StrCount(string str, string letter)
        //{
        //    return str.Count(c => c == letter.First());
        //}


        //public static int StrCount(string str, string letter)
        //{
        //    return str.Where(e=> e == letter.First()).Count();
        //}



    }
}