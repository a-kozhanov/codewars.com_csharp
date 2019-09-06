
//https://www.codewars.com/kata/grasshopper-personalized-message/train/csharp
//https://www.codewars.com/kata/5772da22b89313a4d50012f7/solutions/csharp

//Grasshopper - Personalized Message

//Personalized greeting
//Create a function that gives a personalized greeting.This function takes two parameters: name and owner.

//Use conditionals to return the proper message:
//case	return
//name equals owner   'Hello boss'
//otherwise   'Hello guest'

namespace CodeWars
{
    public class GrasshopperPersonalizedMessage
    {
        public static string Greet(string name, string owner)
        {
            return name == owner ? "Hello boss" : "Hello guest";
        }

        //public static string Greet(string name, string owner)
        //{
        //    return $"Hello {name == owner ? "boss" : "guest"}";
        //}

        //public static string Greet(string name, string owner) => $"Hello {(name.Equals(owner) ? "boss" : "guest")}";

        //public static string Greet(string name, string owner)
        //    => string.Format("Hello {0}", name == owner ? "boss" : "guest");




    }
}