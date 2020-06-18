/*
https://www.codewars.com/kata/5434283682b0fdb0420000e6/csharp

7 kyu
Caffeine Script

Complete the function caffeineBuzz, which takes a non-zero integer as it's one argument.

If the integer is divisible by 3, return the string "Java".

If the integer is divisible by 3 and divisible by 4, return the string "Coffee"

If the integer is one of the above and is even, add "Script" to the end of the string.

Otherwise, return the string "mocha_missing!"

Kata.CaffeineBuzz(1)   => "mocha_missing!"
Kata.CaffeineBuzz(3)   => "Java"
Kata.CaffeineBuzz(6)   => "JavaScript"
Kata.CaffeineBuzz(12)  => "CoffeeScript"
*/

namespace CodeWars
{
    public class CaffeineScript
    {
        public static string CaffeineBuzz(int n)
        {
            //return n % 3 == 0 ? (n % 4 == 0 ? "Coffee" : "Java") + (n % 2 == 0 ? "Script" : "") : "mocha_missing!";
            //return n % 12 == 0 ? "CoffeeScript" : n % 6 == 0 ? "JavaScript" : n % 3 == 0 ? "Java" : "mocha_missing!";

            // if (n % 3 == 0 && n % 4 == 0) return "CoffeeScript";
            // if (n % 3 == 0 && n % 2 == 0) return "JavaScript";
            // if (n % 3 == 0) return "Java";
            // return "mocha_missing!";

            if (n % 12 == 0) return "CoffeeScript";
            if (n % 6 == 0) return "JavaScript";
            return n % 3 == 0 ? "Java" : "mocha_missing!";
        }
    }
}