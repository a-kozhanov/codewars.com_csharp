/*
https://www.codewars.com/kata/577bd8d4ae2807c64b00045b/csharp

7 kyu
Two fighters, one winner.

Create a function that returns the name of the winner in a fight between two fighters.

Each fighter takes turns attacking the other and whoever kills the other first is victorious. Death is defined as having health <= 0.

Each fighter will be a Fighter object/instance. See the Fighter class below in your chosen language.

Both health and damagePerAttack (damage_per_attack for python) will be integers larger than 0. You can mutate the Fighter objects.

Example:
public class Fighter {
  public string Name;
  public int Health, DamagePerAttack;
  public Fighter(string name, int health, int damagePerAttack) {
    this.Name = name;
    this.Health = health;
    this.DamagePerAttack = damagePerAttack;
  }
}
*/

namespace CodeWars
{
    public class Fighter
    {
        public string Name;
        public int Health, DamagePerAttack;

        public Fighter(string name, int health, int damagePerAttack)
        {
            this.Name = name;
            this.Health = health;
            this.DamagePerAttack = damagePerAttack;
        }
    }

    public class TwoFightersOneWinner
    {
        public static string declareWinner(Fighter fighter1, Fighter fighter2, string firstAttacker)
        {
            var att = (fighter1.Health - 1) / fighter2.DamagePerAttack;
            var def = (fighter2.Health - 1) / fighter1.DamagePerAttack;

            return att > def ? fighter1.Name : def > att ? fighter2.Name : firstAttacker;


            // var att = fighter1.Name == firstAttacker ? fighter1 : fighter2;
            // var def = fighter1.Name != firstAttacker ? fighter1 : fighter2;
            //
            // var attacker = firstAttacker == fighter1.Name ? fighter1 : fighter2;
            // var defender = firstAttacker == fighter1.Name ? fighter2 : fighter1;
            //
            // while (true)
            // {
            //     def.Health -= att.DamagePerAttack;
            //     if (def.Health <= 0) return att.Name;
            //
            //     att.Health -= def.DamagePerAttack;
            //     if (att.Health <= 0) return def.Name;
            // }
        }
    }
}