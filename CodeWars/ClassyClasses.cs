/*
https://www.codewars.com/kata/classy-classes/train/csharp
https://www.codewars.com/kata/55a144eff5124e546400005a/solutions/csharp

8 kyu
Classy Classes

Basic Classes, this kata is mainly aimed at the new JS ES6 Update introducing classes
Task
Your task is to complete this Class, the Person class has been created. You must fill in the Constructor method to accept a name as string and an age as number, complete the get Info property and getInfo method/Info getter which should return
johns age is 34
Reference: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/using-properties

*/

namespace CodeWars
{
    public class ClassyClasses
    {
        public ClassyClasses(string name, int age)
        {
            _name = name;
            _age = age;
        }

        private string _name;
        private int _age;

        public object Info => $"{_name}s age is {_age}";
    }
}