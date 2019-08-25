using System.Collections.Generic;
using System.Linq;


//https://www.codewars.com/kata/counting-duplicates/train/csharp
//

//Counting Duplicates

//Count the number of Duplicates
//Write a function that will return the count of distinct case-insensitive alphabetic characters and numeric
//digits that occur more than once in the input string. The input string can be assumed to contain only
//alphabets(both uppercase and lowercase) and numeric digits.

//Example
//"abcde" -> 0 # no characters repeats more than once
//"aabbcde" -> 2 # 'a' and 'b'
//"aabBcde" -> 2 # 'a' occurs twice and 'b' twice (`b` and `B`)
//"indivisibility" -> 1 # 'i' occurs six times
//"Indivisibilities" -> 2 # 'i' occurs seven times and 's' occurs twice
//"aA11" -> 2 # 'a' and '1'
//"ABBA" -> 2 # 'A' and 'B' each occur twice

namespace CodeWars
{
    public class CountingDuplicates
    {
        public static int DuplicateCount(string str)
        {
            int count = 0;
            List<int> num = new List<int>() { 0 };

            //IEnumerable<char> ch = str.ToUpper().ToCharArray().ToList();
            str = str.ToUpper();
            for (var i = 0; i < str.Length - 1; i++)
            {
                if (char.ToUpper(str[i]) == char.ToUpper(str[i + 1])) count++;
                else
                {
                    if (count >= 0) num.Add(count + 1);
                    //else num.Add(count);
                    count = 0;
                }
            }

            return num.Max();
        }
    }
}