using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DecoderEncoderTest
{
    [TestClass]
    public class StringFormatterTest
    {
        [TestMethod]
        public void StringFormatTest()
        {
            //Arrange
            string actual;
            string expected = "WHATSUP";

            //Act
            actual = DecoderEncoder.Factory.StringFormatter.FormatString("whats  UP");

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
