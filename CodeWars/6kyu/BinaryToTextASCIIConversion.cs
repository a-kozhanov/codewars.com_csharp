/*
https://www.codewars.com/kata/5583d268479559400d000064/train/csharp

6 kyu
Binary to Text (ASCII) Conversion

Write a function that takes in a binary string and returns the equivalent decoded text (the text is ASCII encoded).

Each 8 bits on the binary string represent 1 character on the ASCII table.

The input string will always be a valid binary string.

Characters can be in the range from "00000000" to "11111111" (inclusive)

Note: In the case of an empty binary string your function should return an empty string.
*/

using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public static class BinaryToTextASCIIConversion
    {
        public static string BinaryToString(string binary)
        {
            return string.Concat(Regex.Matches(binary, ".{8}").Select(m => (char) Convert.ToByte(m.Value, 2)));

            //return string.Concat(Regex.Split(binary, "(.{8})").Where(x => x != "").Select(x => (char) Convert.ToInt32(x, 2)));
            //return string.Concat(Regex.Split(binary, "(.{8})").Where(x => x != "").Select(x => (char) Convert.ToByte(x, 2)));

            //return string.Concat(Enumerable.Range(0, binary.Length / 8).Select(i => (char) Convert.ToByte(binary[(i * 8)..(i * 8 + 8)], 2)));

            //return Encoding.ASCII.GetString(Enumerable.Range(0, binary.Length / 8).Select(i => Convert.ToByte(binary.Substring(8 * i, 8), 2)).ToArray());

            //return Regex.Matches(binary, "[01]{8}").Select(m => (char) Convert.ToInt32(m.Value, 2)).Aggregate(string.Empty, (a, b) => a + b);

            //return string.Concat(Enumerable.Range(0, binary.Length).Where(w => w % 8 == 0).Select(s => (char) Convert.ToInt32(binary[s..(s + 8)], 2)).ToArray());

            //return Regex.Replace(binary, "[0-1]{8}", match => { return new string(Encoding.ASCII.GetChars(new[] {Convert.ToByte(match.Value, 2)})); });

            // return string.Concat(binary.Select((c, i) => i).Where(i => i % 8 == 0)
            //     .Select(i => binary.Substring(i, binary.Length - i >= 8 ? 8 : binary.Length - i))
            //     .Select(s => (char) Convert.ToByte(s, 2)));

            // return Encoding.ASCII.GetString(Enumerable.Range(0, binary.Length / 8)
            //     .Select(i => binary.Substring(i * 8, 8))
            //     .Select(s => Convert.ToByte(s, 2)).ToArray());
        }
    }
}