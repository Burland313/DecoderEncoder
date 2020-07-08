using Microsoft.VisualStudio.TestTools.UnitTesting;
using DecoderEncoder.Ciphers.Vigenere;
using DecoderEncoder.Ciphers.VigenereCipher;

namespace DecoderEncoderTest
{
    [TestClass]
    public class VigenereTest
    {
        [TestMethod]
        public void EncodeTest()
        {
            //Arrange
            string actual = "";
            string expected = "XBTMKVJI";

            //Act
            VigenereCipher cipher = new VigenereCipher();
            //actual = VigenereCipherFunctions.CreateKeywordString("WHATSUPP", "BUTT");
            actual = cipher.Encode("WHATSUPP", "BUTTS");

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CiphertextTest()
        {
            //Arrange
            string expected = "WEIGHT";

            //Act
            string actual = VigenereCipherFunctions.CreatePlaintext("HMNZSB", "LIFTLI");

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void KeywordStringTest()
        {
            //Arrange
            string expected = "BUTTSBUTTSBU";

            //Act
            string actual = VigenereCipherFunctions.CreateKeywordString("MYNAMEISNATE", "BUTTS");

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}