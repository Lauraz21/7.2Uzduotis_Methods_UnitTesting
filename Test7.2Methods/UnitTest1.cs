using _7._2Uzduotis_Methods_UnitTesting;

namespace Test7._2Methods
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestDollars()
        {
            float userInput = 100;
            float expected = 85;

            float actual = Program.ConvertToEuros(userInput);

            Assert.AreEqual(expected, actual);
        }
    }
}