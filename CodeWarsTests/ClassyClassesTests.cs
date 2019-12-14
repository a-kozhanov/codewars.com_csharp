using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class ClassyClassesTests
    {
        [Test, Description("Should create a Person and have a getter for the Info property")]
        public void Test()
        {
            ClassyClasses john = new ClassyClasses("john", 34);
            Assert.AreEqual("johns age is 34", john.Info);
        }
    }
}