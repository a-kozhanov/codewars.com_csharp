using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class GrasshopperVariableAssignmentDebugTests
    {
        [Test]
        public static void Tests()
        {
            Assert.AreEqual("dev", GrasshopperVariableAssignmentDebug.a);
            Assert.AreEqual("Lab", GrasshopperVariableAssignmentDebug.b);
            Assert.AreEqual("devLab", GrasshopperVariableAssignmentDebug.name);
        }
    }
}