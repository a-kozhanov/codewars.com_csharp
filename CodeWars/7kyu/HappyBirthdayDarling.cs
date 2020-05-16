/*
https://www.codewars.com/kata/5e96332d18ac870032eb735f

7 kyu
Happy Birthday, Darling!

As you may know, once some people pass their teens, they jokingly only celebrate their 20th or 21st birthday, forever. 
With some maths skills, that's totally possible - you only need to select the correct number base!

For example, if they turn 32, that's exactly 20 - in base 16... Already 39? That's just 21, in base 19!

Your task is to translate the given age to the much desired 20 (or 21) years, and indicate the number base, 
in the format specified below.

Note: input will be always > 21

Examples:
32  -->  "32? That's just 20, in base 16!"
39  -->  "39? That's just 21, in base 19!"
My other katas
If you enjoyed this kata then please try my other katas! :-)

Translations are welcome!
*/

using System;

namespace CodeWars
{
    public class HappyBirthdayDarling
    {
        public static string WomensAge(int n)
        {
            //return $"{n}? That's just {20 + n % 2}, in base {n / 2}!";
            //return $"{n}? That's just 2{1 & n}, in base {n >> 1}!";
            return $"{n}? That's just 2{n % 2}, in base {n / 2}!";
        }
    }
}