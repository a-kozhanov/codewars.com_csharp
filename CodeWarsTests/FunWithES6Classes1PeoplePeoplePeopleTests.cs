using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class FunWithES6Classes1PeoplePeoplePeopleTests
    {
        [Test, Description("should have the correct defaults")]
        public void DefaultArgsTest()
        {
            Person person = new Person();
            Assert.AreEqual("John", person.FirstName);
            Assert.AreEqual("Doe", person.LastName);
            Assert.AreEqual(0, person.Age);
            Assert.AreEqual("Male", person.Gender);
            Assert.AreEqual("John Doe", person.SayFullName());
        }

        [Test, Description("should work with a person Jane Doe")]
        public void CustomTest()
        {
            Person person = new Person("Jane", "Doe", 25, "Female");
            Assert.AreEqual("Jane", person.FirstName);
            Assert.AreEqual("Doe", person.LastName);
            Assert.AreEqual(25, person.Age);
            Assert.AreEqual("Female", person.Gender);
            Assert.AreEqual("Jane Doe", person.SayFullName());
        }
    }
}