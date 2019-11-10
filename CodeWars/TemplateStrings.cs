/*
https://www.codewars.com/kata/template-strings/train/csharp
https://www.codewars.com/kata/55a14f75ceda999ced000048/solutions/csharp

8 kyu
Template Strings

Template Strings, this kata is mainly aimed at the new JS ES6 Update introducing Template Strings
Task
Your task is to return the correct string using the Template String Feature.
Input
Two Strings, no validation is needed.
Output
You must output a string containing the two strings with the word ```' are '```
Reference: https://developer.mozilla.org/en/docs/Web/JavaScript/Reference/template_strings

*/

namespace CodeWars
{
    public class KataTemplateStrings
    {
        public static string TempleStrings(string obj, string feature)
        {
            return $"{obj} are {feature}";
        }
    }
}