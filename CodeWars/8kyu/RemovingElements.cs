using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//https://www.codewars.com/kata/removing-elements/train/csharp
//https://www.codewars.com/kata/5769b3802ae6f8e4890009d2/solutions/csharp

//Removing Elements

//Take an array and remove every second element out of that array.Always keep the first element and start removing with the next element.
//Example:
//my_list = ['Keep', 'Remove', 'Keep', 'Remove', 'Keep', ...]
//None of the arrays will be empty, so you don't have to worry about that!

namespace CodeWars
{
    public class RemovingElements
    {
        public static object[] RemoveEveryOther(object[] arr)
        {
            var result = arr.ToList();

            for (var index = arr.Length - 1; index > 0; index--)
            {
                if (index % 2 == 1) result.RemoveAt(index);
            }

            return result.ToArray();
        }

        //Best Practices
        //public static object[] RemoveEveryOther(object[] arr)
        //{
        //    return arr.Where((e, i) => i % 2 == 0).ToArray();
        //}


        //public static object[] RemoveEveryOther(object[] arr)
        //{
        //    var list = new List<object>();
        //    for (int i = 0; i < arr.Count(); i += 2)
        //    {
        //        list.Add(arr[i]);
        //    }
        //    return list.ToArray();
        //}


        //public static object[] RemoveEveryOther(object[] arr)
        //{
        //    return arr.Where((a, b) => b % 2 == 0).ToArray();
        //}


        //public static object[] RemoveEveryOther(object[] arr)
        //{

        //    object[] res = new object[(arr.Length + 1) / 2];
        //    for (int i = 0; i < res.Length; i++)
        //    {
        //        res[i] = arr[i * 2];
        //    }
        //    return res;

        //}

    }
}
