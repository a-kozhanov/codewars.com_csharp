/*
https://www.codewars.com/kata/59b710ed70a3b7dd8f000027/csharp

7 kyu
Possiblities Array

A non-empty array a of length n is called an array of all possiblities if it contains all numbers between [0,a.length-1].
Write a method named isAllPossibilities that accepts an integer array and returns true if the array is an array of all possiblities,else false.

Example:

a=[1,2,0,3]
a.length-1=3 
a includes [0,3] ,hence the function should return true
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class PossiblitiesArray
    {
        public static bool IsAllPossibilities(int[] arr)
        {
            //return arr.Length < 1 ? false : Enumerable.Range(0, arr.Length).SequenceEqual(arr.OrderBy(a => a));
            //return arr.Length >= 1 && Enumerable.Range(0, arr.Length).SequenceEqual(arr.OrderBy(a => a));
            //return arr.Any() && Enumerable.Range(0, arr.Length).ToHashSet().SetEquals(arr);
            //return arr.Length != 0 && Enumerable.Range(0, arr.Length).All(arr.Contains);
            //return arr.Length > 0 && Enumerable.Range(0, arr.Length).All(arr.Contains);
            //return arr.Any() && !Enumerable.Range(0, arr.Length).Except(arr).Any();
            //return arr.Any() && !Enumerable.Range(0, arr.Length).Except(arr).Any();
            //return !Enumerable.Range(0, arr.Length).Except(arr).Any() && arr.Any();
            //return arr.Any() && Enumerable.Range(0, arr.Length).All(arr.Contains);
            //return arr.Any() && Enumerable.Range(0, arr.Length).All(arr.Contains);

            return !Enumerable.Range(0, arr.Length).Except(arr).Any();
        }
    }
}