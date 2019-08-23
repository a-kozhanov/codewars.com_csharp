using System;
using System.Collections.Generic;
using System.Linq;

//https://www.codewars.com/kata/mexican-wave/train/csharp
//https://www.codewars.com/kata/58f5c63f1e26ecda7e000029/solutions/csharp

//Task
//In this simple Kata your task is to create a function that turns a string into a Mexican Wave.
//You will be passed a string and you must return that string in an array where an uppercase letter is a person standing up.

//Rules
//1.  The input string will always be lower case but maybe empty.
//2.  If the character in the string is whitespace then pass over it as if it was an empty seat.

//Example
//wave("hello") => []string{ "Hello", "hEllo", "heLlo", "helLo", "hellO"}


namespace CodeWars
{
    public class MexicanWave
    {
        public List<string> wave(string str)
        {
            var listWord = new List<string>();

            for (var i = 0; i < str.Length; i++)
            {
                var charArray = str.ToCharArray();
                charArray[i] = char.ToUpper(charArray[i]);
                if (charArray[i] != ' ')
                    listWord.Add(new string(charArray));
            }

            return listWord;
        }

        //Best Practices
        public List<string> wave2(string str) =>
            str
                .Select((c, i) => str.Substring(0, i) + Char.ToUpper(c) + str.Substring(i + 1))
                .Where(x => x != str)
                .ToList();

        //Best Practices
        public List<string> wave3(string str)
        {
            List<string> waveList = new List<string>();
            for (int i = 0; i < str.Length; i++)
            {
                char[] c = str.ToCharArray();
                if (c[i] != ' ')
                {
                    c[i] = Char.ToUpper(c[i]);
                    waveList.Add(new string(c));
                }
            }
            return waveList;
        }

        //Best Practices
        public List<string> wave4(string s)
        {
            return Enumerable.Range(0, s.Length)
                .Select(i => string.Concat(s.Select((x, y) => y == i ? char.ToUpper(x) : x)))
                .Where(x => x != s).ToList();
        }

        //Best Practices
        public List<string> wave5(string str)
        {
            return new List<string>(Enumerable.Range(0, str.Length).Where(index => str[index] != ' ').Select(index => new string(str.Select((ch, i) => index == i ? char.ToUpper(ch) : ch).ToArray())));
        }

    }
}