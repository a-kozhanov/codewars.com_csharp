using System;
using System.Collections.Generic;
using System.Linq;

//https://www.codewars.com/kata/reverse-list-order/train/csharp
//https://www.codewars.com/kata/53da6d8d112bd1a0dc00008b/solutions/csharp

//Reverse List Order

//In this kata you will create a function that takes in a list and returns a list with the reverse order.
//Examples
//Kata.ReverseList(new List<int> {1,2,3,4}) == new List<int> {4,3,2,1};
//Kata.ReverseList(new List<int> {3,1,5,4}) == new List<int> {4,5,1,3};


namespace CodeWars
{
    public class ReverseListOrder
    {
        public static List<int> ReverseList(List<int> list)
        {
            return list.ToArray().Reverse().ToList();
        }

        //public static List<int> ReverseList(List<int> list)
        //{
        //    return Enumerable.Reverse(list).ToList();
        //}

        //public static List<int> ReverseList(List<int> list) => list.AsEnumerable().Reverse().ToList();

        //public static List<int> ReverseList(List<int> list)
        //{
        //    List<int> yeniDizi = new List<int>();

        //    for (int i = list.Count - 1; i >= 0; i--)
        //    {
        //        yeniDizi.Add(list[i]);
        //    }

        //    return yeniDizi;
        //}


        //public static List<int> ReverseList(IEnumerable<int> list) => list.Reverse().ToList();


        //public static List<int> ReverseList(List<int> list)
        //{
        //    return list.Reverse<int>().ToList();
        //}

        //public static List<int> ReverseList(List<int> list)
        //{
        //    List<int> result = new List<int>();
        //    foreach (int number in list) result.Insert(0, number);
        //    return result;
        //}


        //public static List<int> ReverseList(List<int> list)
        //{

        //    IEnumerable<int> reverse = list.AsEnumerable().Reverse();
        //    return reverse.ToList();
        //}


        //public static List<int> ReverseList(List<int> list)
        //{
        //    List<int> newList = list.GetRange(0, list.Count);
        //    newList.Reverse();
        //    return newList;
        //}


        //public static List<int> ReverseList(List<int> list)
        //{
        //    return Enumerable.Reverse(list).ToList();
        //}




    }
}