using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//https://www.codewars.com/kata/well-of-ideas-easy-version/train/csharp
//https://www.codewars.com/kata/57f222ce69e09c3630000212/solutions/csharp

//Well of Ideas - Easy Version

//For every good kata idea there seem to be quite a few bad ones!
//In this kata you need to check the provided array (x) for good ideas 'good' and bad ideas 'bad'.
//If there are one or two good ideas, return 'Publish!', if there are more than 2 return 'I smell a series!'.
//If there are no good ideas, as is often the case, return 'Fail!'.


namespace CodeWars
{
    public class WellIdeasEasyVersion
    {
        public static string Well(string[] x)
        {
            var good = x.Count(s => s == "good");

            if (good == 1 || good == 2) return "Publish!";
            return good > 2 ? "I smell a series!" : "Fail!";
        }


        //Best Practices
        //public static string Well(string[] x)
        //{
        //    int count = x.Count(v => v == "good");
        //    return (count > 2) ? "I smell a series!" : (count >= 1) ? "Publish!" : "Fail!";
        //}


        //public static string Well(string[] x)
        //{
        //    var good = x.Count(y => y == "good");
        //    return good == 0 ? "Fail!" : good > 2 ? "I smell a series!" : "Publish!";
        //}

        //public static string Well(string[] x)
        //    => new string[] { "Fail!", "Publish!", "Publish!", "I smell a series!" }[Math.Min(3, x.Count(e => e == "good"))];

    }
}
