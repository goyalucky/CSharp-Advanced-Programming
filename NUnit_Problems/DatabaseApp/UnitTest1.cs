/* Testing Setup and Teardown (NUnit: [SetUp] & [TearDown])
Problem:
Create a class DatabaseConnection with methods:
● Connect()
● Disconnect()
Use [SetUp] (NUnit) or [TestInitialize] (MSTest) to initialize a database connection before each test.
Use [TearDown] (NUnit) or [TestCleanup] (MSTest) to close the connection after each test.
Write test cases to verify that the connection is established and closed correctly. */

using NUnit.Framework;

namespace DatabaseApp  
{
    [TestFixture]
    public class UnitTest1
    {
        private DatabaseConnection db;

        [SetUp]
        public void Setup()
        {
            db = new DatabaseConnection();
            db.Connect();
        }

        [TearDown]
        public void TearDown()
        {
            db.Disconnect();
        }

        [Test]
        public void ConnectWorks()
        {
            Assert.IsTrue(db.IsConnected);
        }

        [Test]
        public void DisconnectWorks()
        {
            db.Disconnect();
            Assert.IsFalse(db.IsConnected);
        }
    }
}
