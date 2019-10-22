

//https://www.codewars.com/kata/returning-strings/train/csharp
//https://www.codewars.com/kata/55a70521798b14d4750000a4/solutions/csharp

//Returning Strings
//8 kyu

//Make a function that will return a greeting statement that uses an input; your program should return, "Hello, <name> how are you doing today?".
//*[Make sure you type the exact thing I wrote or the program may not execute properly]*

using System;

namespace CodeWars
{
    public class ReturningStrings
    {
        public static string Greet(string name)
        {
            return $"Hello, {name} how are you doing today?";
        }

        //public static string Greet(string name)
        //{
        //    return String.Format("Hello, {0} how are you doing today?", name);
        //}


        //public static string Greet(string name)
        //{
        //    string str = "Hello,  how are you doing today?";
        //    return str.Insert(7, name);
        //}

        //public static string Greet(string name)
        //{
        //    return ("Hello, " + name.ToString() + " how are you doing today?");
        //}

        //public static string Greet(string name)
        //{
        //    return "Hello, <name> how are you doing today?".Replace("<name>", name);
        //}


        //public static string Greet(string name)
        //{
        //    return "Hello, " + name + " how are you doing today?";
        //}


    }
}