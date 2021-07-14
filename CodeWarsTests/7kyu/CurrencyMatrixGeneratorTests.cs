using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class CurrencyMatrixGeneratorTests
    {
        [Test]
        public void BasicTests()
        {
            var expected = string.Join(",",
                new string[] {"EURGBP", "EURAUD", "EURNZD", "EURUSD", "EURCAD", "EURCHF", "EURJPY"});
            Assert.AreEqual(expected, string.Join(",", CurrencyMatrixGenerator.GenerateCurrencyMatrix("EUR")));

            expected = string.Join(",",
                new string[] {"EURGBP", "GBPAUD", "GBPNZD", "GBPUSD", "GBPCAD", "GBPCHF", "GBPJPY"});
            Assert.AreEqual(expected, string.Join(",", CurrencyMatrixGenerator.GenerateCurrencyMatrix("GBP")));

            expected = string.Join(",",
                new string[] {"EURCHF", "GBPCHF", "AUDCHF", "NZDCHF", "USDCHF", "CADCHF", "CHFJPY"});
            Assert.AreEqual(expected, string.Join(",", CurrencyMatrixGenerator.GenerateCurrencyMatrix("CHF")));
        }
    }
}