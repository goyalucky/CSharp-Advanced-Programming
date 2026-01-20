/* Testing File Handling Methods
Problem:
Create a class FileProcessor with the following methods:
● WriteToFile(string filename, string content): Writes content to a file.
● ReadFromFile(string filename): Reads content from a file.
Write unit tests to check if:
The content is written and read correctly.
The file exists after writing.
Handling of IOException when the file does not exist. */


using NUnit.Framework;
using System;
using System.IO;

namespace FileHandlingApp
{
    [TestFixture]
    public class UnitTest1
    {
        private FileProcessor fp;
        private string filePath;

        [SetUp]
        public void Setup()
        {
            fp = new FileProcessor();
            filePath = "testfile.txt";
        }

        [TearDown]
        public void Cleanup()
        {
            if (File.Exists(filePath))
                File.Delete(filePath);
        }

        [Test]
        public void WriteRead_Works()
        {
            fp.WriteToFile(filePath, "Hello NUnit");
            string result = fp.ReadFromFile(filePath);
            Assert.AreEqual("Hello NUnit", result);
        }

        [Test]
        public void Write_FileExists()
        {
            fp.WriteToFile(filePath, "Data");
            Assert.IsTrue(File.Exists(filePath));
        }

        [Test]
        public void Read_FileNotFound_Throws()
        {
            Assert.Throws<IOException>(() => fp.ReadFromFile("nofile.txt"));
        }
    }
}
