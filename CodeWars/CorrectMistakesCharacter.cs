using System;
using System.Collections.Generic;
using System.Text;


//https://www.codewars.com/kata/correct-the-mistakes-of-the-character-recognition-software/train/csharp
//https://www.codewars.com/kata/577bd026df78c19bca0002c0/solutions/csharp

//Correct the mistakes of the character recognition software

//Character recognition software is widely used to digitise printed texts.Thus the texts can be edited, searched and stored on a computer.
//When documents (especially pretty old ones written with a typewriter), are digitised character recognition softwares often make mistakes.
//Your task is correct the errors in the digitised text.You only have to handle the following mistakes:
//S is misinterpreted as 5
//O is misinterpreted as 0
//I is misinterpreted as 1
//The test cases contain numbers only by mistake.

namespace CodeWars
{
    public class CorrectMistakesCharacter
    {
        public static string Correct(string text)
        {
            return text.Replace("5", "S").Replace("0", "O").Replace("1", "I");
        }

        //public static string Correct(string text)
        //{
        //    return new string(text.Select(x =>
        //    {
        //        switch (x)
        //        {
        //            case '0': return 'O';
        //            case '1': return 'I';
        //            case '5': return 'S';
        //            default: return x;
        //        }

        //    }).ToArray());
        //}

        //public static string Correct(string text) => new Regex(@"[501]").Replace(text, m => new Dictionary<string, string>() { { "5", "S" }, { "0", "O" }, { "1", "I" } }[m.Value]);

        //public static string Correct(string text)
        //{
        //    return string.Join("", text.Select(x => x == '5' ? x = 'S' : x == '0' ? x = 'O' : x == '1' ? x = 'I' : x = x).ToArray());
        //}


    }
}
