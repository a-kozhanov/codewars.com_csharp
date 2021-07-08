/*
https://www.codewars.com/kata/5630c850ed4343c1d0000083/csharp

7 kyu
A (no more) bugs trilogy: Episode 3 - Make a Player

Pac succesfully passed the first & second test.
He just received the last message from the Academy,

This is your last test, if you pass, your application will be accepted. You have 45 minutes.

Good Luck

Pac has to create a Football Player object with the following attributes :

Name      => (string)
Position  => (string)
Age       => (int)
Dribbling => (int)
Pass      => (int)
Shoot     => (int)
Note: If applicable, these properties need to be public.

Example
Player player = new Player("Player", "Right Winger", 25, 75, 90, 65);
player.Name => "Player"
player.Position => "Right Winger"
player.Age => 25
player.Dribbling => 75
player.Pass => 90
player.Shoot => 65
Feedbacks are appreciated!
*/

namespace CodeWars
{
    public class BugsTrilogyEpisode3MakePlayer
    {
        // public Player(string name, string position, int age, int dribbling, int pass, int shoot)
        public BugsTrilogyEpisode3MakePlayer(string name, string position, int age, int dribbling, int pass, int shoot)
        {
            Name = name;
            Position = position;
            Age = age;
            Dribbling = dribbling;
            Pass = pass;
            Shoot = shoot;
        }

        public readonly string Name;
        public readonly string Position;
        public readonly int Age;
        public readonly int Dribbling;
        public readonly int Pass;
        public readonly int Shoot;
    }
}