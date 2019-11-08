
/*
https://www.codewars.com/kata/find-the-position/train/csharp
https://www.codewars.com/kata/5808e2006b65bff35500008f/solutions/csharp

8 kyu
Find the position!

When provided with a letter, return its position in the alphabet.
Input :: "a"
Ouput :: "Position of alphabet: 1"
This kata is meant for beginners. Rank and upvote to bring it out of beta
*/

namespace CodeWars
{
    public class FindPosition
    {
        public static string Position(char alphabet)
        {
            return $"Position of alphabet: {alphabet - 96}";
        }


        //public static string Position(char alphabet)
        //{
        //    return $"Position of alphabet: {(1 + alphabet - 'a')}";
        //}


        //public static string Position(char alphabet)
        //{
        //    return $"Position of alphabet: {char.ToUpper(alphabet)-64}";
        //}


        //public static string Position(char letter)
        //{
        //    return string.Format("Position of alphabet: {0}", letter - 'a' + 1);
        //}


        //public static string Position(char alphabet)
        //{
        //    return "Position of alphabet: " + (alphabet-96);
        //}


        //public static string Position(char alphabet)
        //{
        //    return "Position of alphabet: " + alphabet % 32;
        //}


        //public static string Position(char alphabet)
        //{
        //    return "Position of alphabet: " + (char.ToUpper(alphabet) - 64).ToString();
        //}

        //public static string Position(char alphabet)
        //{
        //    for (char c = 'a'; c <= 'z'; c++)
        //    {
        //        if (c == alphabet)
        //            return $"Position of alphabet: {c-'a'+1}";
        //    }
        //    return string.Empty;
        //}


        //public static string Position(char letter)
        //{
        //    return $"Position of alphabet: {letter - 'a' + 1}";
        //}


    }
}