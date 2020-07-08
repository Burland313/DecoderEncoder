using Microsoft.VisualStudio.TestTools.UnitTesting;
using DecoderEncoder;

namespace DecoderEncoderTest
{
    [TestClass]
    public class CaeserTest
    {
        [TestMethod]
        public void EncodeTest()
        {
            //Arrange
            string actual = "";
            string expected = "KHOOR";

            //Act
            CaesarShiftCipher cipher = new CaesarShiftCipher();
            actual = cipher.Encode("HELLO", 3);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DecodeTest()
        {
            //Arrange
            string actual = "";
            string expected = "HELLO";

            //Act
            CaesarShiftCipher cipher = new CaesarShiftCipher();
            actual = cipher.Decode("KHOOR", 3);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
