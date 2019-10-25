
//https://www.codewars.com/kata/pirates-are-the-cannons-ready/train/csharp
//https://www.codewars.com/kata/5748a883eb737cab000022a6/solutions/csharp

//8 kyu
//Pirates!! Are the Cannons ready!??

//Ahoy Matey!
//Welcome to the seven seas.
//You are the captain of a pirate ship.
//You are in battle against the royal navy.
//You have cannons at the ready.... or are they?
//Your task is to check if the gunners are loaded and ready, if they are: Fire!
//If they aren't ready: Shiver me timbers!
//Your gunners for each test case are 4 or less.
//When you check if they are ready their answers are in a dictionary and will either be: aye or nay
//Firing with less than all gunners ready is non-optimum (this is not fire at will, this is fire by the captain's orders or walk the plank, dirty sea-dog!)
//If all answers are 'aye' then Fire! if one or more are 'nay' then Shiver me timbers!
//Also, check out the new Pirates!! Kata: https://www.codewars.com/kata/57e2d5f473aa6a476b0000fe


using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class PiratesCannonsReady
    {
        public static string CannonsReady(Dictionary<string, string> gunners)
        {
            return gunners.Any(gunner => gunner.Value != "aye") ? "Shiver me timbers!" : "Fire!";
        }


        //public static string CannonsReady(Dictionary<string, string> gunners)
        //{
        //    return gunners.ContainsValue("nay") ? "Shiver me timbers!" :"Fire!";
        //}


        //public static string CannonsReady(Dictionary<string, string> gunners)
        //{
        //    foreach (var pair in gunners)
        //    {
        //        if (pair.Value[0] == 'n')
        //        {
        //            return "Shiver me timbers!";
        //        }
        //    }

        //    return "Fire!";
        //}


        //public static string CannonsReady(Dictionary<string, string> gunners) => gunners.All(gunner => gunner.Value.Equals("aye")) ? "Fire!" : "Shiver me timbers!";


        //public static string CannonsReady(Dictionary<string, string> gunners)
        //{
        //    return  gunners.Count(x => x.Value.Equals("aye")) < gunners.Count() ? "Shiver me timbers!" :  "Fire!";
        //}


        //public static string CannonsReady(Dictionary<string, string> gunners)
        //{
        //    return gunners
        //               .Where(g => g.Value == "aye")
        //               .Count() >= gunners.Count ? "Fire!" : "Shiver me timbers!";
        //}


        //public static string CannonsReady(Dictionary<string, string> gunners)
        //{
        //    foreach (var v in gunners)
        //        if (v.Value != "aye")
        //            return "Shiver me timbers!";
        //    return "Fire!";
        //}


        //public static string CannonsReady(Dictionary<string, string> gunners)
        //{
        //    return true == gunners.ContainsValue("nay") ? "Shiver me timbers!" : "Fire!";
        //}


        //public static string CannonsReady(Dictionary<string, string> gunners)
        //{
        //    if (gunners.ContainsValue("nay") == false)
        //    {
        //        return "Fire!";
        //    }
        //    return "Shiver me timbers!";
        //}





    }
}