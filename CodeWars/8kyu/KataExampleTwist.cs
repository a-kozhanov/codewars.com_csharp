/*
https://www.codewars.com/kata/kata-example-twist/train/csharp
https://www.codewars.com/kata/525c1a07bb6dda6944000031/solutions/csharp

8 kyu
Kata Example Twist

This is an easy twist to the example kata (provided by Codewars when learning how to create your own kata).
Add the value "codewars" to the array websites/Websites 1,000 times.

*/

using System.Linq;

namespace CodeWars
{
    public class KataExampleTwist
    {
        public static string[] Websites => Enumerable.Repeat("codewars", 1000).ToArray();

        //public static string[] Websites = new string[1000];
        //static Kata()
        //{
        //    for(int i = 0; i < 1000; i++)
        //        Websites[i] = "codewars";
        //}



        //public static string[] Websites
        //{
        //    get
        //    {
        //        var sites = new string[1000];

        //        for (var i = 0; i < 1000; i++)
        //        { 
        //            sites[i] = "codewars";
        //        }
        //        return sites;
        //    }
        //}



    }
}