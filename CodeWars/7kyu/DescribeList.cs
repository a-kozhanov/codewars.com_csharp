/*
https://www.codewars.com/kata/57a4a3e653ba3346bc000810/csharp

7 kyu
Describe a list

Write function describeList which returns "empty" if the list is empty or "singleton" if it contains only one element or "longer"" if more.
*/

using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class DescribeList
    {
        public static string describeList(List<int> list)
        {
            //return list.Count == 0 ? "empty" : list.Count == 1 ? "singleton" : "longer";
            //return list.Count == 0 ? "empty" : list.Count > 1 ? "longer" : "singleton";
            return list.Count switch {0 => "empty", 1 => "singleton", _ => "longer"};
        }
    }
}