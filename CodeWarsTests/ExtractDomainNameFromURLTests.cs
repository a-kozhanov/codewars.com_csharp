using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class ExtractDomainNameFromUrlTests
    {
        // Test.assertEquals(domainName("http://google.com"), "google");
        // Test.assertEquals(domainName("http://google.co.jp"), "google");
        // Test.assertEquals(domainName("www.xakep.ru"), "xakep");
        // Test.assertEquals(domainName("https://youtube.com"), "youtube");

        [TestCase("google", "http://google.com")]
        [TestCase("google", "http://google.co.jp")]
        [TestCase("xakep", "www.xakep.ru")]
        [TestCase("youtube", "https://youtube.com")]
        public void BasicTests(string domain, string url)
        {
            Assert.AreEqual(domain, ExtractDomainNameFromUrl.DomainName(url));
        }
    }
}