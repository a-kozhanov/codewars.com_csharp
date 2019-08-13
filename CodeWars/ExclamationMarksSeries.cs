
//https://www.codewars.com/kata/57faf7275c991027af000679
//

//Exclamation marks series #6: Remove n exclamation marks in the sentence from left to right
//8 kyu


//Description:
//Remove n exclamation marks in the sentence from left to right. n is positive integer.

//Examples
//remove("Hi!",1) === "Hi"
//remove("Hi!",100) === "Hi"
//remove("Hi!!!",1) === "Hi!!"
//remove("Hi!!!",100) === "Hi"
//remove("!Hi",1) === "Hi"
//remove("!Hi!",1) === "Hi!"
//remove("!Hi!",100) === "Hi"
//remove("!!!Hi !!hi!!! !hi",1) === "!!Hi !!hi!!! !hi"
//remove("!!!Hi !!hi!!! !hi",3) === "Hi !!hi!!! !hi"
//remove("!!!Hi !!hi!!! !hi",5) === "Hi hi!!! !hi"
//remove("!!!Hi !!hi!!! !hi",100) === "Hi hi hi"

//Note
//Please don't post issue about difficulty or duplicate.


using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class ExclamationMarksSeries
    {
        public static string Remove(string s, int n)
        {
            var result = "";
            var count = 0;

            foreach (var c in s)
                if (c == '!' && count < n)
                    count++;
                else
                    result += c;

            return result;
        }


        //public static string Remove(string s, int n) => new Regex("!").Replace(s, "", n);

        //public static string Remove(string s, int n)
        //{
        //    return string.Concat(s.Where(c => c == '!' ? n-- <= 0 : true));
        //}

        //public static string Remove(string s, int n)
        //{
        //    var builder = new StringBuilder();
        //    foreach (var c in s)
        //    {
        //        if (c == '!' && n > 0)
        //            n--;
        //        else
        //            builder.Append(c);
        //    }

        //    return builder.ToString();
        //}


        //public static string Remove(string s, int n)
        //{
        //    return String.Concat(s.Where(x => !(x == '!' && 0 < n--)));
        //}


        //public static string Remove(string s, int n)
        //{
        //    //coding and coding....
        //    for(int i =1; i<=n; i++)
        //    {
        //        int index = s.IndexOf('!');

        //        if(index != -1)
        //            s = s.Remove(index,1);
        //    }
        //    return s;
        //}




    }
}