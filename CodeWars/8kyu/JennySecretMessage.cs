
//https://www.codewars.com/kata/jennys-secret-message/train/csharp
//https://www.codewars.com/kata/55225023e1be1ec8bc000390/solutions/csharp

//Jenny's secret message
//8 kyu

//Jenny has written a function that returns a greeting for a user. However, she's in love with Johnny,
//and would like to greet him slightly different. She added a special case to her function, but she made a mistake.
//Can you help her?

using System;

namespace CodeWars
{
    public class JennySecretMessage
    {
        public static string greet(string name)
        {
            return name == "Johnny" ? "Hello, my love!" : $"Hello, {name}!";
        }


        //public static string greet(string name)
        //{
        //    return $"Hello, {name == "Johnny" ? "my love" : name}!";
        //}


        //public static string greet(string name)
        //{
        //    return String.Format("Hello, {0}!", name.Equals("Johnny") ? "my love" : name);
        //}


        //public static string greet(string name)
        //{
        //    return string.Format("Hello, {0}!", name == "Johnny" ? "my love" : name);
        //}




    }
}