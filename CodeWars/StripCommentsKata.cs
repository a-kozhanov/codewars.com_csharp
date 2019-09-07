
//https://www.codewars.com/kata/strip-comments/train/csharp
//https://www.codewars.com/kata/51c8e37cee245da6b40000bd/solutions/csharp

//Strip Comments

//Complete the solution so that it strips all text that follows any of a set of comment markers passed in. Any whitespace at the end of the line should also be stripped out.

//Example:

//Given an input string of:

//apples, pears # and bananas
//grapes
//bananas !apples
//The output expected would be:

//apples, pears
//grapes
//bananas
//The code would be called like so:

//string stripped = Strip.StripComments("apples, pears # and bananas\ngrapes\nbananas !apples", ["#", "!"])
//// result should == "apples, pears\ngrapes\nbananas"

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class StripCommentsKata
    {
        public static string StripComments(string text, string[] commentSymbols)
        {
            var lines = text.Split("\n");

            foreach (var symbol in commentSymbols)
                for (var i = 0; i < lines.Length; i++)
                {
                    var pos = lines[i].IndexOf(symbol);
                    if (pos > -1) lines[i] = lines[i].Remove(pos);
                    lines[i] = lines[i].TrimEnd();
                }

            return string.Join("\n", lines);
        }



        //public static string StripComments(string text, string[] commentSymbols)
        //{
        //    var texts = text.Split('\n');
        //    var sb = new StringBuilder();

        //    foreach (var t in texts)
        //    {
        //        int len = commentSymbols.Select(s => t.IndexOf(s)).Where(i => 0 <= i).Append(t.Length).Min();
        //        sb.Append(t.Substring(0, len).TrimEnd() + "\n");
        //    }

        //    return sb.ToString(0, sb.Length - 1);
        //}


        //public static string StripComments(string text, string[] commentSymbols)
        //{
        //    string[] textArr = text.Split('\n');

        //    //iterate over text lines
        //    for (int i = 0; i < textArr.Length; i++)
        //    {
        //        for (int c = 0; c < textArr[i].Length; c++)
        //        {
        //            //strip the comment from the line
        //            if (commentSymbols.Contains(textArr[i][c].ToString()))
        //            {
        //                textArr[i] = textArr[i].Substring(0, c);
        //            }
        //        }
        //        //remove white space from end of the line
        //        textArr[i] = textArr[i].TrimEnd();
        //    }

        //    return string.Join('\n', textArr);
        //}



        //public static string StripComments(string text, string[] commentSymbols)
        //{
        //    string pattern = string.Format("[{0}].*?(\\n+?|$)", string.Join("", commentSymbols));
        //    return Regex.Replace(text, pattern, "$1").Replace(" \n", "\n").TrimEnd(' ');
        //}


        //public static string StripComments(string text, string[] commentSymbols)
        //{
        //    var pattern = $"[ ]*([{string.Concat(commentSymbols)}].*)?$";
        //    return string.Join("\n", text.Split('\n').Select(x => Regex.Replace(x, pattern, "")));
        //}


        //public static string StripComments(string text, string[] commentSymbols)
        //{
        //    var lines = text.Split('\n');
        //    string res = "";
        //    foreach (var line in lines)
        //    {
        //        string tmp = line;
        //        for (int i = 0; i < commentSymbols.Length; i++)
        //        {
        //            tmp = tmp.Split(commentSymbols[i])[0];
        //        }
        //        res += $"{tmp.TrimEnd()}\n";
        //    }
        //    return res.Remove(res.Length - 1);
        //}


        //public static string StripComments(string text, string[] commentSymbols)
        //{
        //    return string.Join('\n', text.Split('\n').Select(l => string.Concat(l.TakeWhile(c => !commentSymbols.Contains(c.ToString()))).TrimEnd(' ')));
        //}


        //public static string StripComments(string text, string[] commentSymbols)
        //{
        //    var commentChars = commentSymbols.SelectMany(s => s.Select(c => c)).ToArray();
        //    var list = new List<string>();
        //    foreach (var line in text.Split('\n'))
        //    {
        //        var index = line.IndexOfAny(commentChars);
        //        if (index == -1)
        //            list.Add(line.TrimEnd());
        //        else
        //            list.Add(line.Substring(0, index).TrimEnd());
        //    }
        //    return string.Join("\n", list);
        //}


        //public static string StripComments(string text, string[] commentSymbols)
        //{
        //    var splitted = text.Split(new char[] { '\n' })
        //        .Select(str =>
        //        {
        //            foreach (var commSymb in commentSymbols)
        //                if (str.Contains(commSymb))
        //                    str = str.Remove(str.IndexOf(commSymb));

        //            return str.TrimEnd();
        //        });

        //    return string.Join('\n', splitted);
        //}


        //public static string StripComments(string text, string[] commentSymbols) =>
        //    string.Join("\n", text.Split('\n').Select(it =>
        //    {
        //        foreach (var sep in commentSymbols)
        //        {
        //            if (it.Contains(sep)) return it.Split(sep)[0].TrimEnd(); ;
        //        }
        //        return it.TrimEnd(); ;

        //    }));


        //public static string StripComments(string text, string[] commentSymbols)
        //{
        //    return Regex.Replace(text, $" *[{string.Join("", commentSymbols)}]+.*| +(\\n)| +$", "$1");
        //}

        //public static string StripComments(string text, string[] commentSymbols)
        //{
        //    return text.Split("\n")
        //        .Select(s => { foreach (string com in commentSymbols) s = s.Split(com)[0]; return s.TrimEnd(); })
        //        .Aggregate((a, b) => a + Environment.NewLine + b);
        //}

        //public static string StripComments(string text, string[] commentSymbols)
        //{
        //    char[] comChars = commentSymbols.Select(s => s[0]).ToArray();
        //    return string.Join("\n", text.Split('\n')
        //        .Select(x => x.IndexOfAny(comChars) >= 0 ? x.Substring(0, x.IndexOfAny(comChars)) : x)
        //        .Select(x => x.TrimEnd(comChars).TrimEnd()));
        //}


        //public static string StripComments(string text, string[] commentSymbols)
        //{
        //    var charArray = commentSymbols.Select(s => s.ToCharArray().First()).ToArray();
        //    var list = text.Split('\n').ToList().Select(s =>
        //    {
        //        var index = s.IndexOfAny(charArray);
        //        return index != -1 ? s.Remove(index).TrimEnd(' ') : s.TrimEnd(' ');
        //    });
        //    return string.Join("\n", list);
        //}


        //public static string StripComments(string text, string[] commentSymbols)
        //{
        //    return string.Join("\n", text.Split('\n')
        //        .Select(x =>
        //            x.IndexOfAny(string.Join("", commentSymbols).ToCharArray()) != -1
        //                ? x.Remove(x.IndexOfAny(string.Join("", commentSymbols).ToCharArray())).Trim()
        //                : x.TrimEnd()));
        //}

    }
}