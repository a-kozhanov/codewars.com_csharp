/*
https://www.codewars.com/kata/57a04da9e298a7ee43000111/csharp

7 kyu
Reverse list

Write reverseList function that simply reverses lists.
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class ReverseList
    {
        public static int[] reverseList(int[] list)
        {
            // Array.Reverse(list);
            // return list;

            return list.Reverse().ToArray();
        }
    }
}