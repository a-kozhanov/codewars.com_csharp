/*
https://www.codewars.com/kata/5c44b0b200ce187106452139/train/csharp
https://www.codewars.com/kata/5c44b0b200ce187106452139/solutions/csharp

7 kyu
How many arguments

args_count(1, 2, 3) -> 3
args_count(1, 2, 3, 10) -> 4
*/

using System.Linq;

namespace CodeWars
{
    public class HowManyArguments
    {
        //public static int CountArgs(params dynamic[] args)
        public static int CountArgs(params object[] args)
        {
            return args.Length;
            //return args.Count();
        }
    }
}