using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class StringTemplatesBugFixing5Tests
    {
        [Test]
        public static void FixedTests()
        {
            Assert.AreEqual("I like Cheese, Milk, Chocolate!", StringTemplatesBugFixing5.buildString(new string[] { "Cheese", "Milk", "Chocolate" }));
            Assert.AreEqual("I like Cheese, Milk!", StringTemplatesBugFixing5.buildString(new string[] { "Cheese", "Milk" }));
            Assert.AreEqual("I like Chocolate!", StringTemplatesBugFixing5.buildString(new string[] { "Chocolate" }));
        }
    }
}