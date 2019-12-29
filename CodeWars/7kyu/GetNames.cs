/*
https://www.codewars.com/kata/getnames/train/csharp
https://www.codewars.com/kata/514a677421607afc99000002/solutions/csharp

7 kyu
getNames()

The following code is not giving the expected results. Can you figure out what the issue is?
The following is an example of data that would be passed in to the function.

public class Person
{
  public int Age;
  public string Name;

  public Person(string name = "John", int age = 21)
  {
    Age = age;
    Name = name;
  }
}

Person[] data = new Person[]
{
  new Person("Joe", 20),
  new Person("Bill", 30),
  new Person("Kate", 23)
};

Kata.GetNames(data) => new string[] {"Joe", "Bill", "Kate"};
*/

using System.Linq;

namespace CodeWars
{
    public class KataGetNames
    {
        public class Person
        {
            public Person(string name, int age)
            {
                Age = age;
                Name = name;
            }

            public int Age { get; }
            public string Name { get; }
        }

        public static string[] GetNames(Person[] data)
        {
            return data.Select(p => p.Name).ToArray();
        }
    }
}