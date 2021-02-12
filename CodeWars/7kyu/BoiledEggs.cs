/*
https://www.codewars.com/kata/52b5247074ea613a09000164/csharp

7 kyu
Boiled Eggs

You are the greatest chef on earth. No one boils eggs like you! Your restaurant is always full of guests, 
who love your boiled eggs. But when there is a greater order of boiled eggs, you need some time, 
because you have only one pot for your job. How much time do you need?

Your Task
Implement a function, which takes a non-negative integer, representing the number of eggs to boil. 
It must return the time in minutes (integer), which it takes to have all the eggs boiled.

Rules
you can put at most 8 eggs into the pot at once
it takes 5 minutes to boil an egg
we assume, that the water is boiling all the time (no time to heat up)
for simplicity we also don't consider the time it takes to put eggs into the pot or get them out of it
Example
Kata.CookingTime(0)  => 0;
Kata.CookingTime(5)  => 5;
Kata.CookingTime(10) => 10;
*/

using System;

namespace CodeWars
{
    public class BoiledEggs
    {
        public static int CookingTime(int eggs)
        {
            //return eggs / 8 * 5 + (eggs % 8 == 0 ? 0 : 5);
            //return (int) Math.Ceiling(eggs / 8.0) * 5;
            //return (int) Math.Ceiling(eggs / 8f) * 5;
            //return ~~((eggs + 7) / 8) * 5;
            //return (eggs + 7) / 8 * 5;

            return 5 * (int) Math.Ceiling(eggs / 8d);
        }
    }
}