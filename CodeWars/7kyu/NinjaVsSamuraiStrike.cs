/*
https://www.codewars.com/kata/ninja-vs-samurai-strike/train/csharp
https://www.codewars.com/kata/517b0f33cd023d848d000001/solutions/csharp

7 kyu
Ninja vs Samurai: Strike

Something is wrong with our Warrior class. 
The strike method does not work correctly. 
The following shows an example of this code being used:

var ninja = new Warrior("Ninja");
var samurai = new Warrior("Samurai");

samurai.Strike(ninja, 3);
// ninja.Health should == 70
Can you figure out what is wrong?
*/

using System;

namespace CodeWars
{
    public class NinjaVsSamuraiStrike
    {
        public class Warrior
        {
            private string _name;
            public int Health { get; private set; } = 100;

            public Warrior(string name)
            {
                _name = name;
            }

            public void Strike(Warrior enemy, int swings) => enemy.Health -= 10 * swings;
            // {
            //     enemy.Health = Math.Max(0, enemy.Health - swings * 10);
            // }
        }
    }
}


// using System;
//
// public class Warrior
// {
//     private string name;
//
//     public Warrior(string name)
//     {
//         this.name = name;
//     }
//
//     public int Health { get; set; } = 100;
//
//     public void Strike(Warrior enemy, int swings)
//     {
//         enemy.Health = Math.Max(0, enemy.Health - (swings * 10));
//     }
// }