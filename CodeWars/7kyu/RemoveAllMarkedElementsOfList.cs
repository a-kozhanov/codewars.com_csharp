/*
https://www.codewars.com/kata/563089b9b7be03472d00002b/train/csharp

7 kyu
Remove All The Marked Elements of a List

Define a method/function that removes from a given array of integers all the values contained in a second array.

Examples:
int[] integerList = new int[]{ 1, 1, 2, 3, 1, 2, 3, 4 }
int[] valuesList = new int[]{ 1, 3 }
Kata.Remove(integerList, valuesList) == new int[]{ 2, 2, 4 } // --> true

int[] integerList = new int[]{ 1, 1, 2 ,3 ,1 ,2 ,3 ,4, 4, 3 ,5, 6, 7, 2, 8 }
int[] valuesList = new int[]{ 1, 3, 4, 2 }
Kata.Remove(integerList, valuesList) == new int[]{ 5, 6 ,7 ,8 } // --> true

int[] integerList = new int[]{ 8, 2, 7, 2, 3, 4, 6, 5, 4, 4, 1, 2 , 3 }
int[] valuesList = new int[]{ 2, 4, 3 }
Kata.Remove(integerList, valuesList) == new int[]{ 8, 7, 6, 5, 1 } // --> true

Enjoy it!!
*/


using System;
using System.Linq;

namespace CodeWars
{
    public class RemoveAllMarkedElementsOfList
    {
        public static int[] Remove(int[] integerList, int[] valuesList)
        {
            //return integerList.Where(x => !Array.Exists(valuesList, i => i == x)).ToArray();
            //return integerList.Where(x => valuesList.Count(i => i == x) == 0).ToArray();
            //return integerList.Where(x => Array.IndexOf(valuesList, x) < 0).ToArray();
            //return integerList.Where(x => valuesList.All(i => i != x)).ToArray();
            //return integerList.Where(x => !valuesList.Contains(x)).ToArray();
            return Array.FindAll(integerList, i => !valuesList.Contains(i));
        }
    }
}