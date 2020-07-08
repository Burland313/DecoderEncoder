using Microsoft.VisualStudio.TestTools.UnitTesting;
using DecoderEncoder;

namespace DecoderEncoderTest
{
    [TestClass]
    public class AlphabetTest
    {
        [TestMethod]
        public void CreationTest()
        {
            //Arrange
            string actual = "";
            string expected = "DEFGHIJKLMNOPQRSTUVWXYZABC";

            //Act
            actual = DecoderEncoder.Factory.AlphabetCreator.CreateWithShift(3);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
