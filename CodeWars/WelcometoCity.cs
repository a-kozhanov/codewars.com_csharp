/*
https://www.codewars.com/kata/welcome-to-the-city/train/csharp
https://www.codewars.com/kata/5302d846be2a9189af0001e4/solutions/csharp

8 kyu
Welcome to the City

Create a method sayHello/say_hello/SayHello that takes as input a name, city, and state to welcome a person. 
Note that name will be an array consisting of one or more values that should be joined together with one space betweeen each, 
and the length of the name array in test cases will vary.

Example:

Kata.SayHello(new String[]{"John", "Smith"}, "Phoenix", "Arizona")
This example will return the string Hello, John Smith! Welcome to Phoenix, Arizona!

 */

using System;
using System.Linq;
using System.Text;

namespace CodeWars
{
    public class WelcomeToCity
    {
        public static string SayHello(string[] name, string city, string state)
        {
            return $"Hello, {string.Join(" ", name.Select(x => x))}! Welcome to {city}, {state}!";
        }


        //public static string SayHello(string[] name, string city, string state) =>
        //    $"Hello, {string.Join(" ", name)}! Welcome to {city}, {state}!";


        //public static string SayHello(string[] name, string city, string state)
        //{ 
        //    return $"Hello, {String.Join(" ", name)}! Welcome to {city}, {state}!";
        //}


        //public static string SayHello(string[] name, string city, string state)
        //{
        //    return String.Format("Hello, {0}! Welcome to {1}, {2}!", String.Join(" ", name), city, state);
        //}


        //public static string SayHello(string[] name, string city, string state)
        //{
        //    return "Hello, " + string.Join(" ", name) +"! Welcome to " + city + ", " + state + "!";
        //}


        //public static string SayHello(string[] name, string city, string state)
        //{
        //    string name2 = name[0];
        //    for (int i = 1; i < name.Length; i++)
        //        name2 += " " + name[i];

        //    return  ("Hello, " + name2 + "! Welcome to " + city + ", " + state + "!");
        //}



        //public static string SayHello(string[] name, string city, string state)
        //{
        //    string newName = String.Join(" ", name);

        //    return $"Hello, {newName}! Welcome to {city}, {state}!";
        //}


        //public static string SayHello(string[] name, string city, string state)
        //{
        //    StringBuilder sb = new StringBuilder("Hello, ");    
        //    foreach(string x in name)
        //    {
        //        sb.Append(x + " ");
        //    }
        //    sb.Remove(sb.Length - 1, 1); //remove trailing space
        //    sb.Append("! Welcome to " + city + ", " + state + "!");
        //    return sb.ToString();
        //}


        //public static string SayHello(string[] names, string city, string state)
        //{
        //    return $"Hello, {string.Join(" ", names)}! Welcome to {city}, {state}!";
        //}

    }

}