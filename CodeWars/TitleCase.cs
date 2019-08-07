using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

//https://www.codewars.com/kata/title-case/train/csharp
//

//A string is considered to be in title case if each word in the string is either(a)
//capitalised(that is, only the first letter of the word is in upper case) or(b) considered
//to be an exception and put entirely into lower case unless it is the first word, which is always capitalised.

//Write a function that will convert a string into title case, given an optional list of
//exceptions (minor words). The list of minor words will be given as a string with each
//word separated by a space. Your function should ignore the case of the minor words
//string -- it should behave in the same way even if the case of the minor word string is changed.

//###Arguments (Haskell)
//First argument: space-delimited list of minor words that must always be lowercase except for the first word in the string.
//Second argument: the original string to be converted.

//###Arguments (Other languages)
//First argument (required): the original string to be converted.
//Second argument (optional): space-delimited list of minor words that must always be lowercase except
//for the first word in the string. The JavaScript/CoffeeScript tests will pass undefined when this argument is unused.

//###Example
//Kata.TitleCase("a an the of", "a clash of KINGS") => "A Clash of Kings"
//Kata.TitleCase("The In", "THE WIND IN THE WILLOWS") => "The Wind in the Willows"
//Kata.TitleCase("the quick brown fox")               => "The Quick Brown Fox"

namespace CodeWars
{
    public static class TitleCase
    {
        public static string titleCase(string title, string minorWords = "")
        {
            if (string.IsNullOrWhiteSpace(minorWords))
            {
                //Console.WriteLine(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(title.ToLower()));
                //string s = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(title.ToLower());
                return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(title.ToLower());
            }

            //Console.WriteLine(title);
            string result = "";

            foreach (var m in minorWords.Split(' '))
            {
                string s = "";
                foreach (var t in title.Split(' '))
                {
                    Console.WriteLine("{0} : {1} \t\t\t {2}", m, t, String.Equals(m, t, StringComparison.CurrentCultureIgnoreCase));
                    //if (String.Compare(m,t)) (m.Equals(t)) Console.WriteLine("{0}: {1}", t, m);
                    if (!String.Equals(m, t, StringComparison.CurrentCultureIgnoreCase))
                    {
                        //result += m.ToLower() + ' ';
                        s = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(m.ToLower());
                    }
                    //else
                    //{
                    //    result += CultureInfo.CurrentCulture.TextInfo.ToTitleCase(m.ToLower()) + ' ';
                    //}
                }
                result += s + ' ';
            }

            //string s = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(title.ToLower());
            //string s = title.ToLower();
            //char c = s[0];

            return result;
        }
    }
}
