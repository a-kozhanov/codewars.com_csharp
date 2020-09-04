/*
https://www.codewars.com/kata/563fbac924106b8bf7000046/csharp

4 kyu
Breadcrumb Generator

As breadcrumb menùs are quite popular today, I won't digress much on explaining them, 
leaving the wiki link to do all the dirty work in my place.

What might not be so trivial is instead to get a decent breadcrumb from your current url. 
For this kata, your purpose is to create a function that takes a url, strips the first part (labelling it always HOME) 
and then builds it making each element but the last a <a> element linking to the relevant path; 
last has to be a <span> element getting the active class.

All elements need to be turned to uppercase and separated by a separator, given as the second parameter of the function; 
the last element can terminate in some common extension like .html, .htm, .php or .asp; if the name of the last element is index.something, 
you treat it as if it wasn't there, sending users automatically to the upper level folder.

A few examples can be more helpful than thousands of words of explanation, so here you have them:

Kata.GenerateBC("mysite.com/pictures/holidays.html", " : ") == '<a href="/">HOME</a> : <a href="/pictures/">PICTURES</a> : <span class="active">HOLIDAYS</span>';
Kata.GenerateBC("www.codewars.com/users/GiacomoSorbi", " / ") == '<a href="/">HOME</a> / <a href="/users/">USERS</a> / <span class="active">GIACOMOSORBI</span>';
Kata.GenerateBC("www.microsoft.com/docs/index.htm", " * ") == '<a href="/">HOME</a> * <span class="active">DOCS</span>';
Seems easy enough?

Well, probably not so much, but we have one last extra rule: 
if one element (other than the root/home) is longer than 30 characters, you have to shorten it, 
acronymizing it (i.e.: taking just the initials of every word); 
url will be always given in the format this-is-an-element-of-the-url and you should ignore words in this array while acronymizing: 
["the","of","in","from","by","with","and", "or", "for", "to", "at", "a"]; 
a url composed of more words separated by - and equal or less than 30 characters long needs to be just uppercased with hyphens replaced by spaces.

Ignore anchors (www.url.com#lameAnchorExample) and parameters (www.url.com?codewars=rocks&pippi=rocksToo) when present.

Examples:

You will always be provided valid url to webpages in common formats, so you probably shouldn't bother validating them.

If you like to test yourself with actual work/interview related kata, 
please also consider this one about building a string filter for Angular.js.

Special thanks to the colleague that, seeing my code and commenting that I worked on that as if it was I was on CodeWars, 
made me realize that it could be indeed a good idea for a kata :)
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class BreadcrumbGenerator
    {
        public static string GenerateBC(string url, string separator)
        {
            var wordsExclude = new[] {"THE", "OF", "IN", "FROM", "BY", "WITH", "AND", "OR", "FOR", "TO", "AT", "A"};
            var urlParts = new Uri(new UriBuilder(url).ToString()).Segments.Skip(1).Where(x => !x.Contains("index."));

            return string.Join(separator, urlParts.Select(s => s.Split('.')[0].TrimEnd('/').ToUpper()).Prepend("HOME")
                .Select((s, i) => new
                {
                    href = string.Concat(urlParts.Take(i)),
                    text = s.Length > 30
                        ? string.Concat(s.Split('-').Where(w => !wordsExclude.Contains(w)).Select(c => c[0]))
                        : s.Replace("-", " ")
                }).Select((x, i) =>
                    i < urlParts.Count()
                        ? $"<a href=\"/{x.href}\">{x.text}</a>"
                        : $"<span class=\"active\">{x.text}</span>"));
        }
    }
}