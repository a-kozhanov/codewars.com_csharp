using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class BasicVariableAssignmentTests
    {
        [Test]
        public void Test()
        {
            Assert.AreEqual("codewa.rs", BasicVariableAssignment.Name);
        }
    }
}