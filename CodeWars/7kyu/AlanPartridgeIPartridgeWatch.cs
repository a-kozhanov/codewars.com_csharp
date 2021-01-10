/*
https://www.codewars.com/kata/5808c8eff0ed4210de000008/csharp

7 kyu
Alan Partridge I - Partridge Watch

To celebrate today's launch of my Hero's new book: Alan Partridge: 
Nomad, We have a new series of kata arranged around the great man himself.

Given an array of terms, if any of those terms relate to Alan Partridge, return Mine's a Pint!

The number of ! after the t should be determined by the number of Alan related terms you find in the provided array (x). 
The related terms are:
Partridge
PearTree
Chat
Dan
Toblerone
Lynn
AlphaPapa
Nomad

If you don't find any related terms, return 'Lynn, I've pierced my foot on a spike!!'

All Hail King Partridge

Other katas in this series:
Alan Partridge II - Apple Turnover
Alan Partridge III - London
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class AlanPartridgeIPartridgeWatch
    {
        public static string Part(string[] x)
        {
            // var count = x.Count(s =>
            //     Array.Exists(new[] {"Partridge", "PearTree", "Chat", "Dan", "Toblerone", "Lynn", "AlphaPapa", "Nomad"},
            //         m => m == s));
            // return count > 0 ? "Mine's a Pint" + new string('!', count) : "Lynn, I've pierced my foot on a spike!!";

            // string[] terms = {"Partridge", "PearTree", "Chat", "Dan", "Toblerone", "Lynn", "AlphaPapa", "Nomad"};
            // var count = x.Count(s => terms.Contains(s));
            // return count > 0 ? "Mine's a Pint" + new string('!', count) : "Lynn, I've pierced my foot on a spike!!";

            var count = x.Count(s =>
                new[] {"Partridge", "PearTree", "Chat", "Dan", "Toblerone", "Lynn", "AlphaPapa", "Nomad"}.Contains(s));
            return count > 0 ? "Mine's a Pint" + new string('!', count) : "Lynn, I've pierced my foot on a spike!!";
        }
    }
}