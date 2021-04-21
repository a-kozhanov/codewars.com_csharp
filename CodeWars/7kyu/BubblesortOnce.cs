/*
https://www.codewars.com/kata/56b97b776ffcea598a0006f2/csharp

7 kyu
Bubblesort Once

Bubblesort Algorithm
Overview
The Bubblesort Algorithm is one of many algorithms used to sort a list of similar items (e.g. all numbers or all letters) into either ascending order or descending order. Given a list (e.g.):

new int[] {9, 7, 5, 3, 1, 2, 4, 6, 8}
To sort this list in ascending order using Bubblesort, you first have to compare the first two terms of the list. 
If the first term is larger than the second term, you perform a swap. The list then becomes:

new int[] {7, 9, 5, 3, 1, 2, 4, 6, 8} // The "9" and "7" have been swapped because 9 is larger than 7 and thus 9 should be after 7
You then proceed by comparing the 2nd and 3rd terms, performing a swap when necessary, and then the 3rd and 4th term, then the 4th and 5th term, etc. etc. 
When you reach the end of the list, it is said that you have completed 1 complete pass.

Task
Given an array of integers, your function bubblesortOnce/bubblesort_once/BubblesortOnce (or equivalent, depending on your language's naming conventions) should return a new array equivalent to performing exactly 1 complete pass on the original array. 
Your function should be pure, i.e. it should not mutate the input array.

*/

namespace CodeWars
{
    public class KataBubblesortOnce
    {
        public static int[] BubbleSortOnce(int[] input)
        {
            for (var i = 0; i <= input.Length - 2; i++)
            {
                if (input[i] <= input[i + 1]) continue;
                var a = input[i];
                input[i] = input[i + 1];
                input[i + 1] = a;
            }

            return input;
        }
    }
}