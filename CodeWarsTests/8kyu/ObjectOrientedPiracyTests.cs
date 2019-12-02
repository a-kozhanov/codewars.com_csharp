using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class ObjectOrientedPiracyTests
    {
        [Test]
        public void SampleTest()
        {
            ObjectOrientedPiracy titanic = new ObjectOrientedPiracy(15, 10);

            Assert.AreEqual(false, titanic.IsWorthIt());

            // Mutation tests
            Assert.AreEqual(15, titanic.Draft, "Do you need two eyepatches, mate? That ship is clearly 15 draft deep.");
            Assert.AreEqual(10, titanic.Crew, "Do you need two eyepatches, mate? That ship clearly has a crew of 10 people.");
        }
    }
}