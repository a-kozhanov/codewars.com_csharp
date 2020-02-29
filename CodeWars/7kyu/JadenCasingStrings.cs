/*
https://www.codewars.com/kata/5390bac347d09b7da40006f6/train/csharp
https://www.codewars.com/kata/5390bac347d09b7da40006f6/solutions/csharp

7 kyu
Jaden Casing Strings

Jaden Smith, the son of Will Smith, is the star of films such as The Karate Kid (2010) and After Earth (2013). 
Jaden is also known for some of his philosophy that he delivers via Twitter. When writing on Twitter, 
he is known for almost always capitalizing every word. For simplicity, 
you'll have to capitalize each word, check out how contractions are expected to be in the example below.

Your task is to convert strings to how they would be written by Jaden Smith. 
The strings are actual quotes from Jaden Smith, 
but they are not capitalized in the same way he originally typed them.

Example:
Not Jaden-Cased: "How can mirrors be real if our eyes aren't real"
Jaden-Cased:     "How Can Mirrors Be Real If Our Eyes Aren't Real"
Link to Jaden's former Twitter account @officialjaden via archive.org
*/

using static System.Globalization.CultureInfo;

namespace CodeWars
{
    public static class JadenCasingStrings
    {
        public static string ToJadenCase(this string phrase)
        {
            //return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(phrase);
            return CurrentCulture.TextInfo.ToTitleCase(phrase);
        }

        // public static string ToJadenCase(this string phrase)
        // {
        //     return String.Join(" ", phrase.Split().Select(i => Char.ToUpper(i[0]) + i.Substring(1)));
        // }


        // public static string ToJadenCase(this string phrase)
        // {
        //     TextInfo text = new CultureInfo("en-US",false).TextInfo;
        //     return text.ToTitleCase(phrase);
        // }


        // public static string ToJadenCase(this string phrase)
        // {
        //     return string.Join(" ", phrase.Split(' ').Select(str => char.ToUpper(str[0]) + str.Substring(1)));
        // }


        // public static string ToJadenCase(this string phrase)
        // {
        //     return Regex.Replace(phrase, @"(:?^|[ ])([a-z])", m => m.Value.ToUpper());
        // }


        // public static string ToJadenCase(this string phrase)
        // {
        //     return System.Globalization.CultureInfo.InvariantCulture.TextInfo.ToTitleCase(phrase);
        // }


        // public static string ToJadenCase(this string phrase)
        // {
        //     return Regex.Replace(phrase, @"(^|\s)[a-z]", m => m.Value.ToUpper());
        // }

        // public static string ToJadenCase(this string phrase)
        // {
        //     return System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(phrase.ToLower());
        // }

        // public static string ToJadenCase(this string phrase)
        // {
        //     TextInfo myTI = new CultureInfo("en-US").TextInfo;
        //     return myTI.ToTitleCase(phrase);
        // }
    }
}