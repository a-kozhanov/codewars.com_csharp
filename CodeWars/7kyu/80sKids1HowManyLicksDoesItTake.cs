/*
https://www.codewars.com/kata/566091b73e119a073100003a/csharp

7 kyu
80's Kids #1: How Many Licks Does it Take?

How many licks does it take to get to the tootsie roll center of a tootsie pop?

A group of engineering students from Purdue University reported that its licking machine, 
modeled after a human tongue, took an average of 364 licks to get to the center of a Tootsie Pop. 
Twenty of the group's volunteers assumed the licking challenge-unassisted by machinery-and averaged 252 licks each to the center.

Your task, if you choose to accept it, 
is to write a function that will return the number of licks it took to get to the tootsie roll center of a tootsie pop, 
given some environmental variables.

Everyone knows it's harder to lick a tootsie pop in cold weather but it's easier if the sun is out. 
You will be given an object of environmental conditions for each trial paired with a value that will increase or decrease the number of licks. 
The environmental conditions all apply to the same trial.

Assuming that it would normally take 252 licks to get to the tootsie roll center of a tootsie pop, 
return the new total of licks along with the condition that proved to be most challenging (causing the most added licks) in that trial.

Example:

totalLicks({ "freezing temps": 10, "clear skies": -2 });
Should return:

"It took 260 licks to get to the tootsie roll center of a tootsie pop. The toughest challenge was freezing temps."
Other cases: If there are no challenges, the toughest challenge sentence should be omitted. 
If there are multiple challenges with the highest toughest amount, the first one presented will be the toughest. 
If an environment variable is present, it will be either a positive or negative integer. No need to validate.

Check out my other 80's Kids Katas:
80's Kids #1: How Many Licks Does It Take
80's Kids #2: Help Alf Find His Spaceship
80's Kids #3: Punky Brewster's Socks
80's Kids #4: Legends of the Hidden Temple
80's Kids #5: You Can't Do That on Television
80's Kids #6: Rock 'Em, Sock 'Em Robots
80's Kids #7: She's a Small Wonder
80's Kids #8: The Secret World of Alex Mack
80's Kids #9: Down in Fraggle Rock
80's Kids #10: Captain Planet
*/

using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class _80sKids1HowManyLicksDoesItTake
    {
        public string TotalLicks(Dictionary<string, int> env)
        {
            var licks = $"It took {252 + env.Values.Sum()} licks to get to the tootsie roll center of a tootsie pop.";
            var challenges = env.Where(x => x.Value > 0).OrderByDescending(x => x.Value).ToArray();
            return challenges.Any() ? $"{licks} The toughest challenge was {challenges.FirstOrDefault().Key}." : licks;
        }
    }
}