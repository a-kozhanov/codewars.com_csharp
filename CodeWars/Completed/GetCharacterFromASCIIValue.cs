
//https://www.codewars.com/kata/get-character-from-ascii-value/train/csharp
//https://www.codewars.com/kata/55ad04714f0b468e8200001c/solutions/csharp

//get character from ASCII Value

//Write a function which takes a number and returns the corresponding ASCII char for that value.
//Example:
//get_char(65) # => 'A'
//For ASCII table, you can refer to http://www.asciitable.com/


using System;

namespace CodeWars
{
    public class GetCharacterFromASCIIValue
    {
        public static char GetChar(int charcode)
        {
            return (char)charcode;
        }

        //public static char GetChar(int charcode)
        //{
        //    return Convert.ToChar(charcode);   
        //}

    }
}