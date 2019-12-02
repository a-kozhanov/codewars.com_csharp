/*
https://www.codewars.com/kata/grasshopper-variable-assignment-debug/train/csharp
https://www.codewars.com/kata/grasshopper-variable-assignment-debug/solutions

8 kyu
Grasshopper - Variable Assignment Debug

Variable assignment
Fix the variables assigments so that this code stores the string 'devLab' in the variable name.
*/

namespace CodeWars
{
    public class GrasshopperVariableAssignmentDebug
    {
        public const string a = "dev";
        public const string b = "Lab";
        public static string name = a + b;
    }
}