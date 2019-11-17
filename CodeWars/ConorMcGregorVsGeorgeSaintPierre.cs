/*
https://www.codewars.com/kata/for-ufc-fans-total-beginners-conor-mcgregor-vs-george-saint-pierre/train/csharp
https://www.codewars.com/kata/582dafb611d576b745000b74/solutions/csharp

8 kyu
For UFC Fans (Total Beginners): Conor McGregor vs George Saint Pierre

This is a beginner friendly kata especially for UFC/MMA fans.

It's a fight between the two legends: Conor McGregor vs George Saint Pierre in Madison Square Garden. 
Only one fighter will remain standing, and after the fight in an interview with Joe Rogan the winner will make his legendary statement. 
It's your job to return the right statement depending on the winner!

If the winner is George Saint Pierre he will obviously say:

"I am not impressed by your performance."
If the winner is Conor McGregor he will most undoubtedly say:

"I'd like to take this chance to apologize.. To absolutely NOBODY!"
Good Luck!
*/

using System;

namespace CodeWars
{
    public class ConorMcGregorVsGeorgeSaintPierre
    {
        public static string Quote(string fighter)
        {
            return fighter.Equals("Conor McGregor", StringComparison.CurrentCultureIgnoreCase)
                ? "I'd like to take this chance to apologize.. To absolutely NOBODY!"
                : "I am not impressed by your performance.";
        }


        //public static string Quote(string fighter)
        //{
        //    return fighter.ToLower() == "conor mcgregor" ? @"I'd like to take this chance to apologize.. To absolutely NOBODY!" : @"I am not impressed by your performance.";
        //}


        //public static string Quote(string fighter)
        //{
        //    switch (fighter.ToLower())
        //    {
        //        case "george saint pierre":
        //            return "I am not impressed by your performance.";
        //        case "conor mcgregor":
        //            return "I'd like to take this chance to apologize.. To absolutely NOBODY!";
        //        default:
        //            return "I don't know!";
        //    }
        //}


        //public static string Quote(string f)
        //{
        //    return f.ToLower()=="george saint pierre"?"I am not impressed by your performance.":"I'd like to take this chance to apologize.. To absolutely NOBODY!";
        //}


        //public static string Quote(string fighter)
        //{
        //    return fighter[0] == 'g' || fighter[0] == 'G' ? "I am not impressed by your performance." : "I'd like to take this chance to apologize.. To absolutely NOBODY!";
        //}


    }
}