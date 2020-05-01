/*
https://www.codewars.com/kata/53369039d7ab3ac506000467/train/csharp

8 kyu
Convert boolean values to strings 'Yes' or 'No'.

Complete the method that takes a boolean value and return a "Yes" string for true, or a "No" string for false.
*/


namespace CodeWars
{
    public class ConvertBooleanValuesToString
    {
        public static string boolToWord(bool word)
        {
            return word ? "Yes" : "No";
        }
    }
}