/*
https://www.codewars.com/kata/fun-with-es6-classes-number-1-people-people-people/train/csharp
https://www.codewars.com/kata/56f7f8215d7c12c0e7000b19/solutions/csharp

8 kyu
Fun with ES6 Classes #1 - People, people, people

Time for some OOP fun!
Define a class Person with the following properties:

A constructor that accepts 4 arguments: firstName/FirstName (defaults to "John" if not set), 
lastName/LastName (defaults to "Doe" if not set), age/Age (defaults to 0 if not set) and gender/Gender (defaults to "Male" if not set). 
These should be stored in this.firstName/this.FirstName, this.lastName/this.LastName, this.age/this.Age and this.gender/this.Gender respectively.
A method sayFullName/SayFullName that accepts no arguments and returns the full name (e.g. "John Doe")
A class/static method greetExtraTerrestrials/GreetExtraTerrestrials that accepts one parameter raceName and returns "Welcome to Planet Earth raceName". 
For example, if the race name is "Martians", it should say "Welcome to Planet Earth Martians"
You may use any valid syntax you like; however, it is highly recommended that you complete this Kata using ES6 syntax and features.

Have fun! :D
*/

namespace CodeWars
{
    public class Person
    {
        public readonly string FirstName;
        public readonly string LastName;
        public readonly int Age;
        public readonly string Gender;

        public Person()
        {
            FirstName = "John";
            LastName = "Doe";
            Age = 0;
            Gender = "Male";
        }

        public Person(string firstName, string lastName, int age, string gender)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Gender = gender;
        }

        public string SayFullName()
        {
            return $"{FirstName} {LastName}";
        }

        public static string GreetExtraTerrestrials(string raceName)
        {
            return $"Welcome to Planet Earth {raceName}";
        }
    }
}


//public class Person
//{
//    public Person(string firstName = "John", string lastName = "Doe", int age = 0, string gender = "Male")
//    {
//        FirstName = firstName;
//        LastName = lastName;
//        Age = age;
//        Gender = gender;
//    }
//    public string SayFullName() => $"{FirstName} {LastName}".TrimEnd();
//    public static string GreetExtraTerrestrials(string raceName) => $"Welcome to Planet Earth {raceName}";
//    public string FirstName { get; private set; }
//    public string LastName { get; private set; }
//    public int Age { get; private set; }
//    public string Gender { get; private set; }
//}




//public class Person
//{
//    public string FirstName {get;set;}
//    public string LastName {get;set;}
//    public int Age {get;set;}
//    public string Gender {get;set;} 
//    public Person(string FirstName = "John", string LastName = "Doe", int Age = 0, string Gender = "Male") {
//        this.FirstName = FirstName;
//        this.LastName = LastName;
//        this.Age = Age;
//        this.Gender = Gender;
//    }

//    public string SayFullName() {
//        return FirstName + " " + LastName; 
//    }

//    public static string GreetExtraTerrestrials(string raceName) {
//        return "Welcome to Planet Earth " + raceName;
//    }

//}



//public class Person
//{

//    public string FirstName;
//    public string LastName;
//    public int Age;
//    public string Gender;

//    public Person(string FirstName = "John",
//        string LastName = "Doe",
//        int Age = 0,
//        string Gender = "Male")
//    {
//        this.FirstName = FirstName;
//        this.LastName = LastName;
//        this.Age = Age;
//        this.Gender = Gender;
//    }

//    public string SayFullName()
//    {
//        return this.FirstName + " " + this.LastName;
//    }

//    public static string GreetExtraTerrestrials(string raceName )
//    {
//        return string.Format("Welcome to Planet Earth {0}", raceName);
//    }

//}




//public class Person
//{
//    public string FirstName { get; set; }
//    public string LastName { get; set; }
//    public int Age { get; set; }
//    public string Gender { get; set; }

//    public Person(string firstName = "John", string lastName = "Doe", int age = 0, string gender = "Male")
//    {
//        this.FirstName = firstName;
//        this.LastName = lastName;
//        this.Age = age;
//        this.Gender = gender;
//    }

//    public string SayFullName()
//    {
//        return $"{FirstName} {LastName}";
//    }

//    public static string GreetExtraTerrestrials(string raceName)
//    {
//        return $"Welcome to Planet Earth {raceName}";
//    }
//}


