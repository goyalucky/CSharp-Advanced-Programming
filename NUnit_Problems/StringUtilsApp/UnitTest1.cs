/* Testing String Utility Methods
Problem:
Create a StringUtils class with the following methods:
● Reverse(string str): Returns the reverse of a given string.
● IsPalindrome(string str): Returns true if the string is a palindrome.
● ToUpperCase(string str): Converts a string to uppercase.
Write NUnit or MSTest test cases to verify that these methods work correctly. */

using NUnit.Framework;
using System;
using StringUtilsApp;

namespace StringUtilsApp.Tests
{
    // Marks this class as a test fixture in NUnit
    [TestFixture]
    public class StringUtilsTests
    {
        private StringUtils stringUtils;

        // Runs before each test case
        [SetUp]
        public void Setup()
        {
            // Create a fresh instance for every test
            stringUtils = new StringUtils();
        }

        [Test]
        public void ReverseValidString()
        {
            //call the method under test
            string result = stringUtils.Reverse("hello");

            // verify expected output
            Assert.AreEqual("olleh", result);
        }

        [Test]
        public void IsPalindromeTrue()
        {
            // Act
            bool result = stringUtils.IsPalindrome("madam");

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void IsPalindromeFalse()
        {
            // Act
            bool result = stringUtils.IsPalindrome("hello");

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void ToUpperCaseValidString()
        {
            // Act
            string result = stringUtils.ToUpperCase("hello");

            // Assert
            Assert.AreEqual("HELLO", result);
        }

        // null input should throw exception
        [Test]
        public void ReverseNullString()
        {
            // Assert that expected exception is thrown
            Assert.Throws<ArgumentNullException>(() =>
            {
                stringUtils.Reverse(null);
            });
        }

        [Test]
        public void ToUpperCase_NullString_ThrowsArgumentNullException()
        {
            // Assert exception handling
            Assert.Throws<ArgumentNullException>(() =>
            {
                stringUtils.ToUpperCase(null);
            });
        }
    }
}
