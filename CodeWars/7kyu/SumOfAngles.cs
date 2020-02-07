/*
https://www.codewars.com/kata/5a03b3f6a1c9040084001765/train/csharp
https://www.codewars.com/kata/5a03b3f6a1c9040084001765/solutions/csharp

7 kyu
Sum of angles

Find the total sum of angles in an n sided shape. N will be greater than 2.
*/


namespace CodeWars
{
    public class SumOfAngles
    {
        public static int Angle(int n)
        {
            return 180 * (n - 2);
            //return n * 180 - 360;
        }
    }
}