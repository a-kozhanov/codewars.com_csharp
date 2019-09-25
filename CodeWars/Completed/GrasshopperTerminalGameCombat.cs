

//https://www.codewars.com/kata/grasshopper-terminal-game-combat-function-1/train/csharp
//https://www.codewars.com/kata/586c1cf4b98de0399300001d/solutions/csharp

//Grasshopper - Terminal game combat function

//Create a combat function that takes the player's current health and the amount of damage recieved,
//and returns the player's new health. Health can't be less than 0.

using System;

namespace CodeWars
{
    public class GrasshopperTerminalGameCombat
    {
        public static float Combat(float health, float damage)
        {
            var result = health - damage;
            return result < 0 ? 0 : result;
        }


        //public static float Combat(float health, float damage)
        //{
        //    return (health >= damage) ? health - damage : 0;
        //}

        //public static float Combat(float health, float damage)
        //{
        //    return Math.Max(0, health - damage);
        //}

        //public static float Combat(float health, float damage)
        //{
        //    return (health -= damage) > 0 ? health : 0;
        //}

        //public static float Combat(float health, float damage)
        //{
        //    return damage - health > 0 ? 0 : Math.Abs(damage - health);
        //}

        //public static float Combat(float health, float damage)
        //{
        //    //throw new NotImplementedException();
        //    if (damage > health) return 0;
        //    return health - damage;
        //}

    }
}