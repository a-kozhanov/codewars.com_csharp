using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class TrainingJS7Tests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(100, TrainingJS7.SaleHotDogs(1));
            Assert.AreEqual(400, TrainingJS7.SaleHotDogs(4));
            Assert.AreEqual(475, TrainingJS7.SaleHotDogs(5));
            Assert.AreEqual(855, TrainingJS7.SaleHotDogs(9));
            Assert.AreEqual(900, TrainingJS7.SaleHotDogs(10));
            Assert.AreEqual(9000, TrainingJS7.SaleHotDogs(100));
        }
    }
}