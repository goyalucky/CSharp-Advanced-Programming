/* Testing User Registration
Problem:
Create a UserRegistration class with:
● RegisterUser(string username, string email, string password).
● Throws ArgumentException for invalid inputs.
Write unit tests to verify valid and invalid user registrations. */

using NUnit.Framework;
using System;
using UserApp;

namespace UserApp.Tests
{
    [TestFixture]
    public class UserRegistrationTests
    {
        private UserRegistration ur;

        [SetUp]
        public void Init()
        {
            ur = new UserRegistration();
        }

        [Test]
        public void Register_ValidUser_ReturnsTrue()
        {
            bool result = ur.Register(
                "prashant",
                "prashant@mail.com",
                "Password1");

            Assert.IsTrue(result);
        }

        [Test]
        public void Register_InvalidUsername_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                ur.Register("", "test@mail.com", "Password1");
            });
        }

        [Test]
        public void Register_InvalidEmail_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                ur.Register("user", "invalid-email", "Password1");
            });
        }

        [Test]
        public void Register_ShortPassword_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                ur.Register("user", "user@mail.com", "123");
            });
        }

        [Test]
        public void Register_NullValues_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                ur.Register(null, null, null);
            });
        }
    }
}
