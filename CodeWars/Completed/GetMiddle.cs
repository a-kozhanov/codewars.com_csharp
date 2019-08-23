//    https://www.codewars.com/kata/56747fd5cb988479af000028/train/csharp
//    https://www.codewars.com/kata/get-the-middle-character/solutions

//    Get the Middle Character
//    You are going to be given a word.Your job is to return the middle character of the word. If the word's length is odd, return the middle character. If the word's length is even, return the middle 2 characters.

//#Examples:
//    Kata.getMiddle("test") should return "es"

//    Kata.getMiddle("testing") should return "t"

//    Kata.getMiddle("middle") should return "dd"

//    Kata.getMiddle("A") should return "A"

//#Input
//    A word(string) of length 0 < str< 1000 (In javascript you may get slightly more than 1000 in some test cases due to an error in the test cases). You do not need to test for this. This is only here to tell you that you do not need to worry about your solution timing out.

//# Output
//    The middle character(s) of the word represented as a string.

namespace CodeWars
{
    public static class GetMiddle
    {
        public static string getMiddle(string s)
        {
            return string.IsNullOrEmpty(s)
                ? s
                : s.Substring((s.Length - 1) / 2, 2 - s.Length % 2);
        }

        public static string getMiddle2(string s)
        {
            int length = s.Length;

            if (length == 1) return s;

            if (length % 2 == 0)
            {
                return s.Substring(length / 2 - 1, 2);
            }
            else
            {
                return s.Substring(length / 2, 1);
            }
        }
    }
}
