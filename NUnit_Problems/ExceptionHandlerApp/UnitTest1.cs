/* Testing Exception Handling
Problem: Create a method Divide(int a, int b) that throws an ArithmeticException if b is zero. Write a unit test to verify that the 
exception is thrown properly. */


using NUnit.Framework;
using System;
using ExceptionHandlerApp;

namespace ExceptionHandlerApp.Tests
{
    [TestFixture]
    public class UnitTest1
    {
        private ExceptionService ex;

        [SetUp]
        public void Setup()
        {
            ex = new ExceptionService();
        }

        [Test]
        public void DivideValid()
        {
            int result = ex.Divide(10, 2);
            Assert.AreEqual(5, result);
        }

        [Test]
        public void DivideByZero()
        {
            Assert.Throws<ArithmeticException>(() => ex.Divide(10, 0));
        }
    }
}
