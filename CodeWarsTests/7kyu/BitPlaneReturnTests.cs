using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class BitPlaneReturnTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.That(BitPlaneReturn.BitSlice(new byte[][]
                {
                    new byte[] {68, 69, 75, 100},
                    new byte[] {71, 82, 106, 117},
                    new byte[] {119, 117, 126, 132},
                    new byte[] {116, 127, 146, 111}
                }, 3),
                Is.EqualTo(new byte[][]
                {
                    new byte[] {0, 0, 1, 0},
                    new byte[] {0, 0, 1, 0},
                    new byte[] {0, 0, 1, 0},
                    new byte[] {0, 1, 0, 1}
                }), "Should return bit plane 3");

            Assert.That(BitPlaneReturn.BitSlice(new byte[][]
                {
                    new byte[] {24, 35, 49, 51, 49},
                    new byte[] {27, 38, 47, 50, 50},
                    new byte[] {32, 39, 47, 50, 53},
                    new byte[] {38, 45, 49, 51, 53},
                    new byte[] {43, 49, 49, 50, 51}
                }, 2),
                Is.EqualTo(new byte[][]
                {
                    new byte[] {0, 0, 0, 0, 0},
                    new byte[] {0, 1, 1, 0, 0},
                    new byte[] {0, 1, 1, 0, 1},
                    new byte[] {1, 1, 0, 0, 1},
                    new byte[] {0, 0, 0, 0, 0}
                }), "Should return bit plane 2");

            Assert.That(BitPlaneReturn.BitSlice(new byte[][]
                {
                    new byte[] {19, 27, 38, 46, 60, 63},
                    new byte[] {19, 22, 30, 38, 55, 58},
                    new byte[] {22, 22, 22, 39, 45, 54},
                    new byte[] {22, 22, 21, 45, 54, 63},
                    new byte[] {21, 19, 21, 36, 51, 64},
                    new byte[] {21, 21, 19, 24, 45, 60}
                }, 7),
                Is.EqualTo(new byte[][]
                {
                    new byte[] {0, 0, 0, 0, 0, 0},
                    new byte[] {0, 0, 0, 0, 0, 0},
                    new byte[] {0, 0, 0, 0, 0, 0},
                    new byte[] {0, 0, 0, 0, 0, 0},
                    new byte[] {0, 0, 0, 0, 0, 0},
                    new byte[] {0, 0, 0, 0, 0, 0}
                }), "Should return bit plane 7");

            Assert.That(BitPlaneReturn.BitSlice(new byte[][]
                {
                    new byte[] {73, 147, 208, 216, 216, 209, 175, 158},
                    new byte[] {66, 93, 158, 199, 206, 190, 185, 136},
                    new byte[] {65, 71, 123, 180, 205, 189, 170, 141},
                    new byte[] {63, 45, 76, 149, 198, 183, 153, 139},
                    new byte[] {61, 39, 51, 120, 185, 181, 149, 130},
                    new byte[] {58, 47, 49, 96, 161, 175, 158, 121},
                    new byte[] {49, 46, 46, 70, 127, 158, 160, 110},
                    new byte[] {36, 39, 42, 51, 99, 141, 141, 96}
                }, 0),
                Is.EqualTo(new byte[][]
                {
                    new byte[] {1, 1, 0, 0, 0, 1, 1, 0},
                    new byte[] {0, 1, 0, 1, 0, 0, 1, 0},
                    new byte[] {1, 1, 1, 0, 1, 1, 0, 1},
                    new byte[] {1, 1, 0, 1, 0, 1, 1, 1},
                    new byte[] {1, 1, 1, 0, 1, 1, 1, 0},
                    new byte[] {0, 1, 1, 0, 1, 1, 0, 1},
                    new byte[] {1, 0, 0, 0, 1, 0, 0, 0},
                    new byte[] {0, 1, 0, 1, 1, 1, 1, 0}
                }), "Should return bit plane 7");
        }
    }
}