/*
https://www.codewars.com/kata/classy-extentions/train/csharp
https://www.codewars.com/kata/55a14aa4817efe41c20000bc/solutions/csharp


8 kyu
Classy Extentions

Classy Extensions, this kata is mainly aimed at the new JS ES6 Update introducing extends keyword. 
You will be preloaded with the Animal class, so you should only edit the Cat class.

Task
Your task is to complete the Cat class which Extends Animal and replace the speak method to return the cats name + meows. e.g.
'Mr Whiskers meows.'
The name attribute is passed with this.name (JS), @name (Ruby) or self.name (Python).

Reference: JS, Ruby, Python.
*/

namespace CodeWars
{
    public class ClassyExtentions
    {
        public class Animal
        {
            protected string Name;

            public Animal(string name)
            {
                Name = name;
            }

            public virtual string Speak()
            {
                return "";
            }
        }

        public class Cat : Animal
        {
            public Cat(string name) : base(name) { }
            public override string Speak() => $"{Name} meows.";
        }

    }
}


//public class Cat : Animal
//{
//    public Cat(string name) : base(name)
//    {

//    }
//    public override string Speak() => $"{this.Name} meows.";
//}


