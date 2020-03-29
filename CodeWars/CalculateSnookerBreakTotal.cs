/*
https://www.codewars.com/kata/5ae5f2bd73ea5863790005b6/train/csharp
https://www.codewars.com/kata/5ae5f2bd73ea5863790005b6/solutions/csharp

7 kyu
Calculate snooker break total

The aim of this kata is to calculate the total for a snooker break. The rules of snooker for those who dont know are described here.

Given an array of SnookerBall enums (see below), calculate the total of the break. If the break is not valid (see rules for more info on valid breaks), then an exception should be thrown

Assumptions:

All balls are on the table when running the code - ie 15 reds and 1 of each colour
public enum SnookerBall
{
    Red = 1,
    Yellow = 2,
    Green = 3,
    Brown = 4,
    Blue = 5,
    Pink = 6,
    Black = 7,
}
*/


using System;
using System.Linq;

namespace CodeWars
{
    public class CalculateSnookerBreakTotal
    {
        public enum SnookerBall
        {
            Red = 1,
            Yellow = 2,
            Green = 3,
            Brown = 4,
            Blue = 5,
            Pink = 6,
            Black = 7,
        }

        public static int SumBreak(SnookerBall[] pots)
        {
            return pots.Take(30).Select((b, i) => new {b, i}).Any(x => x.i % 2 == 1 ? (int) x.b == 1 : (int) x.b != 1)
                ? throw new Exception()
                : pots.Skip(30).Select((b, i) => new {b, i}).Any(x => (int) x.b != x.i + 2)
                    ? throw new Exception()
                    : pots.Sum(b => (int) b);
        }


        // public static int SumBreak(SnookerBall[] pots)
        // {
        //     int ball_count = 0;
        //     int score = 0;
        //     foreach (SnookerBall ball in pots)
        //     {
        //         score += (int) ball;
        //         if (++ball_count <= 30)
        //         {
        //             if (ball_count % 2 == 1)
        //             {
        //                 if (ball != SnookerBall.Red)
        //                 {
        //                     throw new Exception();
        //                 }
        //             }
        //             else
        //             {
        //                 if (ball == SnookerBall.Red)
        //                 {
        //                     throw new Exception();
        //                 }
        //             }
        //         }
        //         else if ((int) ball != ball_count - 29)
        //         {
        //             throw new Exception();
        //         }
        //     }
        //
        //     return score;
        // }


        // public static int SumBreak(SnookerBall[] pots)
        // {
        //     bool rf = true;
        //     int sc = 0, rc = 15, pr = 0;
        //     foreach (SnookerBall ball in pots)
        //     {
        //         if (rf && rc > 0)
        //         {
        //             if (ball != SnookerBall.Red) throw new Exception();
        //             ++sc;
        //             --rc;
        //         }
        //         else
        //         {
        //             int cr = (int) ball;
        //             if (rc == 0 && pr != 7 && pr + 1 != cr) throw new Exception();
        //             pr = cr;
        //             sc += cr;
        //         }
        //
        //         rf = !rf;
        //     }
        //
        //     return sc;
        // }


        // public static int SumBreak(SnookerBall[] pots)
        // {
        //     int point = (int) pots[0];
        //     int result = point;
        //     int prev = point;
        //     for (int i = 1; i < pots.Length; i++, result += point)
        //     {
        //         if (pots[i] == pots[i - 1])
        //             throw new Exception();
        //
        //         SnookerBall ball = pots[i];
        //         point = (int) ball;
        //         if (ball == SnookerBall.Red || ball == SnookerBall.Black)
        //             continue;
        //         if (point <= prev)
        //             throw new Exception();
        //         prev = point;
        //     }
        //
        //     if (result < 15)
        //         throw new Exception();
        //     return result;
        // }


        // public static int SumBreak(SnookerBall[] pots)
        // {
        //     if (pots.Length < 3)
        //         throw new Exception();
        //     foreach (SnookerBall ball in pots)
        //     {
        //         Console.Write(ball);
        //         Console.Write(" ");
        //     }
        //
        //     int point = (int) pots[0];
        //     int result = point;
        //     int prev = point;
        //     for (int i = 1; i < pots.Length; i++)
        //     {
        //         SnookerBall ball = pots[i];
        //         if (ball == pots[i - 1])
        //             throw new Exception();
        //         point = (int) ball;
        //         result += point;
        //         if (ball == SnookerBall.Red || ball == SnookerBall.Black)
        //             continue;
        //         if (point <= prev)
        //             throw new Exception();
        //         prev = point;
        //     }
        //
        //     return result;
        // }


        // public static int SumBreak(SnookerBall[] pots)
        // {
        //     int curr, prev = -1, total = 0, n = pots.Length, i = 0, red = -1;
        //     while (i < n)
        //     {
        //         curr = (int) pots[i];
        //         Console.WriteLine(String.Format("  [{0}] = {1} ({2})", i, curr, pots[i]));
        //         if (curr == 1)
        //         {
        //             if (prev == 1)
        //             {
        //                 throw new System.Exception("Invalid Break - Red cannot follow Red");
        //             }
        //
        //             red = 0;
        //         }
        //         else
        //         {
        //             if (red == -1)
        //             {
        //                 throw new System.Exception("Invalid Break - runout must begin with Yellow ball");
        //             }
        //
        //             red += 1;
        //             if (red == 2 && curr != 2)
        //             {
        //                 throw new System.Exception("Invalid Break - runout must begin with Yellow ball");
        //             }
        //             else
        //             {
        //                 if (prev >= curr && red != 2)
        //                 {
        //                     throw new System.Exception("Invalid Break - colour balls shot out of order");
        //                 }
        //             }
        //         }
        //
        //         total += curr;
        //         prev = curr;
        //         i++;
        //     }
        //
        //     return total;
        // }


        // public static int SumBreak(SnookerBall[] pots)
        // {
        //     var valid = new int[]
        //     {
        //         1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 2, 3, 4, 5, 6,
        //         7
        //     };
        //     for (var i = 0; i < pots.Count(); i++)
        //     {
        //         switch (valid[i])
        //         {
        //             case 0:
        //                 if ((int) pots[i] == 1)
        //                     throw new Exception("Should be any colour now");
        //                 break;
        //             case 1:
        //                 if ((int) pots[i] != 1)
        //                     throw new Exception("Should be a Red now");
        //                 break;
        //             default:
        //                 if ((int) pots[i] != valid[i])
        //                     throw new Exception("Should be a " + (SnookerBall) valid[i] + " now");
        //                 break;
        //         }
        //     }
        //
        //     return pots.Sum(a => (int) a);
        // }
    }
}