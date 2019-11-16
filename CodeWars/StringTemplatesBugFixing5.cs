/*
https://www.codewars.com/kata/string-templates-bug-fixing-number-5/train/csharp
https://www.codewars.com/kata/55c90cad4b0fe31a7200001f/solutions/csharp

8 kyu
String Templates - Bug Fixing #5

Oh no! Timmy hasn't followed instructions very carefully and forgot how to use the new String Template feature, 
Help Timmy with his string template so it works as he expects!
*/

using System;

namespace CodeWars
{
    public class StringTemplatesBugFixing5
    {
        public static string buildString(string[] args)
        {
            return $"I like {string.Join(", ", args)}!";
        }
    }
}