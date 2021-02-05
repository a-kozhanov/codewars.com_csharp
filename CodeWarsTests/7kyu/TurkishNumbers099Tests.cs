using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class TurkishNumbers099Tests
    {
        [Test]
        public void ExampleTest()
        {
            int[] exampleInputs = new int[] {1, 13, 27, 38, 77, 94};
            string[] exampleOutputs = new string[]
                {"bir", "on üç", "yirmi yedi", "otuz sekiz", "yetmiş yedi", "doksan dört"};

            for (int i = 0; i < exampleInputs.Length; i++)
                Assert.AreEqual(exampleOutputs[i], TurkishNumbers099.GetTurkishNumber(exampleInputs[i]));
        }
    }
}