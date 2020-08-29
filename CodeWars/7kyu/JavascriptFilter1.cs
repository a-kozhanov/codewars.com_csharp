/*
https://www.codewars.com/kata/525d9b1a037b7a9da7000905/csharp

7 kyu
Javascript filter - 1

While developing a website, you detect that some of the members have troubles logging in. 
Searching through the code you find that all logins ending with a "_" make problems. 
So you want to write a function that takes an array of pairs of login-names and e-mails, 
and outputs an array of all login-name, e-mails-pairs from the login-names that end with "_".

If you have the input-array:

[ [ "foo", "foo@foo.com" ], [ "bar_", "bar@bar.com" ] ]
it should output

[ [ "bar_", "bar@bar.com" ] ]
You have to use the filter-method which returns each element of the array for which the filter-method returns true.

https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Array/filter
*/

using System.Linq;

namespace CodeWars
{
    public class JavascriptFilter1
    {
        public static string[][] search_names(string[][] logins)
        {
            //return logins.Where(x => x[0].EndsWith('_')).ToArray();
            return logins.Where(x => x[0][^1] == '_').ToArray();
        }
    }
}