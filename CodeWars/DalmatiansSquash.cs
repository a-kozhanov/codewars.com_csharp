using System.Collections.Generic;


//https://www.codewars.com/kata/101-dalmatians-squash-the-bugs-not-the-dogs/train/csharp
//https://www.codewars.com/kata/56f6919a6b88de18ff000b36/solutions/csharp

//101 Dalmatians - squash the bugs, not the dogs!

//Your friend has been out shopping for puppies (what a time to be alive!)... He arrives back with multiple dogs, and you simply do not know how to respond!
//By repairing the function provided, you will find out exactly how you should respond, depending on the number of dogs he has.
//The number of dogs will always be a number and there will always be at least 1 dog.

namespace CodeWars
{
    public class DalmatiansSquash
    {
        public static string HowManyDalmatians(int n)
        {
            var dogs = new List<string>()
            {
                "Hardly any",
                "More than a handful!",
                "Woah that's a lot of dogs!",
                "101 DALMATIONS!!!"
            };
            string respond;

            if (n <= 10) respond = dogs[0];
            else if (n <= 50) respond = dogs[1];
            else if (n == 101) respond = dogs[3];
            else respond = dogs[2];

            return respond;
        }

        //public static string HowManyDalmatians(int n)
        //{
        //    if (n <= 10) return "Hardly any";
        //    if (n <= 50) return "More than a handful!";
        //    if (n == 101) return "101 DALMATIONS!!!";
        //    return "Woah that's a lot of dogs!";
        //}


        //private static List<string> dogs = new List<string>()
        //{
        //    "Hardly any",
        //    "More than a handful!",
        //    "Woah that's a lot of dogs!",
        //    "101 DALMATIONS!!!"
        //};
        //public static string HowManyDalmatians(int number)
        //{
        //    return number <= 10 ? dogs[0]
        //        : number <= 50 ? dogs[1]
        //        : number == 101 ? dogs[3]
        //        : dogs[2];
        //}



        //public static string HowManyDalmatians(int n)
        //{
        //    List<string> dogs = new List<string>()
        //    {
        //        "Hardly any",
        //        "More than a handful!",
        //        "Woah that's a lot of dogs!",
        //        "101 DALMATIONS!!!"
        //    };

        //    return (n <= 10) ? dogs[0] : (n <= 50) ? dogs[1] : (n == 101) ? dogs[3] : dogs[2];            
        //}


        //public static string HowManyDalmatians(int n)
        //{
        //    switch (n)
        //    {
        //        case int a when a <= 10: return "Hardly any";
        //        case int a when a <= 50: return "More than a handful!";
        //        case int a when a == 101: return "101 DALMATIONS!!!";
        //        default: return "Woah that's a lot of dogs!";
        //    }
        //}


        //public static string HowManyDalmatians(int number)
        //{
        //    string[] dogs = new string[]
        //    {
        //        "Hardly any",
        //        "More than a handful!",
        //        "Woah that's a lot of dogs!",
        //        "101 DALMATIONS!!!"
        //    };
        //    if( number <= 10) return dogs[0]; else if(number <= 50) return dogs[1]; else if(number == 101) return dogs[3]; else return dogs[2];
        //}


        //public static string HowManyDalmatians(int n)
        //{
        //    if ( n <= 10)
        //        return "Hardly any";

        //    if ( n <= 50)
        //        return "More than a handful!";

        //    if ( n == 101)
        //        return "101 DALMATIONS!!!";

        //    return "Woah that's a lot of dogs!";

        //}


        //static List<string> dogs = new List<string>()
        //{
        //    "Hardly any",
        //    "More than a handful!",
        //    "Woah that's a lot of dogs!",
        //    "101 DALMATIONS!!!"
        //};

        //public static string HowManyDalmatians(int n)
        //    =>  n <=  10 ? dogs[0] 
        //        : n <=  50 ? dogs[1] 
        //        : n == 101 ? dogs[3] 
        //        :            dogs[2];


        //public static string HowManyDalmatians(int n)
        //{
        //    string[] dogs = new string[]{"Hardly any","More than a handful!","Woah that's a lot of dogs!","101 DALMATIONS!!!"};
        //    string respond = n <= 10 ? dogs[0]:n <= 50 ? dogs[1] : n == 101 ? dogs[3] : dogs[2];
        //    return respond;
        //}

        //public static string HowManyDalmatians(int n)
        //{
        //    var dogs = new string []{"Hardly any",
        //        "More than a handful!",
        //        "Woah that's a lot of dogs!",
        //        "101 DALMATIONS!!!"
        //    };
        //    string respond = n <= 10 ? dogs[0] : n <= 50 ? dogs[1] : n == 101 ? dogs[3] : dogs[2];
        //    return respond;
        //}








    }
}