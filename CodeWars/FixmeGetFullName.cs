/*
https://www.codewars.com/kata/597c684822bc9388f600010f/train/csharp

7 kyu
FIXME: Get Full Name

The code provided is supposed return a person's Full Name given their first and last names.

But it's not working properly.

Notes
The first and/or last names are never null (None in Python), but may be empty.

Task
Fix the bug so we can all go home early.
*/

namespace CodeWars
{
    public class FixmeGetFullName
    {
        // public string FullName { get; }
        // public Dinglemouse(string firstName, string lastName) => FullName = $"{firstName} {lastName}".Trim();
        // public FixmeGetFullName(string firstName, string lastName) => FullName = $"{firstName} {lastName}".Trim();

        public string FullName { get; }

        // public Dinglemouse(string firstName, string lastName)
        public FixmeGetFullName(string firstName, string lastName)
        {
            FullName = $"{firstName} {lastName}".Trim();
        }
    }
}