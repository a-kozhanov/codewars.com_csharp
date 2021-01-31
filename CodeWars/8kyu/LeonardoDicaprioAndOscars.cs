/*
https://www.codewars.com/kata/leonardo-dicaprio-and-oscars/train/csharp
https://www.codewars.com/kata/56d49587df52101de70011e4/solutions/csharp

8 kyu
Leonardo Dicaprio and Oscars

You have to write a function that describe Leo:

def leo(oscar):
  pass

if oscar was (integer) 88, you have to return "Leo finally won the oscar! Leo is happy".
if oscar was 86, you have to return "Not even for Wolf of wallstreet?!"
if it was not 88 or 86 (and below 88) you should return "When will you give Leo an Oscar?"
if it was over 88 you should return "Leo got one already!"

*/

namespace CodeWars
{
    public class LeonardoDicaprioAndOscars
    {
        public static string Leo(int oscar)
        {
            return oscar switch
            {
                88 => "Leo finally won the oscar! Leo is happy",
                86 => "Not even for Wolf of wallstreet?!",
                _ => oscar < 88 ? "When will you give Leo an Oscar?" : "Leo got one already!"
            };

            // switch (oscar)
            // {
            //     case 88:
            //         return "Leo finally won the oscar! Leo is happy";
            //     case 86:
            //         return "Not even for Wolf of wallstreet?!";
            //     default:
            //         return oscar < 88 ? "When will you give Leo an Oscar?" : "Leo got one already!";
            // }
        }
    }
}


//using System;
//public static class Kata
//{
//    public static string Leo(int oscar) => oscar > 88 ? "Leo got one already!" : (oscar == 88 ? "Leo finally won the oscar! Leo is happy" : (oscar == 86 ? "Not even for Wolf of wallstreet?!" : "When will you give Leo an Oscar?"));
//}