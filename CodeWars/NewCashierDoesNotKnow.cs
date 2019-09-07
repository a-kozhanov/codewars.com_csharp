using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


//
//https://www.codewars.com/kata/5d23d89906f92a00267bb83d/solutions/csharp


//New Cashier Does Not Know About Space or Shift

//Description:
//Some new cashiers started to work at your restaurant.
//They are good at taking orders, but they don't know how to capitalize words, or use a space bar!
//All the orders they create look something like this:
//"milkshakepizzachickenfriescokeburgerpizzasandwichmilkshakepizza"
//The kitchen staff are threatening to quit, because of how difficult it is to read the orders.
//Their preference is to get the orders as a nice clean string with spaces and capitals like so:
//"Burger Fries Chicken Pizza Pizza Pizza Sandwich Milkshake Milkshake Coke"
//The kitchen staff expect the items to be in the same order as they appear in the menu.
//The menu items are fairly simple, there is no overlap in the names of the items:

//1. Burger
//2. Fries
//3. Chicken
//4. Pizza
//5. Sandwich
//6. Onionrings
//7. Milkshake
//8. Coke

namespace CodeWars
{
    public class NewCashierDoesNotKnow
    {
        public static string GetOrder(string input)
        {
            var words = "Burger Fries Chicken Pizza Sandwich Onionrings Milkshake Coke".Split();
            var result = string.Empty;

            foreach (var word in words)
            {
                var countWord = 0;
                var index = input.IndexOf(word, 0, StringComparison.CurrentCultureIgnoreCase);
                while (index > -1)
                {
                    countWord++;
                    index = input.IndexOf(word, index + word.Length, StringComparison.CurrentCultureIgnoreCase);
                }
                result += string.Concat(Enumerable.Repeat($"{word} ", countWord));
            }

            return result.TrimEnd();
        }


        //public static class Kata
        //{
        //    public static string GetOrder(string input) =>
        //        string.Join(" ", new[] { "Burger", "Fries", "Chicken", "Pizza", "Sandwich", "Onionrings", "Milkshake", "Coke" }
        //            .SelectMany(f => Enumerable.Repeat(f, Regex.Matches(input, f.ToLower()).Count)));
        //}


        //public static string GetOrder(string input)
        //{
        //    var menu = new List<string>()
        //    {
        //        "Burger",
        //        "Fries",
        //        "Chicken",
        //        "Pizza",
        //        "Sandwich",
        //        "Onionrings",
        //        "Milkshake",
        //        "Coke"
        //    };

        //    StringBuilder result = new StringBuilder();
        //    foreach (var food in menu)
        //    {
        //        var lowerFood = food.ToLower();
        //        while (input.Contains(lowerFood))
        //        {
        //            result.Append($"{food} ");
        //            input = input.Remove(input.IndexOf(lowerFood), food.Length);
        //        }
        //    }
        //    return result.ToString().Trim();
        //}



        //public static string GetOrder(string input)
        //{
        //    StringBuilder correctOrder = new StringBuilder();
        //    string[] menu = new string[] { "Burger", "Fries", "Chicken", "Pizza", "Sandwich", "Onionrings", "Milkshake", "Coke" };

        //    foreach (string item in menu)
        //    {
        //        int minIndex = input.IndexOf(item.ToLower());
        //        while (minIndex != -1)
        //        {
        //            correctOrder.Append(item + " ");
        //            minIndex = input.IndexOf(item.ToLower(), minIndex + item.Length);
        //        }
        //    }

        //    return correctOrder.ToString().Trim();
        //}



        //public static string GetOrder(string input)
        //{
        //    string output = "";
        //    ArrayList menu = new ArrayList();
        //    menu.Add("Burger");
        //    menu.Add("Fries");
        //    menu.Add("Chicken");
        //    menu.Add("Pizza");
        //    menu.Add("Sandwich");
        //    menu.Add("Onionrings");
        //    menu.Add("Milkshake");
        //    menu.Add("Coke");

        //    foreach (string item in menu)
        //    {
        //        while (input.IndexOf(item.ToLower()) >= 0)
        //        {
        //            input = input.Remove(input.IndexOf(item.ToLower()), item.Length);
        //            output += input.Length > 0 ? item + " " : item;
        //        }
        //    }
        //    return output;
        //}


        //public static string GetOrder(string input)
        //    => string.Join(null, new List<string>() {
        //        "Burger",
        //        "Fries",
        //        "Chicken",
        //        "Pizza",
        //        "Sandwich",
        //        "Onionrings",
        //        "Milkshake",
        //        "Coke"
        //    }.Select(x => input.Contains(x.ToLower())
        //        ? string.Concat(Enumerable.Repeat($"{x} ", new Regex($"{x.ToLower()}").Matches(input).Count))
        //        : string.Empty)).Trim();



        //public static string GetOrder(string input)
        //{
        //    var menu = new List<string>
        //    {
        //        "Burger",
        //        "Fries",
        //        "Chicken",
        //        "Pizza",
        //        "Sandwich",
        //        "Onionrings",
        //        "Milkshake",
        //        "Coke"
        //    };

        //    return string.Join(" ",
        //        Regex.Matches(input, @"(" + string.Join('|', menu) + ")", RegexOptions.IgnoreCase)
        //            .Select(x => char.ToUpper(x.Value[0]) + x.Value.Substring(1))
        //            .OrderBy(x => menu.IndexOf(x)));
        //}


        //public static string GetOrder(string input)
        //{
        //    var result = new List<string>();
        //    new string[] { "Burger", "Fries", "Chicken", "Pizza", "Sandwich", "Onionrings", "Milkshake", "Coke" }
        //        .ToList().ForEach(o => result.AddRange(Enumerable.Repeat(o, Regex.Matches(input, o, RegexOptions.IgnoreCase).Count)));

        //    return string.Join(" ", result);
        //}



        //public static string GetOrder(string input)
        //{
        //    string[] products = { "Burger", "Fries", "Chicken", "Pizza", "Sandwich", "Onionrings", "Milkshake", "Coke" };
        //    var result = new List<string>();
        //    foreach (string item in products)
        //    {
        //        int times = input.Split(item.ToLower()).Length - 1;
        //        Enumerable.Range(0, times).ToList().ForEach(_ => result.Add(item));
        //    }
        //    return String.Join(' ', result);
        //}





    }
}