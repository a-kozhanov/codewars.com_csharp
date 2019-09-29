
//https://www.codewars.com/kata/sentence-smash/train/csharp
//https://www.codewars.com/kata/53dc23c68a0c93699800041d/solutions/csharp

//Sentence Smash

//Write a method smash that takes an array of words and smashes them together into a sentence and returns the sentence.
//You can ignore any need to sanitize words or add punctuation, but you should add spaces between each word. Be careful,
//there shouldn't be a space at the beginning or the end of the sentence!

//Example
//Kata.Smash(new string[] {"hello", "world", "this", "is", "great"}) => "hello world this is great";
//Assumptions
//You can assume that you are only given words.
//You cannot assume the size of the array.
//You can assume that you will always get an array.
//What We're Testing
//We're testing basic loops and string manipulation. This is for beginners who are just learning loops and string manipulation.

//Disclaimer
//This is for beginners so we want to test basic loops and string manipulation. Advanced users should easily be able to do this in one line.

namespace CodeWars
{
    public class SentenceSmash
    {
        public static string Smash(string[] words)
        {
            return string.Join(" ", words);
        }


        //public static string Smash(string[] words)
        //{
        //    string str = "";
        //    for (int i = 0; i<words.Length;i++){
        //        str += words[i]+" ";
        //    }
        //    return str.Trim();
        //}


        //public static string Smash(string[] words)
        //{
        //    string s = string.Empty;
        //    foreach(string w in words)
        //        s += " " + w; 
        //    return s.Length == 0 ? "" : s.Substring(1);
        //}



    }
}