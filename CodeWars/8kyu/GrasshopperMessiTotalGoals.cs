/*
https://www.codewars.com/kata/grasshopper-messi-goals/train/csharp
https://www.codewars.com/kata/55ca77fa094a2af31f00002a/solutions/csharp

8 kyu
Grasshopper - Messi Goals

Messi's Goal Total
Use variables to find the sum of the goals Messi scored in 3 games

Information
Messi goal scoring statistics:

Competition	Goals
La Liga	43
Champions League	10
Copa del Rey	5
Define
Create three variables and store the appropriate values using the table above:

laLigaGoals
championsLeagueGoals
copaDelReyGoals
Create a fourth variable named totalGoals (javascript, C#) or total_goals (python, ruby). 
totalGoals/total_goals should store the sum of all of Messi's goals for this year.
*/

namespace CodeWars
{
    public class GrasshopperMessiGoalsTotal
    {
        public static int la_liga_goals = 43;
        public static int champions_league_goals = 10;
        public static int copa_del_rey_goals = 5;
        public static int total_goals = la_liga_goals + champions_league_goals + copa_del_rey_goals;
    }
}