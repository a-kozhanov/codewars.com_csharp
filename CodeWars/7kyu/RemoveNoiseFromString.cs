/*
https://www.codewars.com/kata/5681cf0be812b41721000034/csharp

7 kyu
Remove the noise from the string

We have a broken message machine that introduces noise to our incoming messages. 
We know that our messages can't be written using %$&/#·@|º\ª and white characters (like spaces or tabs). 
Unfortunately our machine introduces noise, which means that our message arrives with characters like: %$&/#·@|º\ª within our original message.

Your mission is to write a function which removes this noise from the message.

Notice that noise can only be
%$&/#·@|º\ª
charaters, other characteres are not considered noise

For example:

Kata.removeNoise("h%e&·%$·llo w&%or&$l·$%d")
// returns hello world
removeNoise "h%e&·%$·llo w&%or&$l·$%d"
// returns hello world
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class RemoveNoiseFromString
    {
        public static string removeNoise(string equation)
        {
            return Regex.Replace(equation, @"[%$&/#·@|º\\ª]", "");

            //return Regex.Replace(equation, @"[^a-zA-Z0-9.!? ]", "");
            //return Regex.Replace(equation, "[^A-Za-z0-9 ?!,.:;]", "");
            //return Regex.Replace(equation, @"[%$&/#·@|º\\ª]", "");
            //return new Regex(@"[%$&/#·@|º\\ª]").Replace(equation, "");
            //return string.Concat(equation.Where(c => !@"%$&/#·@|º\ª".Contains(c)));
            //return new string(equation.Where(c => !"%$&/#·@|º\\ª".Contains(c)).ToArray());
        }
    }
}