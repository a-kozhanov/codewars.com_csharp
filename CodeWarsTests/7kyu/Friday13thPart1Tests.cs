using System.Collections.Generic;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class Friday13thPart1Tests
    {
        [Test]
        public void ExampleTest()
        {
            Dictionary<string, int> counselors = new Dictionary<string, int>
            {
                {"Mike", 7},
                {"Alysa", 3}
            };
            Assert.AreEqual(new string[] {"Alysa"}, Friday13thPart1.KillCount(counselors, 7));
        }
    }
}