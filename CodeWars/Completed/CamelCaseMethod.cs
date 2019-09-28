
//https://www.codewars.com/kata/camelcase-method/train/csharp
//https://www.codewars.com/kata/587731fda577b3d1b0001196/solutions/csharp

//CamelCase Method


//Write simple .camelCase method (camel_case function in PHP, CamelCase in C# or camelCase in Java) for strings. All words must have their first letter capitalized without spaces.
//For instance:
//camelCase("hello case"); // => "HelloCase"
//camelCase("camel case word"); // => "CamelCaseWord"
//Don't forget to rate this kata! Thanks :)


using System;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public static class CamelCaseMethod
    {
        public static string CamelCase(this string str)
        {
            var sb = new StringBuilder();
            foreach (var w in str.Trim().Split()) sb.Append(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(w));
            return sb.ToString();
        }


        //public static string CamelCase(this string str)
        //{
        //    TextInfo cultInfo = new CultureInfo("en-US", false).TextInfo;
        //    str = cultInfo.ToTitleCase(str);
        //    str = str.Replace(" ", "");
        //    return str;
        //}


        //public static string CamelCase(this string str)
        //{
        //    return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str).Replace(" ", String.Empty);
        //}

        //public static string CamelCase(this string str)
        //{
        //    var words = str.Split(' ');
        //    var finalString = string.Empty;

        //    foreach(var word in words)
        //    {
        //        finalString += word.Length > 0 ? (word.Substring(0, 1).ToUpper() + word.Substring(1)) : string.Empty; 
        //    }

        //    return finalString;
        //}


        //public static string CamelCase(this string str)  
        //{  
        //    string capsMe = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str);
        //    return capsMe.Replace(" ", "");
        //}


        //public static string CamelCase(this string str)  
        //{  
        //    TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
        //    return ti.ToTitleCase(str).Replace(" ", "");
        //}


        //public static string CamelCase(this string str)  
        //{  
        //    var titleCase = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str).Split(' ');
        //    return string.Concat(titleCase);
        //}


        //public static string CamelCase(this string str)  
        //{  
        //    return string.Join("",str.Split(' ').Select(x=>x==""?"":x.Substring(0,1).ToUpper()+x.Substring(1)).ToArray());
        //}


        //public static class Problem
        //{
        //    public static string CamelCase(this string str) =>  CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str).Replace(" ", String.Empty);
        //}


        //public static string CamelCase(this string str)  
        //{  
        //    var regex = new Regex(@"\b[a-z]");
        //    return regex.Replace(str, m => m.ToString().ToUpper()).Replace(" ", "");
        //}


        //public static string CamelCase(this string str)  
        //{  
        //    string returnStr = string.Empty;
        //    str.Trim().Split(' ').ToList().ForEach(x => returnStr += string.IsNullOrEmpty(x) ? x : x.ToCharArray().FirstOrDefault().ToString().ToUpper() + (x.Length > 1 ? x.Substring(1) : string.Empty));

        //    return returnStr;
        //}



        //public static string CamelCase(this string str)  
        //{ 
        //    return String.Join(null, str.Split(' ').Where(s => s != "").Select(s => s[0].ToString().ToUpper() + s.Substring(1)));
        //}


        //public static string CamelCase(this string str) =>
        //    string.Concat(str.Split((char[])null, StringSplitOptions.RemoveEmptyEntries)
        //        .Select(s => s.Substring(0, 1).ToUpperInvariant() + s.Substring(1).ToLowerInvariant()));



        //public static string CamelCase(this string str)  
        //{  
        //    return string.Join("", str.Split(' ')
        //        .Where(x => !string.IsNullOrEmpty(x))
        //        .Select(x => $"{x.Substring(0, 1).ToUpper()}{x.Remove(0, 1)}"));
        //}



        //public static string CamelCase(this string str)  
        //{  
        //    TextInfo cultInfo = new CultureInfo("en-US", false).TextInfo;
        //    return cultInfo.ToTitleCase(str).Replace(" ", "");
        //}



        //public static string CamelCase(this string str)  
        //{  
        //    return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str).Replace(" ","");
        //}


        //public static string CamelCase(this string str)  
        //{
        //    //your code here
        //    return string.Join("", System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(str.ToLower()).ToString().Split(' '));
        //}






    }
}