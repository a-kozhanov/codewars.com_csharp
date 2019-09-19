using System.Linq;

//https://www.codewars.com/kata/grasshopper-messi-goals-function/train/csharp
//https://www.codewars.com/kata/55f73be6e12baaa5900000d4/solutions/csharp

//Grasshopper - Messi goals function

//Messi goals function
//Messi is a soccer player with goals in three leagues:
//LaLiga
//Copa del Rey
//Champions.
//Complete the goals function to return his total goals (the sum) for all three leagues.
//Note: the parameter for this function will always be a valid number.
//Ex :
//goals(5,10,2) == 5+10+2 = 17


namespace CodeWars
{
    public class GrasshopperMessiGoals
    {
        public static int GetGoals(int laLigaGoals, int copaDelReyGoals, int championsLeagueGoals)
        {
            return laLigaGoals + copaDelReyGoals + championsLeagueGoals;
        }

        //        public static int GetGoals(params int[] goalsPerLeague) => goalsPerLeague.Sum();
        //
        //        public static int GetGoals(int laLigaGoals, int copaDelReyGoals, int championsLeagueGoals) => laLigaGoals + copaDelReyGoals + championsLeagueGoals;

    }
}