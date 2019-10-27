using System;
using System.Linq;
using System.Text.RegularExpressions;

//https://www.codewars.com/kata/abbreviate-a-two-word-name/train/csharp
//https://www.codewars.com/kata/57eadb7ecd143f4c9c0000a3/solutions/csharp

//Abbreviate a Two Word Name

//Write a function to convert a name into initials. This kata strictly takes two words with one space in between them.
//The output should be two capital letters with a dot seperating them.
//It should look like this:
//Sam Harris => S.H
//Patrick Feeney => P.F

namespace CodeWars
{
    public class AbbreviateTwoWordName
    {
        public static string AbbrevName(string name)
        {
            return $"{name.Split()[0][0].ToString().ToUpper()}.{name.Split()[1][0].ToString().ToUpper()}";
        }

        //public static string AbbrevName(string name) => string.Join(".", name.Split(' ').Select(w => w[0])).ToUpper();


        //public static string AbbrevName(string name)
        //{
        //    string[] buf = name.Split(' ');

        //    var firstName = buf.First();
        //    var lastName = buf.Last();

        //    var oneUpper = Char.ToUpper(firstName.First());
        //    var twoUpper = Char.ToUpper(lastName.First());

        //    return $"{oneUpper}.{twoUpper}";
        //}


        //public static string AbbrevName(string name)
        //{
        //    string[] a = name.Split(' ').ToArray();
        //    return $"{a[0].Substring(0,1).ToUpper()}.{a[1].Substring(0,1).ToUpper()}";

        //}

        //public static string AbbrevName(string name) =>
        //    $"{name[0]}.{name[name.IndexOf(' ') + 1]}".ToUpper();


        //public static string AbbrevName(string s) => String.Join(".", s.Split(null).Select(r => r[0].ToString().ToUpper()));

        //public static string AbbrevName(string name)
        //    => string.Join(".",name.Split(' ').Select(w=>char.ToUpper(w[0])));


        //public static string AbbrevName(string name)
        //{
        //    return string.Join(".", name.ToUpper().Split(' ').Select(n => n.First()));
        //}

        //public static string AbbrevName(string name)
        //{

        //    //get the index of the space
        //    int posOfSpace = name.IndexOf(" ");

        //    //build a string with the first character, the period, and the first character AFTER the space
        //    string abbrevName = name.Substring(0, 1) + "." + name.Substring(posOfSpace+1, 1);

        //    //return the result in uppercase (since some random testcases had lowercase names)
        //    return abbrevName.ToUpper();
        //}


        //public static string AbbrevName(string name)
        //{
        //    return $"{(name.Substring(0 , 1)).ToUpper()}.{(name.Substring(name.IndexOf(" ") + 1, 1)).ToUpper()}";
        //}


        //public static string AbbrevName(string name)
        //{
        //    MatchCollection m = Regex.Matches(name,@"\b\w");
        //    return (m[0] + "." + m[1]).ToUpper();
        //}


        //public static string AbbrevName(string name) => $"{name.Split(' ')[0][0]}.{name.Split(' ')[1][0]}".ToUpper();

        //public static string AbbrevName(string name)
        //{
        //    string[] firstLast = name.Split(' ').ToArray();
        //    return $"{firstLast[0].Substring(0, 1).ToUpper()}.{firstLast[1].Substring(0, 1).ToUpper()}";
        //}

        //public static string AbbrevName(string name)
        //{
        //    string fName = name.Split(' ')[0];
        //    string lName = name.Split(' ')[1];
        //    string output = fName.ToUpper()[0] + "." + lName.ToUpper()[0];
        //    return output;
        //}

        //public static string AbbrevName(string name)
        //{
        //    return String.Format("{0}.{1}", Char.ToUpper(name[0]), Char.ToUpper(name[name.IndexOf(' ')+1]));
        //}

        //public static string AbbrevName(string name)
        //{
        //    return string.Join(".",name.Split(' ').Select(x => x.ToUpper().First()));
        //}


        //public static string AbbrevName(string name)
        //{
        //    return string.Join(".", name.Split(" ").Select(x => x[0].ToString().ToUpper()));
        //}

        //public static string AbbrevName(string name)
        //{
        //    var arr = name.ToUpperInvariant().Split(" ").Select(x => x[0]);
        //    return     string.Join('.',arr);
        //}

        //public static string AbbrevName(string name) => string.Join(".",name.Split(" ").Select(x=> x[0]).ToList()).ToUpper();
    }
}