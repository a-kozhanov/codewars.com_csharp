/*
https://www.codewars.com/kata/keep-up-the-hoop/train/csharp
https://www.codewars.com/kata/keep-up-the-hoop/solutions/csharp

8 kyu
Keep up the hoop

Alex just got a new hula hoop, he loves it but feels discouraged because his little brother is better than him
Write a program where Alex can input (n) how many times the hoop goes round and it will return him an encouraging message :)
-If Alex gets 10 or more hoops, return the string "Great, now move on to tricks".
-If he doesn't get 10 hoops, return the string "Keep at it until you get it".
*/


namespace CodeWars
{
    public class KeepUpHoop
    {
        public static string HoopCount(int n)
        {
            return n > 10 ? "Great, now move on to tricks" : "Keep at it until you get it";
        }
    }
}