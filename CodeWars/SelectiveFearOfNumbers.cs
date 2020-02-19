/*
https://www.codewars.com/kata/55b1fd84a24ad00b32000075/train/csharp
https://www.codewars.com/kata/55b1fd84a24ad00b32000075/solutions/csharp

7 kyu
Selective fear of numbers

I've got a crazy mental illness. I dislike numbers a lot. 
But it's a little complicated: The number I'm feared of depends on which day of week it is... 
This a concrete description of my mental illness:

Monday --> 12
Tuesday --> numbers greater than 95
Wednesday --> 34
Thursday --> 0
Friday --> numbers divisable by 2
Saturday --> 56
Sunday --> 666 or -666

Write a function which takes a string (day of week) and an integer (number to be tested) so it tells the doctor if I'm feared or not. (return a boolean)
*/

using System;
using System.Collections.Generic;

namespace CodeWars
{
    public class SelectiveFearOfNumbers
    {
        public static bool AmIAfraid(string day, int num)
        {
            return new Dictionary<string, bool>
            {
                {"Monday", num == 12},
                {"Tuesday", num > 95},
                {"Wednesday", num == 34},
                {"Thursday", num == 0},
                {"Friday", num % 2 == 0},
                {"Saturday", num == 56},
                {"Sunday", num % 666 == 0}
            }[day];
        }

        // public static bool AmIAfraid(string day, int num)
        // {
        //     return new Dictionary<string, Func<int, bool>>() {
        //         { "Monday"    , x => x == 12            },
        //         { "Tuesday"   , x => x > 95             },
        //         { "Wednesday" , x => x == 34            },
        //         { "Thursday"  , x => x == 0             },
        //         { "Friday"    , x => x % 2 == 0         },
        //         { "Saturday"  , x => x == 56            },
        //         { "Sunday"    , x => Math.Abs(x) == 666 }
        //     }[day](num);
        // }


        // public static bool AmIAfraid(string day, int num)
        // {
        //     switch (day)
        //     {
        //         case "Monday":
        //             return num == 12;
        //         case "Tuesday":
        //             return num > 95;
        //         case "Wednesday":
        //             return num == 34;
        //         case "Thursday":
        //             return num == 0;
        //         case "Friday":
        //             return num % 2 == 0;
        //         case "Saturday":
        //             return num == 56;
        //         case "Sunday":
        //             return num == 666 || num == -666;
        //     }
        //     return false;
        // }


        // public static bool AmIAfraid(string day, int num)
        // {
        //     bool[] fears = new bool[7]
        //     {        
        //         Math.Abs(num) == 666,
        //         num == 12,
        //         num > 95,
        //         num == 34,
        //         num == 0,
        //         num % 2 == 0,
        //         num == 56
        //     };
        //
        //     return fears[(int)Enum.Parse(typeof(DayOfWeek), day)];
        // }


        // public static bool AmIAfraid(string day, int num)
        // {
        //     if(day == "Monday") return num == 12;
        //     if(day == "Tuesday") return num > 95;
        //     if(day == "Wednesday") return num == 34;
        //     if(day == "Thursday") return num == 0;
        //     if(day == "Friday") return num %2 == 0;
        //     if(day == "Saturday") return num == 56;
        //     if(day == "Sunday") return (num == 666 || num == -666);
        //     else return false;
        // }


        // public static bool AmIAfraid(string day, int num)
        // {
        //     switch(day)
        //     {
        //         case "Monday": return num == 12;
        //         case "Wednesday": return num == 34;
        //         case "Thursday": return num == 0;
        //         case "Saturday": return num == 56;
        //         case "Sunday": return Math.Abs(num) == 666;
        //         case "Friday": return num%2 == 0;
        //         case "Tuesday": return num > 95;
        //         default: return false;
        //     }
        // }


        // public static bool AmIAfraid(string day, int num)
        // {
        //     string s=(num==12)?"Monday":(num==34)?"Wednesday":(num==0)?"Thursday":(num==56)?"Saturday":(num==666|num==-666)?"Sunday":(num>95)?"Tuesday":(num%2==0)?"Friday":"oh no!";
        //     return day==s;
        // }
    }
}