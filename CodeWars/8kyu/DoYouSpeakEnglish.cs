/*
https://www.codewars.com/kata/58dbdccee5ee8fa2f9000058/csharp

8 kyu
Do you speak "English"?

Given a string of arbitrary length with any ascii characters. 
Write a function to determine whether the string contains the whole word "English".
The order of characters is important -- a string "abcEnglishdef" is correct but "abcnEglishsef" is not correct.
Upper or lower case letter does not matter -- "eNglisH" is also correct.
Return value as boolean values, true for the string to contains "English", false for it does not.
*/

using System.Text.RegularExpressions;

namespace CodeWars
{
    public class DoYouSpeakEnglish
    {
        public static bool SpeakEnglish(string sentence)
        {
            return Regex.IsMatch(sentence, "(?i)english");
            // return sentence.ToLower().Contains("english");
            // return new Regex("(?i)English").IsMatch(sentence);
            // return sentence.ToLower().IndexOf("english") != -1;
            // return Regex.Match(sentence, "(?i)english").Success;
        }
    }
}