using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class JavascriptFilter1Tests
    {
        [Test]
        public void Test1()
        {
            string[][] a = {new[] {"foo", "foo@foo.com"}, new[] {"bar_", "bar@bar.com"}};
            string[][] b = {new[] {"bar_", "bar@bar.com"}};
            Assert.That(b, Is.EquivalentTo(JavascriptFilter1.search_names(a)));
        }

        [Test]
        public void Test2()
        {
            string[][] a = {new[] {"foo_", "foo@foo.com"}, new[] {"bar_", "bar@bar.com"}};
            string[][] b = {new[] {"foo_", "foo@foo.com"}, new[] {"bar_", "bar@bar.com"}};
            Assert.That(b, Is.EquivalentTo(JavascriptFilter1.search_names(a)));
        }

        [Test]
        public void Test3()
        {
            string[][] a = {new[] {"foo", "foo@foo.com"}, new[] {"bar", "bar@bar.com"}};
            string[] b = new string[0];
            Assert.That(b, Is.EquivalentTo(JavascriptFilter1.search_names(a)));
        }
    }
}