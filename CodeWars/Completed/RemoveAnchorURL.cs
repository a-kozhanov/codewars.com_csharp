using System;
using System.Collections.Generic;
using System.Text;

//https://www.codewars.com/kata/remove-anchor-from-url/train/csharp
//https://www.codewars.com/kata/51f2b4448cadf20ed0000386/solutions/csharp

//Complete the function/method so that it returns the url with anything after the anchor(#) removed.

//Examples:
//Kata.RemoveUrlAnchor("www.codewars.com#about") => "www.codewars.com"
//Kata.RemoveUrlAnchor("www.codewars.com?page=1") => "www.codewars.com?page=1"


namespace CodeWars
{
    public class RemoveAnchorURL
    {
        public static string RemoveUrlAnchor(string url)
        {
            return url.Split("#")[0];
        }
    }
}
