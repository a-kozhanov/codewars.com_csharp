/*
https://www.codewars.com/kata/555615a77ebc7c2c8a0000b8/csharp

6 kyu
Vasya - Clerk

The new "Avengers" movie has just been released! There are a lot of people at the cinema box office standing in a huge line. 
Each of them has a single 100, 50 or 25 dollar bill. An "Avengers" ticket costs 25 dollars.

Vasya is currently working as a clerk. He wants to sell a ticket to every single person in this line.
Can Vasya sell a ticket to every person and give change if he initially has no money and sells the tickets strictly in the order people queue?
Return YES, if Vasya can sell a ticket to every person and give change with the bills he has at hand at that moment. Otherwise return NO.

Examples:
Line.Tickets(new int[] {25, 25, 50}) // => YES 
Line.Tickets(new int[] {25, 100}) // => NO. Vasya will not have enough money to give change to 100 dollars
Line.Tickets(new int[] {25, 25, 50, 50, 100}) // => NO. Vasya will not have the right bills to give 75 dollars of change (you can't make two bills of 25 from one of 50)
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class VasyaClerk
    {
        public static string Tickets(int[] peopleInLine)
        {
            int[] bills = {0, 0, 0};

            foreach (var v in peopleInLine)
            {
                switch (v)
                {
                    case 25:
                        bills[0] += 1;
                        break;
                    case 50:
                        bills[0] -= 1;
                        bills[1] += 1;
                        break;
                    case 100 when bills[1] > 0:
                        bills[0] -= 1;
                        bills[1] -= 1;
                        break;
                    case 100 when bills[1] == 0:
                        bills[0] -= 3;
                        break;
                }

                if (bills[0] < 0 || bills[1] < 0 || bills[2] < 0) return "NO";
            }

            return "YES";
        }
    }
}