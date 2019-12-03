/*
https://www.codewars.com/kata/the-wide-mouthed-frog/train/csharp
https://www.codewars.com/kata/57ec8bd8f670e9a47a000f89/solutions/csharp

8 kyu
The Wide-Mouthed frog!

The wide mouth frog is particularly interested in the eating habits of other creatures.
He just can't stop asking the creatures he encounters what they like to eat. But then he meet the alligator who just LOVES to eat wide-mouthed frogs!
When he meets the alligator, it then makes a tiny mouth.
Your goal in this kata is to create complete the mouth_size method this method take one argument animal which corresponds to the animal encountered by frog. 
If this one is an alligator (case insensitive) return small otherwise return wide.
*/

using System;

namespace CodeWars
{
    public class WideMouthedFrog
    {
        public static string MouthSize(string animal)
        {
            //return string.Equals(animal.ToUpper(), "alligator".ToUpper(), StringComparison.OrdinalIgnoreCase) ? "small" : "wide";
            //return string.Equals(animal, "alligator", StringComparison.CurrentCultureIgnoreCase) ? "small" : "wide";
            //return animal.ToLower() == "alligator" ? "small" : "wide";
            return animal.Equals("alligator", StringComparison.CurrentCultureIgnoreCase) ? "small" : "wide";
        }
    }
}