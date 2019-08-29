using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//https://www.codewars.com/kata/exes-and-ohs/train/csharp
//https://www.codewars.com/kata/55908aad6620c066bc00002a/solutions/csharp

//Exes and Ohs

//Check to see if a string has the same amount of 'x's and 'o's.The method must return a boolean and be case insensitive.The string can contain any char.
//Examples input/output:
//XO("ooxx") => true
//XO("xooxx") => false
//XO("ooxXm") => true
//XO("zpzpzpp") => true // when no 'x' and 'o' is present should return true
//XO("zzoo") => false

namespace CodeWars
{
    public class ExesOhs
    {
        public static bool XO(string input)
        {
            var xCount = 0;
            var oCount = 0;

            foreach (var c in input.ToUpper())
            {
                if (c == 'X') xCount++;
                if (c == 'O') oCount++;
            }

            return xCount == oCount;
        }

        //Best Practices
        //public static bool XO(string input)
        //{
        //    return input.ToLower().Count(i => i == 'x') == input.ToLower().Count(i => i == 'o');
        //}

        //public static bool XO(string input) => input.Count("xX".Contains) == input.Count("oO".Contains);

        //public static bool XO(string input)
        //{
        //    int xCounter = 0;
        //    int oCounter = 0;

        //    foreach (Char c in input)
        //    {
        //        if (Char.ToLower(c) == 'x') xCounter++;
        //        else if (Char.ToLower(c) == 'o') oCounter++;
        //    }

        //    return xCounter == oCounter;
        //}


    }
}
