using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class FixmeGetFullNameTests
    {
        [Test, Description("Sample Test")]
        public void SampleTest()
        {
            // Assert.AreEqual("Clint Eastwood", new FIXMEGetFullName.Dinglemouse("Clint", "Eastwood").FullName);
            Assert.AreEqual("Clint Eastwood", new FixmeGetFullName("Clint", "Eastwood").FullName);
        }
    }
}