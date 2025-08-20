using Microsoft.VisualStudio.TestTools.UnitTesting;
//comment
namespace Mon18thUnitTesting
{
    [TestClass]
    public class CalculatorTests
    {
        private readonly Calculator cal = new Calculator();

        [TestMethod]
        public void TwoPlusTwoShouldEqualFour()
        {
            Assert.AreEqual(4, cal.Add(2, 2));
        }

        [TestMethod]
        public void TwoPlusThreeShouldEqualFive()
        {
            Assert.AreEqual(5, cal.Add(2, 3));
        }


        [TestMethod]
        public void FullNameShouldReturnConcatenatedString()
        {
            Assert.AreEqual("Trevor Smith", cal.FullName("Trevor", "Smith"));
        }
    }
}
