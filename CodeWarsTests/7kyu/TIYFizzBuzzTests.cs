using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class TIYFizzBuzzTests
    {
        [Test]
        public void MyTest()
        {
            Assert.AreEqual("Iron", TIYFizzBuzz.FizzBuzz("H"));

            Assert.AreEqual("Yard", TIYFizzBuzz.FizzBuzz("e"));

            Assert.AreEqual("l", TIYFizzBuzz.FizzBuzz("l"));

            Assert.AreEqual("Iron Yard", TIYFizzBuzz.FizzBuzz("O"));

            Assert.AreEqual("?", TIYFizzBuzz.FizzBuzz("?"));

            Assert.AreEqual("IronYardllYard IronIron YardIronIronIron!", TIYFizzBuzz.FizzBuzz("Hello WORLD!"));
        }
    }
    
}