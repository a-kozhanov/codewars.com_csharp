/*
https://www.codewars.com/kata/56eee006ff32e1b5b0000c32/csharp

7 kyu
Thinking & Testing : Retention and discard II

No Story
No Description
Only by Thinking and Testing
Look at result of testcase, guess the code!

#Series:
01:A and B?
02:Incomplete string
03:True or False
04:Something capitalized
05:Uniq or not Uniq
06:Spatiotemporal index
07:Math of Primary School
08:Math of Middle school
09:From nothingness To nothingness
10:Not perfect? Throw away!
11:Welcome to take the bus
12:A happy day will come
13:Sum of 15(Hetu Luosliu)
14:Nebula or Vortex
15:Sport Star
16:Falsetto Rap Concert
17:Wind whispers
18:Mobile phone simulator
19:Join but not join
20:I hate big and small
21:I want to become diabetic ;-)
22:How many blocks?
23:Operator hidden in a string
24:Substring Magic
25:Report about something
26:Retention and discard I
27:Retention and discard II
28:How many "word"?
29:Hail and Waterfall
30:Love Forever
31:Digital swimming pool
32:Archery contest
33:The repair of parchment
34:Who are you?
35:Safe position


#Special recommendation
Another series, innovative and interesting, medium difficulty. People who like to challenge, can try these kata:

<a href="http://www.codewars.com/kata/56c85eebfd8fc02551000281">Play Tetris : Shape anastomosis</a><br>
Play FlappyBird : Advance Bravely
*/


using System;
using System.Linq;

namespace CodeWars
{
    public class ThinkingTestingRetentionAndDiscardII
    {
        public string Testit(string s, int n)
        {
            //return string.Concat(Convert.ToString(n, 2).Zip(s, (x, y) => x == '1' ? y.ToString() : ""));
            return string.Concat(Convert.ToString(n, 2).Zip(s, (x, y) => x == '1' ? y.ToString() : ""));
            

            //return string.Concat(Convert.ToString(n, 2).Zip(s, (a, b) => a == '1' ? b.ToString() : ""));
            //return string.Concat(s.Zip(Convert.ToString(n, 2), (c, b) => b == '1' ? c : '\0').Where(c => c != '\0'));

            // var showBits = Convert.ToString(n, 2).PadRight(s.Length, '0');
            // return string.Concat(s.Select((c, i) => showBits[i] == '1' ? c + "" : ""));

            // string bits = Convert.ToString(n, 2);
            // return string.Concat(s.Where((_, idx) => idx < bits.Length && bits[idx] == '1'));

            // var showBits = Convert.ToString(n, 2).PadRight(s.Length, '0');
            // return string.Concat(s.Select((c, i) => showBits[i] == '1' ? c + "" : ""));

            // string mask = Convert.ToString(n * 2, 2).PadRight(s.Length, '0');
            // return string.Concat(s.Where((_, i) => mask[i] == '1'));
        }
    }
}