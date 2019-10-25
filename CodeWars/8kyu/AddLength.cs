
//https://www.codewars.com/kata/add-length/train/csharp
//https://www.codewars.com/kata/559d2284b5bb6799e9000047/solutions/csharp

//8 kyu
//Add Length


//What if we need the length of the words separated by a space to be added at the end of that same word and have it returned as an array?

//Kata.AddLength("apple ban")    => new string[] {"apple 5", "ban 3"};
//Kata.AddLength("you will win") => new string[] {"you 3", "will 4", "win 3"};
//Your task is to write a function that takes a String and returns an Array/list with the length of each word added to each element .

//Note: String will have at least one element; words will always be separated by a space.


using System.Linq;

namespace CodeWars
{
    public class KataAddLength
    {
        public static string[] AddLength(string str)
        {
            return str.Split().Select(x => $"{x} {x.Length}").ToArray();
        }

        //public static string[] AddLength(string str)
        //    => str.Split(' ').Select(e=> $"{e} {e.Length}").ToArray();


        //public static string[] AddLength(string str)
        //{
        //    return str.Split(' ').Select(o => o + " " + o.Length).ToArray();
        //}


        //public static string[] AddLength(string str)
        //{
        //    string[] inputArr = str.Split(' ');
        //    string[] resultArr = new string[inputArr.Count()];

        //    for (int i = 0; i < inputArr.Length; i++)
        //    {
        //        resultArr[i] = $"{inputArr[i]} {inputArr[i].Length}";
        //    }

        //    return resultArr;
        //}


        //public static string[] AddLength(string str)
        //{
        //    return str.Split(' ').Select(s => string.Format("{0} {1}", s, s.Length)).ToArray();
        //}

    }
}