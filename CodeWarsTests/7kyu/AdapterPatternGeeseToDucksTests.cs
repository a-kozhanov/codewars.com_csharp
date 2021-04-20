using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class AdapterPatternGeeseToDucksTests
    {
        [Test]
        public void Test1()
        {
            Goose goose = new Goose();
            GooseToIDuckAdapter adapter = new GooseToIDuckAdapter(goose);

            Assert.AreEqual(adapter.Quack(), goose.Honk());
        }
    }
}