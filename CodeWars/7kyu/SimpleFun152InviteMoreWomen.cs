/*
https://www.codewars.com/kata/simple-fun-number-152-invite-more-women/train/csharp
https://www.codewars.com/kata/58acfe4ae0201e1708000075/solutions/csharp

7 kyu
Simple Fun #152: Invite More Women?

Task
King Arthur and his knights are having a New Years party. Last year Lancelot was jealous of Arthur, 
because Arthur had a date and Lancelot did not, and they started a duel.

To prevent this from happening again, 
Arthur wants to make sure that there are at least as many women as men at this year's party. 
He gave you a list of integers of all the party goers.

Arthur needs you to return true if he needs to invite more women or false if he is all set.

Input/Output
[input] integer array L ($a in PHP)

An array (guaranteed non-associative in PHP) representing the genders of the attendees, 
where -1 represents women and 1 represents men.

2 <= L.length <= 50

[output] a boolean value

true if Arthur need to invite more women, false otherwise.
*/

using System.Linq;

namespace CodeWars
{
    public class SimpleFun152InviteMoreWomen
    {
        public bool InviteMoreWomen(int[] L)
        {
            //return L.Count(x => x == -1) < L.Count(x => x == 1);
            return L.Sum() > 0;
        }

        // public bool InviteMoreWomen(int[] L)
        // {
        //     //coding and coding..
        //     int sum = 0;
        //     foreach (var i in L)
        //     {
        //         sum += i;
        //     }
        //
        //     return sum > 0;
        // }

        // public bool InviteMoreWomen(int[] L) => (L.Length - L.Where(x => x == -1).Count()) > (L.Length - L.Where(x => x == 1).Count()) ? true : false;


        // public bool InviteMoreWomen(int[] L)=>L.Count(t => t == 1) > L.Length / 2;
    }
}