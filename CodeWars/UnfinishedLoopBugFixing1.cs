/*
https://www.codewars.com/kata/unfinished-loop-bug-fixing-number-1/train/csharp
https://www.codewars.com/kata/55c28f7304e3eaebef0000da/solutions/csharp

8 kyu
Unfinished Loop - Bug Fixing #1

Oh no, Timmy's created an infinite loop! Help Timmy find and fix the bug in his unfinished For Loop!
*/

using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class UnfinishedLoopBugFixing1
    {
        public static List<int> CreateList(int number)
        {
            //List<int> list = new List<int>();

            //for (int counter = 1; counter <= number)
            //{
            //    list.Add(counter);
            //}

            //return list;

            return Enumerable.Range(1, number).ToList();
        }

        //public static List<int> CreateList(int number) => Enumerable.Range(1, number).ToList();


        //public static List<int> CreateList(int number)
        //{
        //    List<int> nums = new List<int>();
        //    for (var i = 1; i <= number; i++)
        //    {
        //        nums.Add(i);
        //    }

        //    return nums;
        //}

    }
}