using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class ClassyExtentionsTests
    {
        [Test]
        public void Test()
        {
            ClassyExtentions.Cat cat = new ClassyExtentions.Cat("Mr Whiskers");
            Assert.AreEqual("Mr Whiskers meows.", cat.Speak());
            Assert.That(cat is ClassyExtentions.Animal, "The Cat class should inherit from Animal");

            cat = new ClassyExtentions.Cat("Lamp");
            Assert.AreEqual("Lamp meows.", cat.Speak());
            Assert.That(cat is ClassyExtentions.Animal, "The Cat class should inherit from Animal");

            cat = new ClassyExtentions.Cat("$$Money Bags$$");
            Assert.AreEqual("$$Money Bags$$ meows.", cat.Speak());
            Assert.That(cat is ClassyExtentions.Animal, "The Cat class should inherit from Animal");
        }
    }
}