using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//https://www.codewars.com/kata/give-me-a-diamond/train/csharp
//https://www.codewars.com/kata/5503013e34137eeeaa001648/solutions/csharp


//Give me a Diamond

//Description:
//Jamie is a programmer, and James' girlfriend. She likes diamonds, and wants a diamond string from James. Since James doesn't know how to make this happen, he needs your help.

//Task
//You need to return a string that looks like a diamond shape when printed on the screen, using asterisk (*) characters.Trailing spaces should be removed, and every line must be terminated with a newline character (\n).

//Return null/nil/None/... if the input is an even number or negative, as it is not possible to print a diamond of even or negative size.

//Examples
//A size 3 diamond:

// *
//***
// *
//...which would appear as a string of " *\n***\n *\n"

//A size 5 diamond:

//  *
// ***
//*****
// ***
//  *
//...that is: " *\n ***\n*****\n ***\n *\n"

namespace CodeWars
{
    public class GiveMeDiamond
    {
        public static string print(int n)
        {
            if(!(n > 0 && n % 2 != 0)) return null;

            var result = new StringBuilder();
            int spaces = n / 2;
            string str;

            //for (var i = 0; i < n; i++)
            for (int i = 1; i < n; i += 2)
            {
                str = string.Format("{0}{1}\n", string.Concat(Enumerable.Repeat(" ", spaces--)), string.Concat(Enumerable.Repeat("*", i)));
                result.Append(str);
                Console.Write(str);
            }

            str = string.Format("{0}\n", string.Concat(Enumerable.Repeat("*", n)));
            result.Append(str);
            Console.Write(str);

            int diamonds = n - 2;
            for (int i = 1; i <= n / 2; i++)
            {
                str = string.Format("{0}{1}\n", string.Concat(Enumerable.Repeat(" ", i)), string.Concat(Enumerable.Repeat("*", diamonds)));
                result.Append(str);
                Console.Write(str);
                diamonds -= 2;
            }

            return result.ToString();
        }


        //Best Practices
        //public static string print(int n)
        //{
        //    if (n % 2 == 0 || n < 0)
        //    {
        //        return null;
        //    }

        //    int middle = n / 2;
        //    StringBuilder sb = new StringBuilder();
        //    for (int index = 0; index < n; index++)
        //    {
        //        sb.Append(' ', Math.Abs(middle - index));
        //        sb.Append('*', n - Math.Abs(middle - index) * 2);
        //        sb.Append("\n");
        //    }

        //    return sb.ToString();
        //}


        //public static string print(int n)
        //{
        //    return n % 2 == 1
        //      ? Enumerable.Range(0, n).
        //          Select(q =>
        //         q <= n / 2
        //           ? new string(' ', (n / 2 - q)) + new String('*', q * 2 + 1)
        //           : new string(' ', (q - n / 2)) + new String('*', 2 * (n - q) - 1)
        //          ).Aggregate("", (c, i) => c + i + "\n")
        //       : null;

        //}


        //public static string print(int n)
        //{
        //    if (n < 1 || n % 2 == 0) return null;
        //    IEnumerable<String> top = Enumerable.Range(1, (int)Math.Floor(n / 2.0)).Select((_, i) => new String(' ', (n - 2 * i - 1) / 2) + new String('*', i * 2 + 1));
        //    return String.Join("\n", top) + "\n" + new String('*', n) + "\n" + String.Join("\n", top.Reverse()) + "\n";
        //}



        //public class Diamond
        //{
        //    static string Aster(int times)
        //    {
        //        return new String('*', times);
        //    }

        //    static string Spacer(int times)
        //    {
        //        return new String(' ', times);
        //    }
        //    public static string print(int n)
        //    {
        //        if (n % 2 == 0 || n <= 0) return null;
        //        StringBuilder shape = new StringBuilder();
        //        for (int i = 1; i <= n; i += 2)
        //        {
        //            int count = (n - i) / 2;
        //            shape.Append(Spacer(count) + Aster(i) + "\n");
        //        }
        //        for (int i = n - 2; i > 0; i -= 2)
        //        {
        //            int count = (n - i) / 2;
        //            shape.Append(Spacer(count) + Aster(i) + "\n");
        //        }
        //        return shape.ToString();
        //    }
        //}


        //public static string print(int n)
        //{
        //    if (n < 0 || n % 2 == 0)
        //        return null;

        //    var result = new StringBuilder();
        //    result.Append(new String('*', n));
        //    result.Append("\n");

        //    int spaces = 1;
        //    while (n > 1)
        //    {
        //        n -= 2;
        //        string textToAdd = new String(' ', spaces++) + new String('*', n) + "\n";
        //        result.Insert(0, textToAdd);
        //        result.Append(textToAdd);
        //    }
        //    return result.ToString();
        //}






    }

}
