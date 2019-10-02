
//https://www.codewars.com/kata/switch-it-up/train/csharp
//https://www.codewars.com/kata/switch-it-up/solutions

//Switch it Up!
//8 kyu


//When provided with a number between 0-9, return it in words.
//Input :: 1
//Output :: "One".
//If your language supports it, try using a switch statement.


using System.Collections.Generic;

namespace CodeWars
{
    public class KataSwitchItUp
    {
        public static string SwitchItUp(int number)
        {
            switch (number)
            {
                case 0: return "Zero";
                case 1: return "One";
                case 2: return "Two";
                case 3: return "Three";
                case 4: return "Four";
                case 5: return "Five";
                case 6: return "Six";
                case 7: return "Seven";
                case 8: return "Eight";
                case 9: return "Nine";
                default: return "";
            }
        }


        //public static string SwitchItUp(int number)
        //{
        //    var dic = new Dictionary<int, string>()
        //    {
        //        {1, "One"},
        //        {2, "Two"},
        //        {3, "Three"},
        //        {4, "Four"},
        //        {5, "Five"},
        //        {6, "Six"},
        //        {7, "Seven"},
        //        {8, "Eight"},
        //        {9, "Nine"},
        //        {0, "Zero"}      
        //    };
        //    return dic[number];
        //}

        //public static string SwitchItUp(int number)
        //{
        //    string[] numbers =
        //        { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten" };

        //    return numbers[number];
        //}


        //public static string SwitchItUp(int number)
        //{
        //    return  new[] { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine"}[number];
        //}


        //public static string SwitchItUp(int number)
        //{
        //    return new Dictionary<int, string> {{ 1, "One" },
        //        { 2, "Two"},
        //        { 3, "Three"},
        //        { 4, "Four"},
        //        { 5, "Five"},
        //        { 6, "Six"},
        //        { 7, "Seven"},
        //        { 8, "Eight"},
        //        { 9, "Nine"},
        //        { 0, "Zero"}}[number];
        //}


        //enum Digit{Zero,One,Two,Three,Four,Five,Six,Seven,Eight,Nine}

        //public static string SwitchItUp(int number)
        //{
        //    return ((Digit)number).ToString();
        //}





    }
}