/*
https://www.codewars.com/kata/52a6b34e43c2484ac10000cd/csharp

7 kyu
Naughty or Nice?

Happy Holidays fellow Code Warriors!
It's almost Christmas! That means Santa's making his list, and checking it twice. 
Unfortunately, elves accidentally mixed the Naughty and Nice list together! Santa needs your help to save Christmas!

Save Christmas!
Santa needs you to write two functions. Both of the functions accept a sequence of objects. 
The first one returns a sequence containing only the names of the nice people, 
and the other returns a sequence containing only the names of the naughty people. 
Return an empty sequence [] if the result from either of the functions contains no names.

The objects in the passed will represent people. Each object contains two properties: name and wasNice.
name - The name of the person
wasNice - True if the person was nice this year, false if they were naughty

Person Object Examples
In C# the class Person is pre-loaded with the properties:

public string Name { get; set; }
public bool WasNice { get; set; }
Test Examples
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public static class NaughtyOrNice
    {
        public class Person
        {
            public string Name { get; set; }
            public bool WasNice { get; set; }
        }

        public static IEnumerable<string> GetNiceNames(IEnumerable<Person> people) => FilterNames(people, true);
        public static IEnumerable<string> GetNaughtyNames(IEnumerable<Person> people) => FilterNames(people, false);

        private static IEnumerable<string> FilterNames(IEnumerable<Person> people, bool nice)
        {
            return people.Where(p => p.WasNice == nice).Select(p => p.Name);
        }
    }
}