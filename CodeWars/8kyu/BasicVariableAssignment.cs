
//https://www.codewars.com/kata/basic-variable-assignment/train/csharp
//https://www.codewars.com/kata/50ee6b0bdeab583673000025/solutions/csharp

//Basic variable assignment
//8 kyu

//This code should store "codewa.rs" as a variable called name but it's not working. Can you figure out why?


namespace CodeWars
{
    public class BasicVariableAssignment
    {
        public static string A = "code";
        public static string B = "wa.rs";
        public static string Name = A + B;
    }
}