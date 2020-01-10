/*
https://www.codewars.com/kata/codewars-leaderboard-climber/train/csharp
https://www.codewars.com/kata/57d28215264276ea010002cf/solutions/csharp

7 kyu
Codewars Leaderboard Climber

We all want to climb the leaderboard. Even given some of the massive scores on there, it's nice to know how close you are...
In this kata you will be given a username and their score, your score (not your real score) and you need to calculate how many kata you need to complete to beat their score, by 1 point exactly.
As this is the easy version (harder one to folow at some point in the future), let's assume only Beta kata and 8kyu kata are available. Worth 3 and 1 point respectively.
Return a string like this: 'To beat "user"'s score, I must complete "x" Beta kata and "y" 8kyu kata.'.
If the total number of kata you need to complete > 1000, add 'Dammit!' to the end of the string also - like so:
'To beat "user"'s score, I must complete 'x' Beta kata and 'y' 8kyu kata. Dammit!'.
If your score is higher than the user's already, return 'Winning!'. If they are equal, return 'Only need one!'.
You are looking to complete as few kata as possible to get to your target
*/

namespace CodeWars
{
    public class CodewarsLeaderboardClimber
    {
        public static string LeaderB(string user, int us, int ys)
        {
            return us < ys ? "Winning!" :
                us == ys ? "Only need one!" :
                $"To beat {user}'s score, I must complete {ys = (us -= ys) / 3} Beta kata and {us = us % 3} 8kyu kata.{(ys + us > 1000 ? " Dammit!" : "")}";
        }
    }
}

// public static string LeaderB(string user, int user_score, int your_score)
// {
// var difference = user_score - your_score;
//     
// string answer = "Only need one!";
//     if(difference < 0) answer = "Winning!";
//     else if(difference > 0)
// {    
//     answer = $"To beat {user}'s score, I must complete {difference / 3} Beta kata and {difference % 3} 8kyu kata.";
//     if(difference > 3000) answer += " Dammit!";      
// }
// return answer;
// }


// public static string LeaderB(string user, int user_score, int your_score)
// {
// if(your_score > user_score){return "Winning!";}
// if(your_score - user_score == 0){return "Only need one!";}
//     
// string curse = "";
// int beta = (int)((user_score - your_score)/3);
// int kyu = user_score - (3*beta) - your_score;
//     if(beta + kyu > 1000){ curse = " Dammit!"; }
// return $"To beat {user}'s score, I must complete {beta} Beta kata and {kyu} 8kyu kata.{curse}";    
// }


// public static string LeaderB(string user, int user_score, int your_score)
// {
// int d = user_score - your_score;
//     if (d == 0) return "Only need one!";
// if (d < 0) return "Winning!";
// int x = d / 3;
// int y = d - (x * 3);
// string r = $"To beat {user}'s score, I must complete {x} Beta kata and {y} 8kyu kata.";
//     if(x + y > 1000) r += " Dammit!";
// return r;
// }