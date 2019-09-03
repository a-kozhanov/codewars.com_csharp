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
    }

}
