/*
https://www.codewars.com/kata/54bf85e3d5b56c7a05000cf9/train/csharp
https://www.codewars.com/kata/54bf85e3d5b56c7a05000cf9/solutions/csharp

7 kyu
Testing 1-2-3

Your team is writing a fancy new text editor and you've been tasked with implementing the line numbering.
Write a function which takes a list of strings and returns each line prepended by the correct number.
The numbering starts at 1. The format is n: string. Notice the colon and space in between.

Examples:
number(List<string>()) // => List<string>()
number(List<string>{"a", "b", "c"}) // => ["1: a", "2: b", "3: c"]
*/

using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class Testing123
    {
        public static List<string> Number(List<string> lines)
        {
            return lines.Select((x, i) => $"{i + 1}: {x}").ToList();
        }

        // public static List<string> Number(List<string> lines)
        // {
        //     //your code goes here
        //
        //     for (int i = 0; i < lines.Count; i++)
        //     {
        //         lines[i] = (i+1) + ": " + lines[i];
        //     }
        //     return lines;
        // }


        // public static List<string> Number(List<string> lines) 
        // {
        //     var newLines = new List<string>();
        //
        //     var i = 1;
        //
        //     foreach (var l in lines)
        //     {
        //         newLines.Add($"{i++}: {l}");
        //     }
        //
        //     return newLines;
        // }


        // public static List<string> Number(List<string> lines) 
        // {
        //     int i = 0;
        //     return lines.Select(x => ++i + ": " + x).ToList();
        // }


        // public static List<string> Number(List<string> lines) 
        // {
        //     List<string> answerList = new List<string>();         //create a new list to house answer
        //
        //     for (int i=0; i<lines.Count; i++){                    //loop through all elements of input List "lines"
        //         answerList.Add((i+1).ToString() + ": " + lines[i]); //add index number, colon, and letter to new list
        //     }
        //     return answerList;
        // }


        // public static List<string> Number(List<string> lines)
        // {
        //     for (int i = 0; i < lines.Count; i++)
        //     {
        //         lines[i] = $"{i + 1}: {lines[i]}";
        //     }
        //
        //     return lines;
        // }
    }
}