
//https://www.codewars.com/kata/how-many-lightsabers-do-you-own/train/csharp
//https://www.codewars.com/kata/51f9d93b4095e0a7200001b8/solutions/csharp

//How many lightsabers do you own?

//Description:
//Inspired by the development team at Vooza, write the function howManyLightsabersDoYouOwn/how_many_light_sabers_do_you_own that

//accepts the name of a programmer, and
//returns the number of lightsabers owned by that person.
//The only person who owns lightsabers is Zach, by the way. He owns 18, which is an awesome number of lightsabers. Anyone else owns 0.

//howManyLightsabersDoYouOwn("anyone else") == 0
//howManyLightsabersDoYouOwn("Zach") == 18

namespace CodeWars
{
    public class KataHowManyLightsabersDoYouOwn
    {
        public static int HowManyLightsabersDoYouOwn(string name)
        {
            return name == "Zach" ? 18 : 0;
        }
    }
}