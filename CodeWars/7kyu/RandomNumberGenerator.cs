/*
https://www.codewars.com/kata/5653935c09106259c000001a/csharp

7 kyu
Random Number Generator

##Generating Random Number

Peter wants to create a class that generates a random number, and here is the class he has developed so far:

public class Kata
    {
        private Random _random = new Random();

        public int GenerateRandomNumber()
        {
            return _random.Next(0, 1000);
        }
    }
When he instantiates the class, GenerateRandomNumber method always generates the same number.

Kata kata1 = new Kata();
Kata kata2 = new Kata();
Help him to modify the class, so the method generates a different number for each instance.
*/

using System;

namespace CodeWars
{
    public class KataRandomNumberGenerator
    {
        public int GenerateRandomNumber() => new Random().Next(0, 1000);
    }
}