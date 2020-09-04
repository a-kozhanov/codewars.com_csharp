using System;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class BreadcrumbGeneratorTests
    {
        private string[] urls = new string[]
        {
            "mysite.com/pictures/holidays.html",
            "www.codewars.com/users/GiacomoSorbi?ref=CodeWars",
            "www.microsoft.com/docs/index.htm#top",
            "mysite.com/very-long-url-to-make-a-silly-yet-meaningful-example/example.asp",
            "www.very-long-site_name-to-make-a-silly-yet-meaningful-example.com/users/giacomo-sorbi",
            "https://www.linkedin.com/in/giacomosorbi",
            "www.agcpartners.co.uk/",
            "www.agcpartners.co.uk",
            "https://www.agcpartners.co.uk/index.html",
            "http://www.agcpartners.co.uk"
        };

        private string[] seps = new string[] {" : ", " / ", " * ", " > ", " + ", " * ", " * ", " # ", " >>> ", " % "};


        private string[] anss = new string[]
        {
            "<a href=\"/\">HOME</a> : <a href=\"/pictures/\">PICTURES</a> : <span class=\"active\">HOLIDAYS</span>",
            "<a href=\"/\">HOME</a> / <a href=\"/users/\">USERS</a> / <span class=\"active\">GIACOMOSORBI</span>",
            "<a href=\"/\">HOME</a> * <span class=\"active\">DOCS</span>",
            "<a href=\"/\">HOME</a> > <a href=\"/very-long-url-to-make-a-silly-yet-meaningful-example/\">VLUMSYME</a> > <span class=\"active\">EXAMPLE</span>",
            "<a href=\"/\">HOME</a> + <a href=\"/users/\">USERS</a> + <span class=\"active\">GIACOMO SORBI</span>",
            "<a href=\"/\">HOME</a> * <a href=\"/in/\">IN</a> * <span class=\"active\">GIACOMOSORBI</span>",
            "<span class=\"active\">HOME</span>",
            "<span class=\"active\">HOME</span>",
            "<span class=\"active\">HOME</span>",
            "<span class=\"active\">HOME</span>"
        };

        [Test]
        public void ExampleTests()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"\nTest With: {urls[i]}");
                Console.WriteLine(anss[i]);
                if (i == 5)
                    Console.WriteLine(
                        "\nThe one used in the above test was my LinkedIn Profile; if you solved the kata this far and manage to get it, feel free to add me as a contact, message me about the language that you used and I will be glad to endorse you in that skill and possibly many others :)\n\n ");

                Assert.AreEqual(anss[i], BreadcrumbGenerator.GenerateBC(urls[i], seps[i]));
            }
        }
    }
}