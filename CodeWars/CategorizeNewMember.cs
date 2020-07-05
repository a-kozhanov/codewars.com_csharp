/*
https://www.codewars.com/kata/5502c9e7b3216ec63c0001aa/csharp

7 kyu
Categorize New Member

The Western Suburbs Croquet Club has two categories of membership, Senior and Open. 
They would like your help with an application form that will tell prospective members which category they will be placed.

To be a senior, a member must be at least 55 years old and have a handicap greater than 7. 
In this croquet club, handicaps range from -2 to +26; the better the player the lower the handicap.

Input
Input will consist of a list of lists containing two items each. 
Each list contains information for a single potential member. 
Information consists of an integer for the person's age and an integer for the person's handicap.

Note for F#: The input will be of (int list list) which is a List<List>

Example Input
new int[][] {new int[] {18, 20}, new int[] {45, 2}, new int[] {61, 12}, new int[] {37, 6}, new int[] {21, 21}, new int[] {78, 9}}
Output
Output will consist of a list of string values (in Haskell: Open or Senior) stating whether the respective member is to be placed in the senior or open category.

Example Output
new string[] {"Open", "Open", "Senior", "Open", "Open", "Senior"}
*/

using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class CategorizeNewMember
    {
        public static IEnumerable<string> OpenOrSenior(int[][] data)
        {
            return data.Select(i => i[0] > 54 && i[1] > 7 ? "Senior" : "Open");
        }
    }
}