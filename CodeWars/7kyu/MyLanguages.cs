/*
https://www.codewars.com/kata/5b16490986b6d336c900007d/train/csharp
https://www.codewars.com/kata/5b16490986b6d336c900007d/solutions/csharp

7 kyu
My Languages

Your task
You are given a dictionary/hash/object containing some languages and your test results in the given languages. 
Return the list of languages where your test score is at least 60, in descending order of the results.

Note: There will be no duplicate values.

Examples
new Dictionary<string, int> {{"Java", 10}, {"Ruby", 80}, {"Python", 65}} => {"Ruby", "Python"}
new Dictionary<string, int> {{"Hindi", 60}, {"Greek", 71}, {"Dutch", 93}} => {"Dutch", "Greek", "Hindi"}
new Dictionary<string, int> {{"C++", 50}, {"ASM", 10}, {"Haskell", 20}} => {}
My other katas
If you enjoyed this kata then please try my other katas! :-)

Translations are welcome!
*/

using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class KataMyLanguages
    {
        public static IEnumerable<string> MyLanguages(Dictionary<string, int> results)
        {
            //return Enumerable.Select(results.Where(x => x.Value >= 60).OrderBy(x => -x.Value), x => x.Key);
            //var r = results.Where(x => x.Value >= 60).OrderByDescending(x => x.Value).Select(x => x.Key);
            //var r = results.Where(x => x.Value >= 60).OrderBy(x => -x.Value).Select(x => x.Key);
            //return results.Where(x => x.Value >= 60).OrderBy(x => -x.Value).Select(x => x.Key);
            return results.Where(x => x.Value > 59).OrderBy(x => -x.Value).Select(x => x.Key);
        }
    }
}