/*
https://www.codewars.com/kata/55e81884a60c4ec2ba00003b/csharp

7 kyu
[Riddle made code] Two Spies

During times of war, it is common for spies to infiltrate enemy bases. You are one of these spies

You and another spy are camped outside an enemy base, at this base there is a guard who gives anyone who enters a challenge code, the person is then to give an answer code. If the correct code is give, the person is allowed entry. However if the answer code is incorrect, the person is shot on site.

You and the other spy are observing the base one night and see a person approach. The guard gives the Code 6, to which the person answers 3 and is let in.

Another person approaches and the guard gives the code 12, the person answers 6 and is let in>

Your fellow spy, assuming he knows the pattern approaches.

The guard challenges him with 10, to which he answers 5 and is immediately shot dead

You now have to get into the base, you aproach and the guard challenges you.

YOUR TASK

Write a program that will always give the correct answer to the above challege

INFORMATION

Input will always be a number (in string format) from 1 to 15 Return value must be a string

TLDR

6 = 3

12 = 6

10 != 5
*/

namespace CodeWars
{
    public class RiddleMadeCodeTwoSpies
    {
        public static string getAnswer(string challenge)
        {
            // return new string[15]
            //     {"4", "3", "3", "5", "4", "4", "3", "5", "5", "4", "3", "6", "6", "8", "8"}[int.Parse(challenge)];

            // return new[] {"4", "3", "3", "5", "4", "4", "3", "5", "5", "4", "5", "6", "6", "8", "8"}[
            //     int.Parse(challenge)];

            //return new[] {4, 3, 3, 5, 4, 4, 3, 5, 5, 4, 3, 6, 6, 8, 8}[int.Parse(challenge)].ToString();
            return $"{new[] {4, 3, 3, 5, 4, 4, 3, 5, 5, 4, 3, 6, 6, 8, 8}[int.Parse(challenge)]}";

            // int[] answers = {4, 3, 3, 5, 4, 4, 3, 5, 5, 4, 3, 6, 6, 8, 8};
            // return (answers[int.Parse(challenge)]).ToString();
        }
    }
}