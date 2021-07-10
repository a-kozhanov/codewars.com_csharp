/*
https://www.codewars.com/kata/55f416b2019f552cb0000086/csharp

7 kyu
Color of the moment

Imagine you have a digital clock which paints the whole screen with a color instead of showing you what time it is. 
While it looks good on your wall and you get to impress your guests, you also want to be able to tell what time it is. 
Luckily, the clock also prints the hex code in the bottom right of the screen. 
Using that, you should be able to tell the time, which is another way to impress your guests :)

The hex code will come to you in this format: #0d242c

And you will return the time in this format: hh:mm:ss

Note: The hexCode you will be provided will always be in the correct format. However, it might not point to a correct time. 
So make sure to throw an error if the time you have calculated is invalid.
*/

using System;

namespace CodeWars
{
    public class ColorOfMoment
    {
        public string HexToTime(string hex)
        {
            int HexToDec(int index) => Convert.ToInt32(hex.Substring(index, 2), 16);
            // int HexToDec(int index) => Convert.ToInt32(hex[index .. (index + 2)], 16);
            var (h, m, s) = (HexToDec(1), HexToDec(3), HexToDec(5));
            if (h > 23 || m > 59 || s > 59) throw new Exception("Thats not a valid time!");
            return $"{h:d2}:{m:d2}:{s:d2}";
        }
    }
}