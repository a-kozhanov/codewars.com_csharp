/*
https://www.codewars.com/kata/57dd3a06eb0537b899000a64/csharp

7 kyu
The 12 Days of Christmas

Oh No!

The song sheets have been dropped in the snow and the lines of each verse have become all jumbled up.

Task
You have to write a comparator function which can sort the lines back into their correct order, otherwise Christmas will be cancelled!

Reminder: Below is what the final verse should look like

On the 12th day of Christmas my true love gave to me
12 drummers drumming,
11 pipers piping, 
10 lords a leaping, 
9 ladies dancing, 
8 maids a milking,
7 swans a swimming, 
6 geese a laying, 
5 golden rings, 
4 calling birds,
3 French hens, 
2 turtle doves and 
a partridge in a pear tree.
*/

using System;

namespace CodeWars
{
    public class _12DaysOfChristmas
    {
        public int Compare(string line1, string line2)
        {
            string[] order = {"a ", "2 ", "3 ", "4 ", "5 ", "6 ", "7 ", "8 ", "9 ", "10", "11", "12", "On"};
            return Array.IndexOf(order, line2[..2]) - Array.IndexOf(order, line1[..2]);
        }
    }
}