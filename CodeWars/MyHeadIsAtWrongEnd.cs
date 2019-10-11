
//https://www.codewars.com/kata/my-head-is-at-the-wrong-end/train/csharp
//https://www.codewars.com/kata/56f699cd9400f5b7d8000b55/solutions/csharp

//My head is at the wrong end!
//8 kyu


//You're at the zoo... all the meerkats look weird. Something has gone terribly wrong - someone has gone and switched their heads and tails around!
//Save the animals by switching them back. You will be given an array which will have three values (tail, body, head).
//It is your job to re-arrange the array so that the animal is the right way round (head, body, tail).
//Same goes for all the other arrays/lists that you will get in the tests: you have to change the element positions with the same exact logics - simples!


using System.Linq;

namespace CodeWars
{
    public class MyHeadIsAtWrongEnd
    {
        public static string[] FixTheMeerkat(string[] arr)
        {
            return arr.Reverse().ToArray();
        }
    }
}