/*
https://www.codewars.com/kata/5a084a098ba9146690000969/csharp

7 kyu
Easy Time Convert

This kata requires you to convert minutes (int) to hours and minutes in the format hh:mm (string).

If the input is 0 or negative value, then you should return "00:00"

Hint: use the modulo operation to solve this challenge. 
The modulo operation simply returns the remainder after a division. 
For example the remainder of 5 / 2 is 1, so 5 modulo 2 is 1.

Example
If the input is 78, then you should return "01:18", because 78 minutes converts to 1 hour and 18 minutes.

Good luck! :D
*/

using System;

namespace CodeWars
{
    public class EasyTimeConvert
    {
        public static string TimeConvert(int num)
        {
            //return $"{((num < 0 ? 0 : num) / 60):D2}:{((num < 0 ? 0 : num) % 60):D2}";
            //return num > 0 ? $"{num / 60:D2}:{num % 60:D2}" : "00:00";
            //return num < 0 ? "00:00" : (num / 60 * 100 + num % 60).ToString("00:00");
            //return num < 0 ? "00:00" : $"{num / 60 * 100 + num % 60:00:00}";
            //return num <= 0 ? "00:00" : $"{num / 60:00}:{num % 60:00}";
            //return num <= 0 ? "00:00" : $"{num / 60:D2}:{num % 60:D2}";
            // return num > 0 ? $"{num / 60:00}:{num % 60:00}" : "00:00";
            return num > 0 ? $"{num / 60:D2}:{num % 60:D2}" : "00:00";
        }
    }
}