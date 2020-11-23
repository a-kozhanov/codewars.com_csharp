/*
https://www.codewars.com/kata/5b3e1dca3da310a4390000f3/csharp

7 kyu
Offload your work!

You are the best freelancer in the city. 
Everybody knows you, but what they don't know, is that you are actually offloading your work to other freelancers and and you rarely need to do any work. You're living the life!

To make this process easier you need to write a method called workNeeded to figure out how much time you need to contribute to a project.

Giving the amount of time in minutes needed to complete the project and an array of pair values representing other freelancers' time in [Hours, Minutes] format ie. 
[[2, 33], [3, 44]] calculate how much time you will need to contribute to the project (if at all) and return a string depending on the case.

If we need to contribute time to the project then return "I need to work x hour(s) and y minute(s)"
If we don't have to contribute any time to the project then return "Easy Money!"
*/

using System.Linq;

namespace CodeWars
{
    public class OffloadYourWork
    {
        public static string WorkNeeded(int projectMinutes, int[][] freelancers)
        {
            // return (projectMinutes - freelancers.Sum(i => i[0] * 60 + i[1])) switch
            // {
            //     { } m when m > 0 => $"I need to work {m / 60} hour(s) and {m % 60} minute(s)",
            //     _ => "Easy Money!"
            // };

            // projectMinutes -= freelancers.Sum(i => i[0] * 60 + i[1]);
            // return projectMinutes > 0
            //     ? $"I need to work {projectMinutes / 60} hour(s) and {projectMinutes % 60} minute(s)"
            //     : "Easy Money!";


            //var minutes = projectMinutes - freelancers.Aggregate(0, (a, b) => a + b[0] * 60 + b[1]);
            var minutes = projectMinutes - freelancers.Sum(i => i[0] * 60 + i[1]);
            return minutes > 0 ? $"I need to work {minutes / 60} hour(s) and {minutes % 60} minute(s)" : "Easy Money!";


            // return minutes > 0
            //     ? string.Format("I need to work {0} hour(s) and {1} minute(s)", minutes / 60, minutes % 60)
            //     : "Easy Money!";
        }
    }
}