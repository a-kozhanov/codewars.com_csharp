/*


6 kyu
Decipher this!

You are given a secret message you need to decipher. Here are the things you need to know to decipher it:

For each word:

the second and the last letter is switched (e.g. Hello becomes Holle)
the first letter is replaced by its character code (e.g. H becomes 72)
Note: there are no special characters used, only letters and spaces

Examples

decipherThis('72olle 103doo 100ya'); // 'Hello good day'
decipherThis('82yade 115te 103o'); // 'Ready set go'
*/

using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class KataDecipherThis
    {
        public static string DecipherThis(string s)
        {
            return string.Join(" ", s
                .Split()
                .Select(x => Regex.Replace(x, @"(\d+)(.?)(.*?)(.?)$", m =>
                    (char) int.Parse(m.Groups[1].Value) +
                    m.Groups[4].Value +
                    m.Groups[3].Value +
                    m.Groups[2].Value))
            );
        }
    }
}