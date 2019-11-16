/*
https://www.codewars.com/kata/thinkful-number-drills-pixelart-planning/train/csharp
https://www.codewars.com/kata/58630e2ae88af44d2b0000ea/solutions/csharp

8 kyu
Thinkful - Number Drills: Pixelart planning

Your function should take two arguments: the size of the wall in millimeters and the size of a pixel in millimeters. 
It should return True if you can fit an exact number of pixels on the wall, otherwise it should return False. 
For example is_divisible(4050, 27) should return True, but is_divisible(4066, 27) should return False.

Note: you don't need to use an if statement here. Remember that in Python an expression using the == comparison operator will evaluate to either True or False:
*/

namespace CodeWars
{
    public class ThinkfulNumberDrillsPixelartPlanning
    {
        public static bool IsDivisible(int wallLength, int pixelSize)
        {
            return wallLength % pixelSize == 0;
        }
    }
}