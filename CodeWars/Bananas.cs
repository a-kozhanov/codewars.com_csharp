using System.Collections.Generic;

//https://www.codewars.com/kata/bananas/train/csharp
//

//Bananas

//Given a string of letters a, b, n how many different ways can you make the word "banana" by crossing out various letters and then reading left-to-right?
//(Use - to indicate a crossed-out letter)

//Example

//Input
//bbananana

//Output
//b-anana--
//b-anan--a
//b-ana--na
//b-an--ana
//b-a--nana
//b---anana
//-banana--
//-banan--a
//-bana--na
//-ban--ana
//-ba--nana
//-b--anana

//Notes
//You must return all possible bananas, but the order does not matter
//The example output above is formatted for readibility. Please refer to the example tests for expected format of your result.

namespace CodeWars
{
    public class KataBananas
    {
        public static HashSet<string> Bananas(string s)
        {
            //var result = new List<string>();
            //for (var i = 0; i < s.Length; i++)
            //{
            //    for (var j = i; j < s.Length; j++)
            //    {

            //    }
            //}

            //int index = 0;

            //while (true)
            //{
            //    string str = s;
            //    for (var i = 0; i < s.Length; i++)
            //    {

            //    }
            //}


            return new HashSet<string>();
        }
    }
}