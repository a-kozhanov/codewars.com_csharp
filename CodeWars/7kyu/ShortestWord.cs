using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//https://www.codewars.com/kata/57cebe1dc6fdc20c57000ac9/train/csharp
//https://www.codewars.com/kata/57cebe1dc6fdc20c57000ac9/solutions/csharp

//Simple, given a string of words, return the length of the shortest word(s).
//String will never be empty and you do not need to account for different data types.


namespace CodeWars
{
    public static class ShortestWord
    {
        public static int FindShort(string s)
        {
            return s.Split(' ').Select(w => w.Length).Min();
        }

        //Best Practices
        //public static int FindShort(string s)
        //{
        //    return s.Split(' ').Min(x => x.Length);
        //}

    }
}
