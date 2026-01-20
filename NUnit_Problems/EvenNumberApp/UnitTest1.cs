/* Testing Parameterized Tests
Problem:
Create a method IsEven(int number) that returns true if a number is even.
Use NUnit [TestCase] or MSTest [DataRow] to test this method with multiple
values like 2, 4, 6, 7, 9. */

using NUnit.Framework;

namespace EvenNumberApp
{
    [TestFixture]
    public class UnitTest1
    {
        private NumberUtils num;

        [SetUp]
        public void Setup()
        {
            num = new NumberUtils();
        }

        //Multiple inputs tested using TestCase
        [TestCase(2, true)]
        [TestCase(4, true)]
        [TestCase(6, true)]
        [TestCase(7, false)]
        [TestCase(9, false)]
        public void IsEven_Test(int value, bool expected)
        {
            bool result = num.IsEven(value);
            Assert.AreEqual(expected, result);
        }
    }
}
