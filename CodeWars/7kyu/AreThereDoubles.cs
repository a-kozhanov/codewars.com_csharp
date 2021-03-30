/*
https://www.codewars.com/kata/56a24b4d9f3671584d000039/csharp

7 kyu
Are there doubles?

Your job is to build a function which determines whether or not there are double characters in a string (including whitespace characters). For example aa, !! or .

You want the function to return true if the string contains double characters and false if not. The test should not be case sensitive; for example both aa & aA return true.

Examples:

  double_check("abca")
  #returns False
  
  double_check("aabc")
  #returns True
  
  double_check("a 11 c d")
  #returns True
  
  double_check("AabBcC")
  #returns True
  
  double_check("a b  c")
  #returns True
  
  double_check("a b c d e f g h i h k")
  #returns False
  
  double_check("2020")
  #returns False
  
  double_check("a!@€£#$%^&*()_-+=}]{[|\"':;?/>.<,~")
  #returns False
*/

using System.Text.RegularExpressions;

namespace CodeWars
{
    public class AreThereDoubles
    {
        public static bool Double_check(string strng)
        {
            return Regex.IsMatch(strng, "(?i)(.)\\1");
        }
    }
}