/*
https://www.codewars.com/kata/56f935002e6c0d55fa000d92/csharp

7 kyu
Fun with ES6 Classes #2 - Animals and Inheritance

Fun with ES6 Classes #2 - Animals and Inheritance
Overview
Preloaded for you in this Kata is a class Animal:

public class Animal
{
  public int Age;
  public int Legs;
  public string Name;
  public string Species;
  public string Status;
  
  public Animal(string name, int age, int legs, string species, string status)
  {
    this.Name = name;
    this.Age = age;
    this.Legs = legs;
    this.Species = species;
    this.Status = status;
  }
  
  public virtual string Introduce()
  {
    return $"Hello, my name is {this.Name} and I am {this.Age} years old.";
  }
}
Task
Define the following classes that inherit from Animal.

I. Shark
The constructor function for Shark should accept 3 arguments in total in the following order: name, age, status. All sharks should have a leg count of 0 (since they obviously do not have any legs) and should have a species of "shark".

II. Cat
The constructor function for Cat should accept the same 3 arguments as with Shark: name, age, status. Cats should always have a leg count of 4 and a species of "cat".

Furthermore, the introduce/Introduce method for Cat should be identical to the original except there should be exactly 2 spaces and the words "Meow meow!" after the phrase. For example:

Cat example = new Cat("Example", 10, "Happy);
example.Introduce() => "Hello, my name is Example and I am 10 years old.  Meow meow!"; // Notice the TWO spaces - very important
III. Dog
The Dog constructor should accept 4 arguments in the specified order: name, age, status, master. master is the name of the dog's master which will be a string. Furthermore, dogs should have 4 legs and a species of "dog".

Dogs have an identical introduce/Introduce method as any other animal, but they have their own method called greetMaster/GreetMaster which accepts no arguments and returns "Hello (insert_master_name_here)" (of course not the literal string but replace the (insert_master_name_here) with the name of the dog's master).
*/

namespace CodeWars
{
    public class FunES62AnimalsAndInheritance
    {
        public class Animal
        {
            public int Age;
            public int Legs;
            public string Name;
            public string Species;
            public string Status;

            public Animal(string name, int age, int legs, string species, string status)
            {
                this.Name = name;
                this.Age = age;
                this.Legs = legs;
                this.Species = species;
                this.Status = status;
            }

            public virtual string Introduce()
            {
                return $"Hello, my name is {this.Name} and I am {this.Age} years old.";
            }
        }


        public class Shark : Animal
        {
            public Shark(string name, int age, string status) : base(name, age, 0, "shark", status)
            {
            }
        }

        public class Cat : Animal
        {
            public Cat(string name, int age, string status) : base(name, age, 4, "cat", status)
            {
            }

            public override string Introduce() => base.Introduce() + "  Meow meow!";
        }

        public class Dog : Animal
        {
            private readonly string _master;

            public Dog(string name, int age, string status, string master) : base(name, age, 4, "dog", status)
            {
                _master = master;
            }

            public string GreetMaster() => $"Hello {_master}";
        }
    }
}