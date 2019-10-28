/*
https://www.codewars.com/kata/character-frequency-2/train/csharp


8 kyu
Character Frequency

Description
Welcome, Warrior! In this kata, you will get a message and you will need to get the frequency of each and every character!

Explanation
Your function will be called char_freq/charFreq/CharFreq and you will get passed a string, 
you will then return a dictionary (object in JavaScript) with as keys the characters, 
and as values how many times that character is in the string. You can assume you will be given valid input.

Example
CharFreq("I like cats") => new Dictionary<char, int> {{'a', 1}, {' ', 2}, {'c', 1}, {'e', 1}, {'I', 1}, {'k', 1}, {'l', 1}, {'i', 1}, {'s', 1}, {'t', 1}}

*/

using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class CharacterFrequency
    {
        public static Dictionary<char, int> CharFreq(string message)
        {
            var result = new Dictionary<char, int>();
            foreach (var ch in message)
                if (result.ContainsKey(ch))
                    result[ch]++;
                else
                    result.Add(ch, 1);
            return result;
        }
    }
}