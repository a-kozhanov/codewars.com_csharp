/*
https://www.codewars.com/kata/5830195755f28edad4000081/csharp

7 kyu
Get row from alphabetical sequence

Description:
Given the sequence below, complete the GetRow function, so that the output matches n row given as argument. 
If the argument is bigger than the number of rows in the sequence, 
then start from the beginning again, eg. row 27 is the same as row 1.

Example:
row 1 => ABCDEFGHIJKLMNOPQRSTUVWXYZ
row 15 => OOOOOOOOOOOOOOOPQRSTUVWXYZ
row 26 => ZZZZZZZZZZZZZZZZZZZZZZZZZZ
row 27 => ABCDEFGHIJKLMNOPQRSTUVWXYZ

Sequence:
ABCDEFGHIJKLMNOPQRSTUVWXYZ
BBCDEFGHIJKLMNOPQRSTUVWXYZ
CCCDEFGHIJKLMNOPQRSTUVWXYZ
DDDDEFGHIJKLMNOPQRSTUVWXYZ
EEEEEFGHIJKLMNOPQRSTUVWXYZ
FFFFFFGHIJKLMNOPQRSTUVWXYZ
GGGGGGGHIJKLMNOPQRSTUVWXYZ
HHHHHHHHIJKLMNOPQRSTUVWXYZ
IIIIIIIIIJKLMNOPQRSTUVWXYZ
JJJJJJJJJJKLMNOPQRSTUVWXYZ
KKKKKKKKKKKLMNOPQRSTUVWXYZ
LLLLLLLLLLLLMNOPQRSTUVWXYZ
MMMMMMMMMMMMMNOPQRSTUVWXYZ
NNNNNNNNNNNNNNOPQRSTUVWXYZ
OOOOOOOOOOOOOOOPQRSTUVWXYZ
PPPPPPPPPPPPPPPPQRSTUVWXYZ
QQQQQQQQQQQQQQQQQRSTUVWXYZ
RRRRRRRRRRRRRRRRRRSTUVWXYZ
SSSSSSSSSSSSSSSSSSSTUVWXYZ
TTTTTTTTTTTTTTTTTTTTUVWXYZ
UUUUUUUUUUUUUUUUUUUUUVWXYZ
VVVVVVVVVVVVVVVVVVVVVVWXYZ
WWWWWWWWWWWWWWWWWWWWWWWXYZ
XXXXXXXXXXXXXXXXXXXXXXXXYZ
YYYYYYYYYYYYYYYYYYYYYYYYYZ
ZZZZZZZZZZZZZZZZZZZZZZZZZZ
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class GetRowFromAlphabeticalSequence
    {
        public static string GetRow(int numOfRow)
        {
            return string.Concat(Enumerable.Range(0, 26).Select(i => (char) (Math.Max(i, (numOfRow - 1) % 26) + 65)));

            //string s = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            //int n = --numOfRow % 26;
            //return new string(s[n], n) + s[n..];
            //return new string(s[n], n) + s.Substring(n);

            //int n = (numOfRow - 1) % 26;
            //return string.Concat(s.Skip(n)).PadLeft(26, s[n]);

            //int n = --numOfRow % 26;
            //return string.Concat(Enumerable.Repeat(s[n], n)) + s.Substring(n);

            //int n = (numOfRow - 1) % 26;
            //return new string(s[n], n) + s.Substring(n);

            //numOfRow = (numOfRow - 1) % 26;
            //return new string(s[numOfRow], numOfRow) + s.Substring(numOfRow, 26 - numOfRow);

            //numOfRow = (numOfRow - 1) % 26;
            //return new string(s[numOfRow], numOfRow) + s.Substring(numOfRow);
        }
    }
}