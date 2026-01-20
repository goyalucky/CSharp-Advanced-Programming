/* Basic NUnit Test: Testing a Calculator Class
Problem:
Create a Calculator class with methods:
● Add(int a, int b)
● Subtract(int a, int b)
● Multiply(int a, int b)
● Divide(int a, int b)
Write NUnit or MSTest test cases for each method.
Bonus: Test for division by zero and handle exceptions properly. */

using NUnit.Framework;
using System;
using CalculatorApp;

namespace CalculatorApp.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator calc;

        [SetUp]
        public void Setup()
        {
            calc = new Calculator();
        }

        [Test]
        public void AddTwoNumbers()
        {
            int result = calc.Add(10, 5);
            Assert.AreEqual(15, result);
        }

        [Test]
        public void SubtractTwoNumbers()
        {
            int result = calc.Subtract(10, 5);
            Assert.AreEqual(5, result);
        }

        [Test]
        public void MultiplyTwoNumbers()
        {
            int result = calc.Multiply(4, 5);
            Assert.AreEqual(20, result);
        }

        [Test]
        public void DivideTwoNumbers()
        {
            int result = calc.Divide(20, 4);
            Assert.AreEqual(5, result);
        }

        // Division by zero test
        [Test]
        public void DivideByZero()
        {
            Assert.Throws<DivideByZeroException>(() =>
            {
                calc.Divide(10, 0);
            });
        }    }
}
