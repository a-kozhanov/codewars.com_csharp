/*
https://www.codewars.com/kata/514a024011ea4fb54200004b/

5 kyu
Extract the domain name from a URL

Write a function that when given a URL as a string, parses out just the domain name and returns it as a string. For example:

domain_name("http://github.com/carbonfive/raygun") == "github" 
domain_name("http://www.zombie-bites.com") == "zombie-bites"
domain_name("https://www.cnet.com") == "cnet"
*/

using System;
using System.Linq;

namespace CodeWars
{
    public static class ExtractDomainNameFromUrl
    {
        public static string DomainName(string url)
        {
            return url.Replace("http://", "")
                .Replace("https://", "")
                .Replace("www.", "")
                .Split('.')[0];

            //return new UriBuilder(url).Uri.Authority.Split(".").Select(x => (x.Length, x)).Max().x;
        }
    }
}