/*
https://www.codewars.com/kata/color-ghost/train/csharp
https://www.codewars.com/kata/53f1015fa9fe02cbda00111a/solutions/csharp

8 kyu
Color Ghost

Create a class Ghost

Ghost objects are instantiated without any arguments.

Ghost objects are given a random color attribute of white" or "yellow" or "purple" or "red" when instantiated

ghost = new Ghost();
ghost.color //=> "white" or "yellow" or "purple" or "red"

*/

using System;
using System.Collections.Generic;

namespace CodeWars
{
    public class ColorGhost
    {
        public enum GhostColors
        {
            white = 1,
            yellow = 2,
            purple = 3,
            red = 4
        }

        public string color
        {
            get
            {
                var values = Enum.GetValues(typeof(GhostColors));
                var random = new Random();
                return values.GetValue(random.Next(values.Length)).ToString();
            }
        }

        public string GetColor()
        {
            return color;
        }

    }

}


//public class Ghost
//{
//    private static Random _rnd = new Random();
//    private static List<String> _colors = new List<String>{"white", "yellow", "purple", "red"};
//    public String GetColor(){
//        return _colors[_rnd.Next(_colors.Count)];
//    }
//}



//public class Ghost
//{
//    private readonly string[] Colors = {"white", "yellow", "purple", "red"};
//    public string GetColor() { return Colors[new Random().Next(0, 4)]; }
//}



//public class Ghost
//{
//    private static string[] colors = {"white", "yellow", "purple", "red"};
//    private string color;

//    public Ghost()
//    {
//        color = colors[new Random().Next(colors.Length)];
//    }

//    public string GetColor()
//    {
//        return color;
//    }
//}




//public class Ghost
//{
//    private string[] array = { "white", "yellow", "purple", "red" };
//    public string result = "";

//    Random _random = new Random();

//    public Ghost()
//    {
//        result = array[_random.Next(array.Length)];
//    }

//    public string GetColor()
//    {
//        return result;
//    }
//}


//public class Ghost
//{
//    private static readonly string[] colors = new string[] { "white", "yellow", "purple", "red" };
//    private string color = colors[new Random().Next(colors.Length)];
//    public string GetColor()
//    {
//        return color;
//    }
//}



//public class Ghost
//{
//    private string color;

//    public string GetColor()
//    {
//        return color ?? (color = new []{"white", "yellow", "purple", "red"}[(new Random()).Next(0, 4)]);
//    }
//}



//public class Ghost
//{
//    private static readonly string[] colors = { "white", "purple", "red", "yellow" };    

//    public string GetColor() 
//    {
//        return colors[DateTime.Now.Millisecond % colors.Length];
//    }
//}

