using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;

//https://www.codewars.com/kata/your-order-please/train/csharp
//https://www.codewars.com/kata/55c45be3b2079eccff00010f/solutions/csharp

//Your task is to sort a given string. Each word in the string will contain a single number.This number is the position the word should have in the result.


//Note: Numbers can be from 1 to 9. So 1 will be the first word (not 0).

//If the input string is empty, return an empty string. The words in the input String will only contain valid consecutive numbers.

//Examples
//"is2 Thi1s T4est 3a"  -->  "Thi1s is2 3a T4est"
//"4of Fo1r pe6ople g3ood th5e the2"  -->  "Fo1r the2 g3ood 4of th5e pe6ople"
//""  -->  ""

namespace CodeWars
{
    public class YourOrder
    {
        public static string Order(string words)
        {
            if (string.IsNullOrWhiteSpace(words)) return "";

            var wordDict = new Dictionary<string, int>();

            foreach (var word in words.Split())
            {
                var number = 0;
                string digits = null;

                foreach (var c in word)
                    if (char.IsDigit(c)) digits += c.ToString();

                if (digits != null) number = int.Parse(digits);
                wordDict.Add(word, number);
            }

            return string.Join(" ", wordDict.OrderBy(x => x.Value).Select(x => x.Key).ToList());
        }

        //Best Practices
        //public static string Order(string words)
        //{
        //    if (string.IsNullOrEmpty(words)) return words;
        //    return string.Join(" ", words.Split(' ').OrderBy(s => s.ToList().Find(c => char.IsDigit(c))));
        //}

    }
}
