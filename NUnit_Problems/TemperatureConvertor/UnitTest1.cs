/* Testing Temperature Converter
Problem:
Create a TemperatureConverter class with:
● CelsiusToFahrenheit(double celsius): Converts Celsius to Fahrenheit.
● FahrenheitToCelsius(double fahrenheit): Converts Fahrenheit to Celsius.
 Write unit tests to validate conversions. */


using NUnit.Framework;
using TemperatureConvertor;

namespace TemperatureConvertor.Tests
{
    [TestFixture]
    public class TempConvTests
    {
        private TemperatureConvertor.TemperatureConverter conv;

        [SetUp]
        public void SetUp()
        {
            conv = new TemperatureConvertor.TemperatureConverter();
        }

        [Test]
        public void CtoF_Zero()
        {
            Assert.AreEqual(32, conv.CtoF(0));
        }

        [Test]
        public void CtoF_Hundred()
        {
            Assert.AreEqual(212, conv.CtoF(100));
        }

        [Test]
        public void FtoC_32()
        {
            Assert.AreEqual(0, conv.FtoC(32));
        }

        [Test]
        public void FtoC_212()
        {
            Assert.AreEqual(100, conv.FtoC(212));
        }

        [Test]
        public void CtoF_Minus40()
        {
            Assert.AreEqual(-40, conv.CtoF(-40), 0.0001);
        }
    }
}