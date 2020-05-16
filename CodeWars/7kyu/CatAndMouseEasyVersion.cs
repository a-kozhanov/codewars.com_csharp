/*
https://www.codewars.com/kata/57ee24e17b45eff6d6000164/csharp

7 kyu
Cat and Mouse - Easy Version

You will be given a string (x) featuring a cat 'C' and a mouse 'm'. The rest of the string will be made up of '.'.
You need to find out if the cat can catch the mouse from it's current position. The cat can jump over three characters. So:
C.....m returns 'Escaped!' <-- more than three characters between
C...m returns 'Caught!' <-- as there are three characters between the two, the cat can jump.
*/

using System.Linq;

namespace CodeWars
{
    public class CatAndMouseEasyVersion
    {
        public static string CatMouse(string x)
        {
            //return x.Contains("....") ? "Escaped!" : "Caught!";
            return x.Length > 5 ? "Escaped!" : "Caught!";
        }
    }
}