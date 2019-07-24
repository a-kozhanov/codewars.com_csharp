using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

//https://www.codewars.com/kata/logical-calculator/train/csharp
//https://www.codewars.com/kata/57096af70dad013aa200007b/solutions/csharp

//Logical calculator

//Your task is to calculate logical value of boolean array.Test arrays are one-dimensional and their size is in the range 1-50.
//Links referring to logical operations: AND, OR and XOR.
//You should begin at the first value, and repeatedly apply the logical operation across the remaining elements in the array sequentially.

//First Example:
//Input: true, true, false, operator: AND
//Steps: true AND true -> true, true AND false -> false
//Output: false

//Second Example:
//Input: true, true, false, operator: OR
//Steps: true OR true -> true, true OR false -> true
//Output: true

//Third Example:
//Input: true, true, false, operator: XOR
//Steps: true XOR true -> false, false XOR false -> false
//Output: false
//Input:
//boolean array, string with operator' s name: 'AND', 'OR', 'XOR'.
//Output:
//calculated boolean


namespace CodeWars
{
    public class LogicalCalculator
    {
        public static bool LogicalCalc(bool[] array, string op)
        {
            switch (op)
            {
                case "AND": return array.Aggregate((x,y) => x & y);
                case "OR": return array.Aggregate((x, y) => x | y);
                case "XOR": return array.Aggregate((x, y) => x ^ y);
                default: throw new System.InvalidOperationException();
            }
        }

        //public static bool LogicalCalc(bool[] array, string op)
        //{
        //    if (op == "AND")
        //        return array.All(x => x);
        //    else if (op == "OR")
        //        return array.Any(x => x);
        //    else
        //        return array.Aggregate((i, j) => i ^ j);
        //}


        //public static bool LogicalCalc(bool[] array, string op)
        //{
        //    switch (op)
        //    {
        //        case "AND":
        //            return !array.Contains(false);
        //        case "OR":
        //            return array.Contains(true);
        //        default:
        //            return array.Aggregate((r, b) => r ^ b);
        //    }
        //}


        //public static bool LogicalCalc(bool[] array, string op)
        //{
        //    return op == "AND" ? array.All(x => x) : op == "OR" ? array.Any(x => x) : array.Aggregate((x, y) => x ^ y);
        //}

        //public static bool LogicalCalc(bool[] array, string op)
        //{
        //    return array.Aggregate((a, b) => op == "AND" ? a && b : op == "OR" ? a || b : a != b);
        //}


        //public static bool LogicalCalc(bool[] array, string op)
        //{
        //    Func<bool, bool, bool> logicalFunc;
        //    switch (op)
        //    {
        //        case "AND":
        //            logicalFunc = (x, y) => x && y;
        //            break;
        //        case "OR":
        //            logicalFunc = (x, y) => x || y;
        //            break;
        //        default:
        //            logicalFunc = (x, y) => x ^ y;
        //            break;
        //    }
        //    return array.ToList().Aggregate(logicalFunc);
        //}


    }
}
