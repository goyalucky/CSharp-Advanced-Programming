/* Testing Password Strength Validator
Problem: Create a PasswordValidator class with
● Passwords must have at least 8 characters, one uppercase letter, and one digit.
Write unit tests for valid and invalid passwords. */

using NUnit.Framework;
using PasswordStrength;

namespace PasswordStrength.Tests
{
    [TestFixture]
    public class PasswordValidatorTests
    {
        private PasswordValidator validator;

        // Runs before each test
        [SetUp]
        public void SetUp()
        {
            validator = new PasswordValidator();
        }

        [Test]
        public void ValidPassword_ReturnsTrue()
        {
            // Act
            bool result = validator.IsValid("StrongPass1");

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void PasswordTooShort_ReturnsFalse()
        {
            bool result = validator.IsValid("Abc1");
            Assert.IsFalse(result);
        }

        [Test]
        public void PasswordWithoutUppercase_ReturnsFalse()
        {
            bool result = validator.IsValid("weakpass1");
            Assert.IsFalse(result);
        }

        [Test]
        public void PasswordWithoutDigit_ReturnsFalse()
        {
            bool result = validator.IsValid("Password");
            Assert.IsFalse(result);
        }

        [Test]
        public void EmptyPassword_ReturnsFalse()
        {
            bool result = validator.IsValid("");
            Assert.IsFalse(result);
        }

        [Test]
        public void NullPassword_ReturnsFalse()
        {
            bool result = validator.IsValid(null);
            Assert.IsFalse(result);
        }
    }
}
