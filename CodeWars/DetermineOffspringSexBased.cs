/*
https://www.codewars.com/kata/determine-offspring-sex-based-on-genes-xx-and-xy-chromosomes/train/csharp
https://www.codewars.com/kata/56530b444e831334c0000020/solutions/csharp

8 kyu
Determine offspring sex based on genes XX and XY chromosomes

The male gametes or sperm cells in humans and other mammals are heterogametic and contain one of two types of sex chromosomes. 
They are either X or Y. The female gametes or eggs however, contain only the X sex chromosome and are homogametic.

The sperm cell determines the sex of an individual in this case. If a sperm cell containing an X chromosome fertilizes an egg, 
the resulting zygote will be XX or female. If the sperm cell contains a Y chromosome, then the resulting zygote will be XY or male.

Determine if the sex of the offspring will be male or female based on the X or Y chromosome present in the male's sperm.

If the sperm contains the X chromosome, return "Congratulations! You're going to have a daughter."; 
If the sperm contains the Y chromosome, return "Congratulations! You're going to have a son.";
*/

using System.Text.RegularExpressions;

namespace CodeWars
{
    public class DetermineOffspringSexBased
    {
        public static string ChromosomeCheck(string sperm)
        {
            return sperm == "XY"
                ? "Congratulations! You're going to have a son."
                : "Congratulations! You're going to have a daughter.";
        }


        //public static string ChromosomeCheck(string sperm)
        //{
        //    return $"Congratulations! You're going to have a {sperm == "XY" ? "son" : "daughter"}.";
        //}


        //public static string ChromosomeCheck(string s) => $"Congratulations! You're going to have a {s == "XY" ? "son" : "daughter"}.";

        //public static string ChromosomeCheck(string sperm)
        //{
        //    return sperm.Contains("Y") == true ? "Congratulations! You're going to have a son." : "Congratulations! You're going to have a daughter.";
        //}


        //public static string ChromosomeCheck(string sperm) => sperm == "XX" ? "Congratulations! You're going to have a daughter." : "Congratulations! You're going to have a son.";


        //public static string ChromosomeCheck(string sperm) =>
        //    sperm[1] == 'Y'
        //        ? "Congratulations! You're going to have a son."
        //        : "Congratulations! You're going to have a daughter.";


        //public static string ChromosomeCheck(string sperm)
        //{
        //    var child = sperm == "XX" ? "daughter" : "son";
        //    return $"Congratulations! You're going to have a {child}.";
        //}


        //public static string ChromosomeCheck(string sperm)
        //{
        //    string gender = sperm.Contains("Y") ? "son" : "daughter";
        //    return $"Congratulations! You're going to have a {gender}.";
        //}


        //public static string ChromosomeCheck(string s) =>
        //    Regex.IsMatch(s, "y|Y") ? "Congratulations! You're going to have a son." :
        //        "Congratulations! You're going to have a daughter.";


        //public static string ChromosomeCheck(string sperm)
        //{
        //    return Regex.IsMatch(sperm, @"Y") ?
        //        "Congratulations! You're going to have a son." :
        //        "Congratulations! You're going to have a daughter.";
        //}


        //public static string ChromosomeCheck(string sperm)
        //    => "Congratulations! You're going to have a " + (sperm.Contains("Y") ? "son" : "daughter") + ".";

    }
}