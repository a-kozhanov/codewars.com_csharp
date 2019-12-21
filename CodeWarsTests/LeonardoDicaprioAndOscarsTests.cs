using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class LeonardoDicaprioAndOscarsTests
    {
        [Test]
        [TestCase(88, ExpectedResult = "Leo finally won the oscar! Leo is happy")]
        public string LeoTest(int oscar)
        {
            return LeonardoDicaprioAndOscars.Leo(oscar);
        }
    }
}