/*
https://www.codewars.com/kata/56d9292cc11bcc3629000533/train/csharp
https://www.codewars.com/kata/56d9292cc11bcc3629000533/solutions/csharp

7 kyu
Thinking & Testing : Incomplete string

No Story
No Description
Only by Thinking and Testing
Look at result of testcase, guess the code!
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using static System.Text.RegularExpressions.Regex;

namespace CodeWars
{
    public class ThinkingTestingIncompleteString
    {
        public string Testit(string s)
        {

            // return Replace(s, "..",
            //     m => ((char)((m.ToString().FirstOrDefault() + m.ToString().Skip(1).FirstOrDefault()) / 2))
            //         .ToString());


            return Replace(s, "..", m => $"{(char)((m.Value[0] + m.Value[1]) / 2)}");
        }


        // public string Testit(string s)
        // {
        //     string modstring = "";
        //     for (int i = 0; i < s.Length; i += 2)
        //     {
        //         char meanChar = s[i];
        //         if ((i + 1) < s.Length)
        //         {
        //             meanChar = (char)(((int)meanChar + (int)s[i + 1]) / 2);
        //         }
        //         modstring += meanChar;
        //     }
        //
        //     return modstring;
        // }


        // public string Testit(string s)
        // {
        //     var result = "";
        //     for (var index = 0; index < s.Length; index += 2)
        //     {
        //         result += (index + 1 < s.Length) ? ((char)((s[index] + s[index + 1]) / 2)) : s[index];
        //     }
        //     return result;
        // }


        // public string Testit(string s)
        // {
        //     if (s.Length < 2) return s;
        //     return string.Concat((char)((s[0] + s[1]) / 2), Testit(s.Substring(2)));
        // }


        // public string Testit(string s)
        // {
        //     string x = "";
        //     for (int i = 0; i < s.Length; i += 2)
        //         x += i + 1 < s.Length ? (char)((s[i] + s[i + 1]) / 2) : s[i];
        //     return x;
        // }


        // public string Testit(string s) => string.Concat(string.Concat(Enumerable.Range(0, s.Length / 2).Select(x => (char)((s[x * 2] + s[x * 2 + 1]) / 2))), s.Length % 2 == 1 ? s[s.Length - 1].ToString() : "");


        // public string Testit(string s)
        // {
        //     string s2 = "";
        //     for (int i = 0; i < s.Length; i += 2)
        //     {
        //         if (i + 1 >= s.Length) s2 += s[i];
        //         else s2 += (char)((s[i] + s[i + 1]) / 2);
        //     }
        //     return s2;
        // }


        // public string Testit(string s)
        // {
        //     string s2 = "";
        //     for (int i = 0; i < s.Length; i += 2)
        //     {
        //         if (i + 1 >= s.Length)
        //         {
        //             s2 += s[i];
        //         }
        //         else
        //         {
        //             s2 += (char)((s[i] + s[i + 1]) / 2);
        //         }
        //     }
        //
        //     return s2;
        // }


        // public string Testit(string s)
        // {
        //     List<char> resultString = new List<char>();
        //
        //     for (var indexChar = 0; indexChar < s.Length - 1; indexChar += 2)
        //     {
        //         resultString.Add(Convert.ToChar((s[indexChar] + s[indexChar + 1]) / 2));
        //     }
        //
        //     if (s.Length % 2 == 1)
        //         resultString.Add(s[s.Length - 1]);
        //
        //     return new string(resultString.ToArray());
        // }


        // public string Testit(string s)
        // {
        //     var res = "";
        //     for (var i = 0; i < s.Length; i += 2)
        //     {
        //         var c = s[i];
        //         if ((i + 1) < s.Length)
        //             c = (char)((c + s[i + 1]) / 2);
        //         res += c;
        //     }
        //     return res;
        // }


        // public string Testit(string s)
        // {
        //     var sb = new StringBuilder(s.Length / 2);
        //     for (int i = 0; i < s.Length; i += 2)
        //     {
        //         if (i == s.Length - 1)
        //         {
        //             sb.Append(s[i]);
        //         }
        //         else
        //         {
        //             sb.Append((char)((s[i] + s[i + 1]) / 2));
        //         }
        //     }
        //     return sb.ToString();
        // }


        // public string Testit(string s)
        // {
        //     if (s.Length > 0)
        //         s += s[s.Length - 1];
        //     return string.Concat<char>(Enumerable.Range(0, s.Length / 2).Select(_ => (char)((s[_ * 2] + s[_ * 2 + 1]) / 2)));
        // }



        // public string Testit(string s)
        // {
        //
        //     return string.Join("", s.Select((v, index) => index < s.Length - 1 ? index % 2 == 0 ? ((char)(((int)s[index] + (int)s[index + 1]) / 2)).ToString() : "" : s.Length % 2 == 0 ? "" : v.ToString()).ToArray());
        // }


        // public string Testit(string s)
        // {
        //
        //     string res = "";
        //     for (int i = 0; i < s.Length; i += 2)
        //     {
        //         char str = s[i];
        //         if ((i + 1) < s.Length)
        //         {
        //             str = (char)(((int)str + (int)s[i + 1]) / 2);
        //         }
        //         res = res + str;
        //     }
        //     return res;
        // }


        // public string Testit(string s)
        // {
        //     var awesome_tesla = "";
        //     for (int i = 0; i < s.Length; i += 2)
        //         awesome_tesla += i == s.Length - 1 ? s[i] : (char)((s[i] + s[i + 1]) / 2);
        //     return awesome_tesla;
        // }


    }
}