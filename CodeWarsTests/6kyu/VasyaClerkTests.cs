using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class VasyaClerkTests
    {
        [Test]
        public void Test1()
        {
            int[] peopleInLine = new int[] {25, 25, 50, 50};
            Assert.AreEqual("YES", VasyaClerk.Tickets(peopleInLine));
        }

        [Test]
        public void Test2()
        {
            int[] peopleInLine = new int[] {25, 100};
            Assert.AreEqual("NO", VasyaClerk.Tickets(peopleInLine));
        }
    }
}