

//https://www.codewars.com/kata/is-he-gonna-survive/train/csharp
//https://www.codewars.com/kata/59ca8246d751df55cc00014c/solutions/csharp

//Is he gonna survive?
//8 kyu

//A hero is on his way to the castle to complete his mission.
//However, he's been told that the castle is surrounded with a couple of powerful dragons! each dragon takes 2 bullets to be defeated,
//our hero has no idea how many bullets he should carry..
//Assuming he's gonna grab a specific given number of bullets and move forward to fight another specific given number of dragons, will he survive?

//Return True if yes, False otherwise :)

namespace CodeWars
{
    public class IsHeGonnaSurvive
    {
        public static bool Hero(int bullets, int dragons)
        {
            return bullets / 2 >= dragons;
        }

        //public static bool Hero(int bullets, int dragons)
        //{
        //    return dragons*2 <= bullets;
        //}


        //public static bool Hero(int bullets, int dragons)
        //{
        //    return bullets>=dragons*2;
        //}


        //public static bool Hero(int bullets, int dragons)
        //{
        //    return bullets >= dragons << 1;
        //}




    }
}